using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;



namespace MangaReader
{
    public partial class LogIn : Form
    {

        public LogIn()
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
        bool MenuExpand = true;
        bool mainExpand = true;
        bool isSingIn = false;
        private void button1_Click(object sender, EventArgs e)
        {
            MenuTimer.Start();
            mainTimer.Start();

        }


        private void mainTimer_Tick(object sender, EventArgs e)
        {
            if (mainExpand)
            {
                int i = Convert.ToInt32(main.Location.X.ToString());
                i -= 10;
                main.Location = new Point(i, 0);
                isSingIn = true;

                if (main.Location.X.ToString() == "60")
                {
                    mainExpand = false;
                    mainTimer.Stop();
                }
            }
            else
            {
                int i = Convert.ToInt32(main.Location.X.ToString());
                i += 10;
                main.Location = new Point(i, 0);
                isSingIn = false;
                if (main.Location.X.ToString() == "430")
                {
                    mainExpand = true;
                    mainTimer.Stop();
                }
            }
        }



        private void MenuTimer_Tick(object sender, EventArgs e)
        {

            if (MenuExpand)
            {

                int i = Convert.ToInt32(menu.Location.X.ToString());
                i += 20;
                menu.Location = new Point(i, 0);
                int v = Convert.ToInt32(lbmain.Location.X.ToString());
                v -= 2;
                lbmain.Location = new Point(v, 77);
                int x = Convert.ToInt32(lbmenu.Location.X.ToString());
                x += 1;
                lbmenu.Location = new Point(x, 236);
                txtmail.Hide();
                if (menu.Location.X.ToString() == "320")
                {
                    lbmain.Text = "Sing in to Hero Manga";
                    lbmenu.Text = "Hello, Hero!";
                    btnmain.Text = "sing in";
                    btnmenu.Text = "sing up";
                    lb1.Text = "Enter your personal details";
                    lb2.Text = "And start reading with us";

                }
                if (menu.Location.X.ToString() == "760")
                {
                    MenuExpand = false;
                    MenuTimer.Stop();
                }
            }
            else
            {
                int i = Convert.ToInt32(menu.Location.X.ToString());
                i -= 20;
                menu.Location = new Point(i, 0);
                int v = Convert.ToInt32(lbmain.Location.X.ToString());
                v += 2;
                lbmain.Location = new Point(v, 77);
                int x = Convert.ToInt32(lbmenu.Location.X.ToString());
                x -= 1;
                lbmenu.Location = new Point(x, 236);
                txtmail.Show();
                if (menu.Location.X.ToString() == "320")
                {
                    lbmain.Text = "Create Account";
                    lbmenu.Text = "Welcome back!";
                    btnmain.Text = "sing up";
                    btnmenu.Text = "sing in";
                    lb1.Text = "To keep connected with us please";
                    lb2.Text = "logIn with your personal info";
                }
                if (menu.Location.X.ToString() == "0")
                {
                    MenuExpand = true;
                    MenuTimer.Stop();
                }
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            btnmain.IdleBorderRadius = 30;
            txtmail.PlaceholderText = "Email";
            txtpassword.PlaceholderText = "Password";

            txtuser.PlaceholderText = "Name";

        }



        private void btnmain_Click(object sender, EventArgs e)
        {
            if (isSingIn)
            {
                string role = "";
                SqlConnection sc = getsc();
                sc.Open();
                SqlCommand com = new SqlCommand(string.Format("select * from manga_user where name ='{0}'", txtuser.Text), sc);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["password"].ToString() == hash(txtpassword.Text))
                    {
                        role = dr["role"].ToString();
                    }
                }
                if (role != string.Empty)
                {

                    this.Hide();
                    HomeForm f = new HomeForm(role);
                    f.ShowDialog();
                    this.Close();
                    //this.Show();
                }
                else
                    MessageBox.Show("Name or password is incorrect", "login error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sc.Close();
                dr.Close();
                dr = null;
            }
            else
            {
                using (SqlConnection cn = getsc())
                {

                    cn.Open();
                    SqlCommand cmd = new SqlCommand("insert into manga_user(name,email,password,role) values(@name,@email,@password,@role)", cn);
                    cmd.Parameters.AddWithValue("@name", txtuser.Text);
                    cmd.Parameters.AddWithValue("@email", txtmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                    cmd.Parameters.AddWithValue("@role", "admin");

                    cmd.ExecuteNonQuery();
                    



                    cn.Close();

                }
                string role = "";
                SqlConnection sc = getsc();
                sc.Open();
                SqlCommand com = new SqlCommand(string.Format("select * from manga_user where name ='{0}'", txtuser.Text), sc);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["password"].ToString() == hash(txtpassword.Text))
                    {
                        role = dr["role"].ToString();
                    }
                }
                if (role != string.Empty)
                {

                    this.Hide();
                    HomeForm f = new HomeForm(role);
                    f.ShowDialog();
                    this.Close();
                    //this.Show();
                }
                else
                    MessageBox.Show("Name or password is incorrect", "login error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sc.Close();
                dr.Close();
                dr = null;


            }


        }
    }
}
