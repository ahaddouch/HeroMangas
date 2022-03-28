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

namespace MangaReader
{
    public partial class MangaItem : UserControl
    {
        

        public string Titel { get; set; }
        string t;
        public MangaItem()
        {
            InitializeComponent();
        }
        public MangaItem(string auteur ,string titel,byte[] pic)
        {
            InitializeComponent();
            lbTitle.Text = titel;
            lbAuteur.Text = auteur;
            MemoryStream ms = new MemoryStream(pic);
            pictur.Image = Image.FromStream(ms);
            Titel = titel;
            this.t = titel;

        }
        //public string ID2
        //{
        //    get { return textBox1.Text; }
        //}
        private void MangaItem_Click(object sender, EventArgs e)
        {
            details_manga f = new details_manga(t);
            f.Show();
            
            
            

        }

        private void MangaItem_Load(object sender, EventArgs e)
        {

        }
    }
}
