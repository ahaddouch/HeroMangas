using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;

namespace MangaReader
{
    public partial class MangaList : Form
    {
        public MangaList()
        {
            InitializeComponent();
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
       
        private void MangaList_Load(object sender, EventArgs e)
        {
            loadmanga("");
        }

        void loadmanga(string f)
        {

            SqlConnection sc = getsc();
            sc.Open();
            SqlCommand com;
            if (f=="")
                 com=new SqlCommand("select * from manga", sc);
            else
                com= new SqlCommand("select * from manga where name_manga like '%"+f+"%'",sc);

            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
                flp.Controls.Add(new MangaItem(dr[2].ToString(), dr[1].ToString(), (byte[])dr[3]));
            sc.Close();
            dr.Close();
            dr = null;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            loadmanga(txtFind.Text);
        }

        private void flp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}