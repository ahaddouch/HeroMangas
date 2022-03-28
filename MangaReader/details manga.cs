using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.Security.Cryptography;

namespace MangaReader
{
    public partial class details_manga : Form
    {
        string title;
        public details_manga()
        {
            InitializeComponent();
        }
        public details_manga(string title)
        {
            InitializeComponent();
            this.title = title;
        }
        

        public byte[] cle = System.Convert.FromBase64String("12UCgcnHy8LHoN/VodosrUVgv+r+kQ5e");
        public byte[] iv = System.Convert.FromBase64String("AsJNO9N/4dM=");
        SqlConnection getsc()
        {
            string cs = ConfigurationManager.ConnectionStrings["HeroMangaConnection"].ConnectionString;
            string cs1 = DecryptSym(Convert.FromBase64String(cs), cle, iv);

            return new SqlConnection(DecryptSym(Convert.FromBase64String(cs), cle, iv));
        }


        public string DecryptSym(byte[] cryptedTextAsByte, byte[] key, byte[] iv)
        {
            TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();

            // Cet objet est utilisé pour déchiffrer les données.
            // Il reçoit les données chiffrées sous la forme d'un tableau de bytes.
            // Les données déchiffrées sont également retournées sous la forme d'un tableau de bytes
            var decryptor = TDES.CreateDecryptor(key, iv);

            byte[] decryptedTextAsByte = decryptor.TransformFinalBlock(cryptedTextAsByte, 0, cryptedTextAsByte.Length);

            return Encoding.Default.GetString(decryptedTextAsByte);
        }
        static public string hash(string chaine)
        {
            byte[] textAsByte = Encoding.Default.GetBytes(chaine);

            SHA512 sha512 = SHA512Cng.Create();

            byte[] hash = sha512.ComputeHash(textAsByte);

            return Convert.ToBase64String(hash);

        }

        void getMAngaDetails()
        {
            if (title != null)
            {
                SqlConnection sc1 = getsc();
                sc1.Open();
                SqlCommand com3 = new SqlCommand(string.Format("select * from manga where name_manga ='{0}'", title), sc1);
                SqlDataReader dr1 = com3.ExecuteReader();
                while (dr1.Read())
                {
                    lbname.Text = dr1["name_manga"].ToString();
                    lbdescreption.Text = dr1["descreption"].ToString();
                    lbauteur.Text = dr1["auteur"].ToString();
                    lbage.Text = dr1["ageG"].ToString();
                    lbtype.Text = dr1["type"].ToString();
                    lbyear.Text = dr1["dateP"].ToString();
                    byte[] pic = ((byte[])dr1["pictur"]);

                    var ms = new MemoryStream(pic);
                    pictur.Image = Image.FromStream(ms);

                }
                dr1.Close();
                sc1.Close();
                SqlConnection sc2 = getsc();
                sc2.Open();
                SqlCommand com4 = new SqlCommand(string.Format("select * from genre where id_manga in (select id_manga from manga where name_manga ='{0}')", title), sc2);
                SqlDataReader dr2 = com4.ExecuteReader();
               while (dr2.Read())
                {
                    lbgenre.Text= dr2["name"].ToString();
                }
                sc2.Close();
                dr2.Close();
                dr2 = null;




            }

        }
        void loadmanga()
        {

            SqlConnection sc = getsc();
            sc.Open();
            
            SqlCommand com = new SqlCommand(string.Format("select * from chapter where id_manga in (select id_manga from manga where name_manga ='{0}')", title), sc);

            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
                flowLayoutPanel1.Controls.Add(new chapter(Convert.ToInt32(dr[0].ToString()) , dr[1].ToString(), dr[2].ToString()));
            sc.Close();
            dr.Close();
            dr = null;
        }
        private void details_manga_Load(object sender, EventArgs e)
        {

            getMAngaDetails();
            loadmanga();

        }

       
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
