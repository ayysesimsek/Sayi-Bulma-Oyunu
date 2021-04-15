namespace AyşeSayıBulmaOyunu
{
    partial class SayıBulma
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerateNumber = new System.Windows.Forms.Button();
            this.nmNumberOfRight = new System.Windows.Forms.NumericUpDown();
            this.nmNumberOfDigit = new System.Windows.Forms.NumericUpDown();
            this.rbUnrepeated = new System.Windows.Forms.RadioButton();
            this.rbRepetitive = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRemainigRight = new System.Windows.Forms.Label();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNumberOfRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmNumberOfDigit)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerateNumber);
            this.groupBox1.Controls.Add(this.nmNumberOfRight);
            this.groupBox1.Controls.Add(this.nmNumberOfDigit);
            this.groupBox1.Controls.Add(this.rbUnrepeated);
            this.groupBox1.Controls.Add(this.rbRepetitive);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox1.Location = new System.Drawing.Point(77, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 234);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİRİŞ";
            // 
            // btnGenerateNumber
            // 
            this.btnGenerateNumber.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGenerateNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenerateNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerateNumber.Location = new System.Drawing.Point(62, 162);
            this.btnGenerateNumber.Name = "btnGenerateNumber";
            this.btnGenerateNumber.Size = new System.Drawing.Size(142, 53);
            this.btnGenerateNumber.TabIndex = 11;
            this.btnGenerateNumber.Text = "SAYI ÜRET";
            this.btnGenerateNumber.UseVisualStyleBackColor = false;
            this.btnGenerateNumber.Click += new System.EventHandler(this.btnGenerateNumber_Click);
            // 
            // nmNumberOfRight
            // 
            this.nmNumberOfRight.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmNumberOfRight.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nmNumberOfRight.Location = new System.Drawing.Point(197, 63);
            this.nmNumberOfRight.Name = "nmNumberOfRight";
            this.nmNumberOfRight.Size = new System.Drawing.Size(59, 22);
            this.nmNumberOfRight.TabIndex = 9;
            // 
            // nmNumberOfDigit
            // 
            this.nmNumberOfDigit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmNumberOfDigit.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nmNumberOfDigit.Location = new System.Drawing.Point(197, 31);
            this.nmNumberOfDigit.Name = "nmNumberOfDigit";
            this.nmNumberOfDigit.Size = new System.Drawing.Size(59, 22);
            this.nmNumberOfDigit.TabIndex = 10;
            // 
            // rbUnrepeated
            // 
            this.rbUnrepeated.AutoSize = true;
            this.rbUnrepeated.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbUnrepeated.Location = new System.Drawing.Point(131, 112);
            this.rbUnrepeated.Name = "rbUnrepeated";
            this.rbUnrepeated.Size = new System.Drawing.Size(83, 20);
            this.rbUnrepeated.TabIndex = 7;
            this.rbUnrepeated.TabStop = true;
            this.rbUnrepeated.Text = "Tekrarsız";
            this.rbUnrepeated.UseVisualStyleBackColor = true;
            // 
            // rbRepetitive
            // 
            this.rbRepetitive.AutoSize = true;
            this.rbRepetitive.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbRepetitive.Location = new System.Drawing.Point(52, 112);
            this.rbRepetitive.Name = "rbRepetitive";
            this.rbRepetitive.Size = new System.Drawing.Size(74, 20);
            this.rbRepetitive.TabIndex = 8;
            this.rbRepetitive.TabStop = true;
            this.rbRepetitive.Text = "Tekrarlı";
            this.rbRepetitive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hak Sayınızı Giriniz : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Basamak Sayısı Giriniz  : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblRemainigRight);
            this.groupBox2.Controls.Add(this.lblRemainingTime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 232);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TAHMİN";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(358, 46);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label7.Location = new System.Drawing.Point(67, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tahmin Edeceğiniz Sayıyı Giriniz ";
            // 
            // lblRemainigRight
            // 
            this.lblRemainigRight.AutoSize = true;
            this.lblRemainigRight.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemainigRight.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblRemainigRight.Location = new System.Drawing.Point(141, 182);
            this.lblRemainigRight.Name = "lblRemainigRight";
            this.lblRemainigRight.Size = new System.Drawing.Size(36, 16);
            this.lblRemainigRight.TabIndex = 11;
            this.lblRemainigRight.Text = "____";
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemainingTime.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblRemainingTime.Location = new System.Drawing.Point(141, 152);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(36, 16);
            this.lblRemainingTime.TabIndex = 12;
            this.lblRemainingTime.Text = "____";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(24, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kalan Hakınız : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(24, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kalan Süreniz  : ";
            // 
            // SayıBulma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(422, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SayıBulma";
            this.Text = "Sayı Bulma";
            this.Load += new System.EventHandler(this.SayıBulma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNumberOfRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmNumberOfDigit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerateNumber;
        private System.Windows.Forms.NumericUpDown nmNumberOfRight;
        private System.Windows.Forms.NumericUpDown nmNumberOfDigit;
        private System.Windows.Forms.RadioButton rbUnrepeated;
        private System.Windows.Forms.RadioButton rbRepetitive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRemainigRight;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

