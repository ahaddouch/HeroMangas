using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangaReader
{
    public partial class chapter : UserControl
    {
        public chapter()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public chapter(int id, string number, string titel)
        {
            InitializeComponent();
            lbNumber.Text = number;
            lbTitel.Text = titel;
            
            
            this.id = id;
            

        }

        private void chapter_Load(object sender, EventArgs e)
        {

        }

        private void chapter_Click(object sender, EventArgs e)
        {
            ReadManga f = new ReadManga(id);
            f.Show();

        }
    }
}
