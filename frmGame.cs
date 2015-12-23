using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Star_Path_Finding_Implementation
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }
        public static frmBoard.Koordinat Baslangic;
        public static frmBoard.Koordinat Bitis;
        public static int boyut;
        private void baslatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void parametreAyarlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParametre parametre = new frmParametre();
            parametre.MdiParent = this;
            parametre.WindowState = FormWindowState.Maximized;
            parametre.Show();
        }

        public void oyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBoard board = new frmBoard();
            board.MdiParent = this;
            board.WindowState = FormWindowState.Maximized;
            board.Show();
        }
    }
}
