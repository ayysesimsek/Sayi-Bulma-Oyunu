using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyşeSayıBulmaOyunu
{
    public partial class GirişBilgilendirmesi : Form
    {
        #region CONSTRUCTOR
        public GirişBilgilendirmesi()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENT

        #region Çıkış Yap Butonu
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz ? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
        #endregion

        #region Oyuna Başla Butonu
        private void btnStart_Click(object sender, EventArgs e)
        {
            SayıBulma go = new SayıBulma();
            this.Hide();
            go.Show();
        }
        #endregion

        #endregion
    }
}
