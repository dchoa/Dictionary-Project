using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class frmDictionary : Form
    {
        public frmDictionary()
        {
            InitializeComponent();
        }

        private void btFavourite_Click(object sender, EventArgs e)
        {
            frmFavourite fav = new frmFavourite();
            fav.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNewword add = new frmNewword();
            add.Show();
        }

        private void favouriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFavourite fav = new frmFavourite();
            fav.Show();
        }

        private void newWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewword add = new frmNewword();
            add.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gUIEVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gUIEVToolStripMenuItem.Text == "GUI E_V")
            {
                dictionaryToolStripMenuItem.Text = "Từ Điển";
                recentToolStripMenuItem.Text = "Từ Gần Đây";
                favouriteToolStripMenuItem.Text = "Từ Yêu Thích";
                quitToolStripMenuItem.Text = "Thoát";
                toolsToolStripMenuItem.Text = "Công Cụ";
                newWordToolStripMenuItem.Text = "Thêm Từ Mới";
                onlineSearchToolStripMenuItem.Text = "Tra Từ Online";
                pronounToolStripMenuItem.Text = "Phát Âm";
                helpToolStripMenuItem.Text = "Trợ Giúp";
                aboutToolStripMenuItem.Text = "Thông Tin Từ Điển";
                gUIEVToolStripMenuItem.Text = "GUI V_E";
                btSearch.Text = "Tra";
               
            }
            else
            {
                dictionaryToolStripMenuItem.Text = "Dictionary";
                recentToolStripMenuItem.Text = "Recent";
                favouriteToolStripMenuItem.Text = "Favourite";
                quitToolStripMenuItem.Text = "Quit";
                toolsToolStripMenuItem.Text = "Tools";
                newWordToolStripMenuItem.Text = "New Word";
                onlineSearchToolStripMenuItem.Text = "Online Search";
                pronounToolStripMenuItem.Text = "Pronoun";
                helpToolStripMenuItem.Text = "Help";
                aboutToolStripMenuItem.Text = "About";
                gUIEVToolStripMenuItem.Text = "GUI E_V";
                btSearch.Text = "Search";
                
            }
        }

        private void btIrregularVerbs_Click(object sender, EventArgs e)
        {
            frmIrregularVerbs irr = new frmIrregularVerbs();
            irr.Show();
        }

        private void irregularVerbsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIrregularVerbs irr = new frmIrregularVerbs();
            irr.Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            tabPage2.Focus();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frmIdioms idiom = new frmIdioms();
            idiom.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pbStarDark.Visible = true;
            pbStarLight.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pbStarLight.Visible = true;
            pbStarDark.Visible = false;
        }
    }
}
