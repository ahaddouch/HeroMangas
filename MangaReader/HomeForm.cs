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
using System.Security.Cryptography;

namespace MangaReader
{
    public partial class HomeForm : Form
    {
        bool MenuExpand=false;
        
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

        public HomeForm()
        {
            InitializeComponent();
        }
        string role;
        public HomeForm(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            if (MenuExpand)
            {
                Menu.Width -= 10;
                if (Menu.Width == Menu.MinimumSize.Width)
                {
                    MenuExpand = false;
                    MenuTimer.Stop();
                }
            }
            else
            {
                Menu.Width += 10;
                if (Menu.Width == Menu.MaximumSize.Width)
                {
                    MenuExpand = true;
                    MenuTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuTimer.Start();
        }

        private void AfficherFenetre(Form f)
        {
            if (pnlMain.Controls.Count > 0)
            {
                Form oldForm = (Form)pnlMain.Controls[0];
                oldForm.Close();
            }

            pnlMain.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            this.pnlMain.Controls.Add(f);
            f.Show();
        }

        private void btnUpl_Click(object sender, EventArgs e)
        {
            UploadManga f = new UploadManga();
            AfficherFenetre(f);
            if (Menu.Width == Menu.MaximumSize.Width)
            {
                MenuTimer.Start();
            }
            btnBack.Show();
        }

        public void fillMain(Form f)
        {
            pnlMain.Controls.Clear();
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.AutoScroll = true;
            pnlMain.Controls.Add(f);
            f.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            MangaList f = new MangaList();
            fillMain(f);
            if (Menu.Width == Menu.MaximumSize.Width)
            {
                MenuTimer.Start();

            }
            btnBack.Hide();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            UploadChapetrs f = new UploadChapetrs();
            fillMain(f);
            if (Menu.Width == Menu.MaximumSize.Width)
            {
                MenuTimer.Start();
            }
            btnBack.Show();
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnList.PerformClick();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            btnList.PerformClick();
            
        }

        
    }
        
}
