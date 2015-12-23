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
    public partial class frmParametre : Form
    {
        public frmParametre()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frmBoard.Koordinat baslangic = new frmBoard.Koordinat();
            frmBoard.Koordinat bitis = new frmBoard.Koordinat();
            baslangic.X = Convert.ToInt32(txtBaslangicX.Text);
            baslangic.Y = Convert.ToInt32(txtBaslangicY.Text);
            bitis.X = Convert.ToInt32(txtBitisX.Text);
            bitis.Y = Convert.ToInt32(txtBitisY.Text);
            frmGame.Baslangic = baslangic;
            frmGame.Bitis = bitis;
            frmGame.boyut = Convert.ToInt32(txtBoyut.Text);
            MessageBox.Show("Kaydetme başarılı!", this.Text);
            
            this.Close();
        }
    }
}
