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
    public partial class SayıBulma : Form
    {
        #region Değişkenler
        TextBox[] boxing;
        Random rnd = new Random();
        int digit, right;
        int puan = 0;
        int count = 10;
        private bool isHave = true;
        private List<int> number = new List<int>();
        #endregion

        #region CONSTRUCTOR
        public SayıBulma()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENT
        #region Load
        private void SayıBulma_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Sayı Üret Butonu
        private void btnGenerateNumber_Click(object sender, EventArgs e)
        {
            digit = Convert.ToInt32(nmNumberOfDigit.Value); // Basamak Sayısı
            right = Convert.ToInt32(nmNumberOfRight.Value); // Hak Sayısı
            timer1.Start();
            boxing = new TextBox[digit];

            GetNumber(digit); // Rastgele sayı üretiliyor .. 

            flowLayoutPanel1.Controls.Clear();
            #region Kutucuklar oluşuyor .. 
            for (int i = 0; i < digit; i++) // Kutucuklar oluşuyor .. 
            {
                TextBox txt = new TextBox();
                txt.Name = number[i].ToString();
                txt.Text = "";
                txt.Width = 30;
                txt.BackColor = Color.White;
                txt.TextChanged += new EventHandler(this.TextBoxControl_TextChanged);
                txt.KeyPress += TextBox_KeyPress; // Sadece rakam girebilme kontrolü
                boxing[i] = txt;
                flowLayoutPanel1.Controls.Add(boxing[i]);
            }
            #endregion

        }
        #endregion

        #region TextBox_KeyPress text ifade girememe kontrolü yapılıyor .. 
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Rakam giriniz kontrolü
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Lütfen rakam giriniz !!! ");
            }
            #endregion

            right--;

            #region Sayı girilirken bir önceki yanlış tahmin siliniyor .. 
            for (int i = 0; i < boxing.Length; i++)
            {
                if (boxing[i].BackColor == Color.Red || boxing[i].BackColor == Color.White)
                {
                    boxing[i].BackColor = Color.White;
                    boxing[i].Text = "";
                    boxing[i].ForeColor = Color.Black;
                }
            }
            #endregion
        }

        #endregion

        #region TextBoxControl txt renklendirmesi sonuç kısmı .. 
        private void TextBoxControl_TextChanged(object sender, EventArgs e)
        {
            count = 10;
            TextBox txt = (TextBox)sender;

            #region Textboxa girilen değere göre arkaplanın blue özelliği kontrolü yapılmaktadır .. 
            if (txt.Text == txt.Name)
            {
                txt.BackColor = Color.Blue;
                txt.ForeColor = Color.White;
                txt.Enabled = false;
                puan += 10;
            }
            #endregion

            #region TextBoxa girilen değer üretilen değerde geçiyorsa arka planın kırmızı yapılması ayarlanıyor .. 
            else
            {
                puan -= 1;
                for (int i = 0; i < boxing.Length; i++)
                {
                    if (boxing[i].Name == txt.Text && boxing[i].BackColor != Color.Blue)
                    {
                        txt.BackColor = Color.Red;
                        txt.ForeColor = Color.White;
                    }
                }
            }
            #endregion

            #region Üretilen textboxlarda boş textbox hala varsa isHave = false olacak-oyun bitiyor kontrolü oluşturuluyor. 
            for (int i = 0; i < boxing.Length; i++)
            {
                if (boxing[i].Enabled == true)
                {
                    isHave = false;
                }
            }
            #endregion

            #region Hak bitmiş ise ve isHave = false ise .. 
            if (right <= 0 && isHave == false)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show("Hakkınız kalmadı .. Tekrar oynamak ister misiniz ? ", "***", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
            #endregion

            #region isHave = true ise oyun tamamlanmıştır .. 
            if (isHave == true)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler oyunu başarıyla tamamladınız .. Skor bilgilerinizi girerek kaydediniz .. ");
                CalculatePoint();
            }
            #endregion

            isHave = true;
        }
        #endregion

        #region TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            lblRemainigRight.Text = right.ToString();
            lblRemainingTime.Text = count.ToString();

            if (right >= 1)
            {
                if (count <= 0)
                {
                    right--;
                    count = 5;
                }
                else
                {
                    count--;
                }
            }
        }

        #endregion
        #endregion
        
        #region METHOD

        #region Skor kayıt ekranı açılıyor .. 
        private void CalculatePoint()
        {
            ScorePage scoreGo = new ScorePage(puan.ToString());
            scoreGo.Show();
        }
        #endregion

        #region Tekrarlı / Tekrarsız seçimine göre List<> e sayı üretilmesi yapılıyor .. 
        private List<int> GetNumber(int digit)
        {
            List<int> numferFor = new List<int>();
            #region Tekrarlı radiobutton seçilmiş ise .. 
            if (rbRepetitive.Checked)
            {
                for (int i = 0; i < digit; i++)
                {
                    int sayi = rnd.Next(10);
                    if (number.IndexOf(sayi) != -1)
                    {
                        i--;
                        continue;
                    }
                    else
                    {
                        if (number.Count == 0 && sayi == 0)
                        {
                            i--;
                            continue;
                        }
                        else
                        {
                            number.Add(sayi);
                        }
                    }

                }
            }
            #endregion

            #region Tekrarsız radiobutton seçilmiş ise ..
            if (rbUnrepeated.Checked)
            {
                for (int i = 0; i < digit; i++)
                {
                    int sayi = rnd.Next(10);
                    if (number.Count == 0 && sayi == 0)
                    {
                        i--;
                        continue;
                    }
                    else
                    {
                        number.Add(sayi);
                    }
                }
            }
            #endregion

            numferFor = number;
            return numferFor;
        }
        #endregion

        #endregion
    }
}
