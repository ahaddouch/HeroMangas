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
    public partial class UploadManga : Form
    {
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
        bool isAdd, isMod, isDel = false;
        private DataSet dtSet;
        public UploadManga()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            isAdd = true;
            isMod = false;
            isDel = false;
            DesEnb();
        }

        private void DesEnb()
        {
            if (isAdd)
            {

                txtName.Text = string.Empty;
                txtDesc.Text = string.Empty;
                pictur.Image = null;
                pnlPic.Show();
                pnlSave.Show();
                pnlInfo.Show();
                pnlSelect.Hide();
                pnlcont.Enabled = true;  
                
            }

            else if (isMod)
            {
                
                pnlPic.Show();
                pnlSave.Show();
                pnlInfo.Show();
                pnlSelect.Show();
                pnlcont.Enabled = true;
                getManga();


            }

            else if (isDel)
            {
                pnlPic.Hide();
                pnlSave.Show();
                pnlInfo.Show();
                pnlSelect.Show();
                pnlcont.Enabled = false;
                getManga();
            }
            else
            {
                pnlInfo.Hide();
                pnlSelect.Hide();
                pnlPic.Hide();
                pnlSave.Hide();
                pnlcont.Enabled = false;
            }
        }
        void getManga()
        {
            SqlConnection sc = getsc();
            sc.Open();
            SqlCommand com = new SqlCommand("select * from manga", sc);
            SqlDataReader dr = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            lstmanga.DisplayMember = "name_manga";
            lstmanga.ValueMember = "id_manga";
            lstmanga.DataSource = table;
            sc.Close();
            dr.Close();
            dr = null;
            
        }
        void getMAngaDetails()
        {
            if (lstmanga.SelectedIndex != -1)
            {
                SqlConnection sc1 = getsc();
                sc1.Open();
                SqlCommand com3 = new SqlCommand(string.Format("select * from manga where id_manga ={0}", lstmanga.SelectedValue), sc1);
                SqlDataReader dr1 = com3.ExecuteReader();
                while (dr1.Read())
                {
                    txtName.Text = dr1["name_manga"].ToString();
                    txtDesc.Text = dr1["descreption"].ToString();
                    txtAuthor.Text = dr1["auteur"].ToString();
                    lstAge.Text = dr1["ageG"].ToString();
                    lstType.Text = dr1["type"].ToString();
                    lstYear.Text = dr1["dateP"].ToString();
                    byte[] pic = ((byte[])dr1["pictur"]);
                    
                    var ms = new MemoryStream(pic);
                    pictur.Image=Image.FromStream(ms);

                }
                dr1.Close();
                sc1.Close();
                SqlConnection sc2 = getsc();
                sc2.Open();
                SqlCommand com4 = new SqlCommand(string.Format("select * from genre where id_manga ={0}", lstmanga.SelectedValue), sc2);
                SqlDataReader dr2 = com4.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(dr2);
                listBox1.DisplayMember = "name";
                listBox1.ValueMember = "id";
                listBox1.DataSource = table;
                sc2.Close();
                dr2.Close();
                dr2 = null;

                for (int x = 0; x < listBox1.Items.Count - 1; x++)
                {
                    for (int i = 0; i < clbGenre.SelectedItems.Count - 1; i++)
                    {
                        if (listBox1.Items[x].ToString() == clbGenre.Items[i].ToString())
                            clbGenre.SelectedItem = clbGenre.Items[i];
                    }
                }




            }

        }

        #region Button Upload
        private void btnPictur_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "open image";
            ofd.Filter = "Image Files(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
               pictur.Image = Image.FromFile(ofd.FileName);
               Image image = Image.FromFile(ofd.FileName);
               this.pictur.Image = image;
            }
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image pict = pictur.Image;
            ImageConverter Converter = new ImageConverter();
            var imageConvert = Converter.ConvertTo(pict, typeof(byte[]));

            if (isAdd)
            {

                if (txtName.Text == "")
                    MessageBox.Show("Manga Name is empty !!!");
                else if (pictur.Image == null)
                {
                    MessageBox.Show("Load pictur !!!");

                }

                else
                {
                    using (SqlConnection cn = getsc())
                    {

                        cn.Open();
                        SqlCommand cmd = new SqlCommand("insert into manga(name_manga,descreption,pictur,dateP,auteur,type,ageG) values(@name_manga,@descreption,@pictur,@dateP,@auteur,@type,@ageG)", cn);
                        cmd.Parameters.AddWithValue("@name_manga", txtName.Text);
                        cmd.Parameters.AddWithValue("@descreption", txtDesc.Text);
                        cmd.Parameters.AddWithValue("@pictur", imageConvert);
                        cmd.Parameters.AddWithValue("@dateP", Convert.ToInt32(lstYear.SelectedItem.ToString()));
                        cmd.Parameters.AddWithValue("@auteur", txtAuthor.Text);
                        cmd.Parameters.AddWithValue("@type", lstType.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@ageG", lstAge.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                        getManga();
                        lstmanga.SelectedIndex = lstmanga.Items.Count -1;
                        

                        //for (int i = 1; i < clbGenre.SelectedItems.Count; i++)
                        //{
                        //    string t = clbGenre.SelectedItems[i].ToString();
                        //    SqlCommand cmd1 = new SqlCommand("insert into genre(id_manga,name) values(@id_manga,@name)", cn);
                        //    cmd1.Parameters.AddWithValue("@id_manga", lstmanga.SelectedValue);
                        //    cmd1.Parameters.AddWithValue("@name", t);
                        //    cmd1.ExecuteNonQuery();
                        //}
                        





                        cn.Close();
                        MessageBox.Show("Manga add Successfully");
                    }
                    SqlConnection sc = getsc();
                    sc.Open();
                    foreach (string i in clbGenre.SelectedItems)
                    {
                        SqlCommand cmd1 = new SqlCommand("insert into genre(id_manga,name) values(@id_manga,@name)", sc);
                        cmd1.Parameters.AddWithValue("@id_manga", lstmanga.SelectedValue);
                        cmd1.Parameters.AddWithValue("@name", i);
                        cmd1.ExecuteNonQuery();
                    }
                    sc.Close();
                    isAdd = false;
                    pictur.Image = null;
                    DesEnb();
                }
                
            } 
            else if(isMod)
            {
                using (SqlConnection cn = getsc())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE MANGA SET name_manga='@name_manga',descreption='@descreption',pictur='@pictur',dateP='@dateP',auteur='@auteur',type='@type',ageG='@ageG' WHERE id_manga='@id_manga'", cn);
                    cmd.Parameters.AddWithValue("@id_manga", lstmanga.SelectedValue);
                    cmd.Parameters.AddWithValue("@name_manga", txtName.Text);
                    cmd.Parameters.AddWithValue("@descreption", txtDesc.Text);
                    cmd.Parameters.AddWithValue("@pictur", imageConvert);
                    cmd.Parameters.AddWithValue("@dateP", Convert.ToInt32(lstYear.SelectedItem.ToString()));
                    cmd.Parameters.AddWithValue("@auteur", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@type", lstType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ageG", lstYear.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();


                    SqlConnection connection = getsc();
                    string sqlStatement = "DELETE FROM genre WHERE id_maga = @id_maga";
                    try
                    {
                        connection.Open();
                        SqlCommand cmd2 = new SqlCommand(sqlStatement, connection);
                        cmd2.Parameters.AddWithValue("@id_maga", lstmanga.SelectedValue);
                        cmd2.CommandType = CommandType.Text;
                        cmd2.ExecuteNonQuery();

                    }
                    finally
                    {
                        connection.Close();
                    }

                    for (int i = 0; i < clbGenre.Items.Count; i++)
                    {
                        foreach (string v in clbGenre.SelectedItems)
                        {
                            SqlCommand cmd1 = new SqlCommand("insert into genre(id_manga,name) values(@id_manga,@name)", cn);
                            cmd1.Parameters.AddWithValue("@id_manga", lstmanga.SelectedValue);
                            cmd1.Parameters.AddWithValue("@name", v);
                            cmd1.ExecuteNonQuery();
                        }

                    }
                    cn.Close();
                    MessageBox.Show("Manga modify Successfully");
                    isMod = false;
                    DesEnb();
                }

            }
            else if (isDel)
            {

                if (MessageBox.Show("Are you ok about deleting this manga ?", "DELETE MANGA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection sc = getsc();
                    sc.Open();
                    SqlCommand com = new SqlCommand("delete from manga where id_manga =@id_manga" , sc);
                    com.Parameters.AddWithValue("@id_manga", Convert.ToInt32(lstmanga.SelectedValue.ToString()) );
                    com.ExecuteNonQuery();
                    isDel = false;
                    DesEnb();
                }   
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            isMod = true;
            isDel = false;
            isAdd = false;
            DesEnb();
        }

        private void lstmanga_SelectedIndexChanged(object sender, EventArgs e)
        {
            getMAngaDetails();
        }

        

        private void btnDel_Click(object sender, EventArgs e)
        {
            isDel = true;
            isAdd = false;
            isMod = false;
            DesEnb();
        }

        private void checkedListBox1_MouseHover(object sender, EventArgs e)
        {
            clbGenre.Height = clbGenre.MaximumSize.Height;
        }

        private void clbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_MouseLeave(object sender, EventArgs e)
        {
            clbGenre.Height = clbGenre.MinimumSize.Height;
        }

        //private void CreateGenreTable()
        //{
        //    DataTable genrTable = new DataTable("genre");
        //    DataColumn dtColumn;
        //    DataRow myDataRow;

        //    dtColumn = new DataColumn();
        //    dtColumn.DataType = typeof(Int32);
        //    dtColumn.ColumnName = "id";
        //    dtColumn.Caption = "Cust ID";
        //    dtColumn.ReadOnly = false;
        //    dtColumn.Unique = true;
            
        //    genrTable.Columns.Add(dtColumn);

            
        //    dtColumn = new DataColumn();
        //    dtColumn.DataType = typeof(String);
        //    dtColumn.ColumnName = "name";
        //    dtColumn.Caption = "Cust name";
        //    dtColumn.AutoIncrement = false;
        //    dtColumn.ReadOnly = false;
        //    dtColumn.Unique = false;
            
        //    genrTable.Columns.Add(dtColumn);
            
        //    DataColumn[] PrimaryKeyColumns = new DataColumn[1];
        //    PrimaryKeyColumns[0] = genrTable.Columns["id"];
        //    genrTable.PrimaryKey = PrimaryKeyColumns;
            

        //    myDataRow = genrTable.NewRow();
        //    myDataRow["id"] = 1;         
        //    myDataRow["name"] = "Drama";
        //    genrTable.Rows.Add(myDataRow);
        //    myDataRow = genrTable.NewRow();
        //    myDataRow["id"] = 2;
        //    myDataRow["name"] = "Action";
            
        //    genrTable.Rows.Add(myDataRow);
        //    myDataRow = genrTable.NewRow();
        //    myDataRow["id"] = 3;
        //    myDataRow["name"] = "Martial Art";

            
        //    genrTable.Rows.Add(myDataRow);


            
            
        //}

        

        
        private void UploadManga_Load(object sender, EventArgs e)
        {
            for (int year = 1995; year < DateTime.UtcNow.Year+1; ++year)
            {
                lstYear.Items.Add(year);
            }
            string[] age = new string[] { "7+", "13+", "18+" };
            lstAge.Items.AddRange(age);
            string[] type = new string[] { "Manga(JP)", "Manhwa(KR)", "Manhua(CN)" };
            lstType.Items.AddRange(type);
            string[] genre = new string[] { "martial art ", "action", "advantur","drama" };
            clbGenre.Items.AddRange(genre);
            lstYear.SelectedItem = 2022;
            //CreateGenreTable();

            getMAngaDetails();
            DesEnb();
        }

        
    }

}
