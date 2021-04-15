using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyşeSayıBulmaOyunu
{
    public partial class ScorePage : Form
    {
        #region Değişkenler
        private string name;
        private string surname;
        private string score;
        private static string scoreFile = @"../../scoreList.txt";
        #endregion

        #region CONSTRUCTOR
        public ScorePage(string scorePoint)
        {
            InitializeComponent();
            txtScore.Text = scorePoint;
        }
        #endregion

        #region EVENT
        #region ScorePage Load
        private void ScorePage_Load(object sender, EventArgs e)
        {
            txtScore.Enabled = false;
        }
        #endregion

        #region Kaydet Butonu
        private void btnSave_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            surname = txtSurname.Text;
            score = txtScore.Text;

            #region Boş Kontrolü
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname))
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz ... ");
            }
            #endregion

            else
            {
                string join = name + "\t" + surname + "\t" + score + Environment.NewLine;
                StreamWriter sw = File.AppendText(scoreFile);
                sw.Write(join);
                sw.Close();

                DialogResult result = MessageBox.Show(name + " " + surname + " skorunuz başarıyla kaydedilmiştir .. Oyunu tekrardan oynamak ister misiniz ?? ", "BİLDİRİ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    Application.Restart();
                }
            }
        }
        #endregion
        #endregion
    }
}
