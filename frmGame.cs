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

        private void baslatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBoard board = new frmBoard();
            board.MdiParent = this;
            board.WindowState = FormWindowState.Maximized;
            board.Show();
        }
    }
}
