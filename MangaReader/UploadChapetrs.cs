using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace MangaReader
{
    public partial class UploadChapetrs : Form
    {
        public UploadChapetrs()
        {
            InitializeComponent();
        }
        bool isAdd, isMod, isDel = false;
        string cs = @"Data Source=ADAM\SQL;Initial Catalog=HeroManga;User ID=sa;Password=123456";
        private void DesEnb()
        {

            cbChapter.Items.Clear();
            txtNumber.Text = string.Empty;
            txt_title.Text = string.Empty;
            flowLayoutPanel1.Controls.Clear();
            listBox2.Items.Clear();
            if (isAdd)
            {

                lbchapter.Show();
                lbSlect.Hide();
                
                cbChapter.Hide();
                txtNumber.Show();



                pnlSelect.Hide();
                pnlChapter.Hide();
                pnlSave.Hide();
                

               

            }

            else if (isMod)
            {
                lbchapter.Hide();
                lbSlect.Show();

                cbChapter.Show();
                txtNumber.Hide();


            }

            else if (isDel)
            {
                lbchapter.Hide();
                lbSlect.Show();

                cbChapter.Show();
                txtNumber.Hide();

                pnlSelect.Show();
                pnlChapter.Show();
                pnlSave.Show();
            }
            else
            {

                lbchapter.Hide();
                lbSlect.Show();

                cbChapter.Show();
                txtNumber.Hide();

                pnlSelect.Show();
                pnlChapter.Show();
                pnlSave.Show();
            }
        }

        void getImages()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "My Image Browser";
            openFileDialog1.ValidateNames = true;
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|"
                + "All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    try
                    {
                        Image image = Image.FromFile(file);
                        ImageConverter Converter = new ImageConverter();
                        var imageConvert = Converter.ConvertTo(image, typeof(byte[]));
                        listBox2.Items.Add(imageConvert);   
                        imageList1.Images.Add(image);
                        PictureBox pb = new PictureBox();
                        pb.Height = 300;
                        pb.Width = 240;
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.Image = Image.FromFile(file);
                        flowLayoutPanel1.Controls.Add(pb);
                        pb.Controls.Clear();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }


        void sendImg()
        {
            int v = 1;
            
            foreach (byte[] i in listBox2.Items)
            {
                //ImageConverter Converter = new ImageConverter();
                //var imageConvert = Converter.ConvertTo(i, typeof(byte[]));
                using (SqlConnection sc = new SqlConnection(cs))
                {
                    sc.Open();
                    SqlCommand cmd = new SqlCommand("Insert into image(id_chapter,img)  values (@id_chapter,@img)", sc);
                    
                    cmd.Parameters.AddWithValue("@img",i);
                    
                    //cmd.Parameters.AddWithValue("@id", v);
                    
                    cmd.Parameters.AddWithValue("@id_chapter", Convert.ToInt32(txtIdChapter.Text));
                    
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    sc.Close();
                }
                v++;
            }
        }

        void getManga()
        {
            SqlConnection sc = new SqlConnection(cs);
            sc.Open();
            SqlCommand com = new SqlCommand("select * from manga", sc);
            SqlDataReader dr = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            cb_manga.DisplayMember = "name_manga";
            cb_manga.ValueMember = "id_manga";
            cb_manga.DataSource = table;
            sc.Close();
            dr.Close();
            dr = null;
        }

        void addChapter()
        {
            using (SqlConnection sc = new SqlConnection(cs))
            {
                
                sc.Open();
                SqlCommand cmd = new SqlCommand("Insert into chapter values (@number,@title,@id_manga)",sc);

                cmd.Parameters.AddWithValue("@number", Convert.ToInt32(txtNumber.Text.ToString()));
                
                cmd.Parameters.AddWithValue("@title", txt_title.Text);
                
                cmd.Parameters.AddWithValue("@id_manga", cb_manga.SelectedValue);
            
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                sc.Close();
            }
        }
        private void UploadChapetrs_Load(object sender, EventArgs e)
        {
            listBox1.Hide();
            getManga();
            
        }

        private void btn_AddChapter_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_NbChapter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            addChapter();
            SqlConnection sc = new SqlConnection(cs);
            sc.Open();
            SqlCommand com = new SqlCommand(string.Format("select * from chapter where number ={0} and id_manga={1}", Convert.ToInt32(txtNumber.Text),Convert.ToInt32(cb_manga.SelectedValue.ToString())), sc);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtIdChapter.Text = dr["id_chapter"].ToString();
                
            }
            
            dr.Close();
            sc.Close();
            sendImg();
        }

        private void btn_images_Click(object sender, EventArgs e)
        {
            getImages();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
