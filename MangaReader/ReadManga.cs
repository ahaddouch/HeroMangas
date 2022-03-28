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
    public partial class ReadManga : Form
    {
        public ReadManga()
        {
            InitializeComponent();
        }
        int id;
        public ReadManga(int id)
        {
            InitializeComponent();
            this.id = id;
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
        void loadimage()
        {
            
            SqlConnection sc = getsc();
            sc.Open();
            string c = string.Format("select * from image where id_chapter ='{0}'", id.ToString());
            SqlCommand com = new SqlCommand(c, sc);

            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                byte[] pic = ((byte[])dr["img"]);

                var ms = new MemoryStream(pic);
                


                PictureBox pb = new PictureBox();
                pb.Height = 800;
                pb.Width = 800;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Image = Image.FromStream(ms);
                flowLayoutPanel1.Controls.Add(pb);
                pb.Controls.Clear();
            }
                
            sc.Close();
            dr.Close();
            dr = null;
        }
        private void ReadManga_Load(object sender, EventArgs e)
        {
            loadimage();
            
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
