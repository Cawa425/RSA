namespace protect_inf_LR1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_p = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_d = new System.Windows.Forms.TextBox();
            this.TextBox_e = new System.Windows.Forms.TextBox();
            this.TextBox_Text = new System.Windows.Forms.TextBox();
            this.DecodeText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.EncodeText = new System.Windows.Forms.TextBox();
            this.TextBox_q = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEncrypt.Location = new System.Drawing.Point(37, 343);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(306, 33);
            this.buttonEncrypt.TabIndex = 1;
            this.buttonEncrypt.Text = "Зашифровать и расшифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(21, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "p =";
            // 
            // TextBox_p
            // 
            this.TextBox_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextBox_p.Location = new System.Drawing.Point(58, 93);
            this.TextBox_p.Name = "TextBox_p";
            this.TextBox_p.Size = new System.Drawing.Size(104, 26);
            this.TextBox_p.TabIndex = 4;
            this.TextBox_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(21, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "q =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(37, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Простые числа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(182, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "d =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(182, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "e =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(182, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Секретный ключ";
            // 
            // TextBox_d
            // 
            this.TextBox_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextBox_d.Location = new System.Drawing.Point(219, 93);
            this.TextBox_d.Name = "TextBox_d";
            this.TextBox_d.Size = new System.Drawing.Size(94, 26);
            this.TextBox_d.TabIndex = 11;
            this.TextBox_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBox_e
            // 
            this.TextBox_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextBox_e.Location = new System.Drawing.Point(219, 125);
            this.TextBox_e.Name = "TextBox_e";
            this.TextBox_e.Size = new System.Drawing.Size(94, 26);
            this.TextBox_e.TabIndex = 12;
            this.TextBox_e.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBox_Text
            // 
            this.TextBox_Text.Location = new System.Drawing.Point(43, 191);
            this.TextBox_Text.Name = "TextBox_Text";
            this.TextBox_Text.Size = new System.Drawing.Size(300, 20);
            this.TextBox_Text.TabIndex = 13;
            // 
            // DecodeText
            // 
            this.DecodeText.Location = new System.Drawing.Point(41, 308);
            this.DecodeText.Name = "DecodeText";
            this.DecodeText.Size = new System.Drawing.Size(302, 20);
            this.DecodeText.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Сообщение";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Дешифрованное сообщение";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Зашифрованное сообщение";
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(41, 25);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(121, 23);
            this.Generate.TabIndex = 20;
            this.Generate.Text = "Random";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // EncodeText
            // 
            this.EncodeText.Location = new System.Drawing.Point(43, 252);
            this.EncodeText.Name = "EncodeText";
            this.EncodeText.Size = new System.Drawing.Size(300, 20);
            this.EncodeText.TabIndex = 21;
            // 
            // TextBox_q
            // 
            this.TextBox_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextBox_q.Location = new System.Drawing.Point(58, 125);
            this.TextBox_q.Name = "TextBox_q";
            this.TextBox_q.Size = new System.Drawing.Size(104, 26);
            this.TextBox_q.TabIndex = 6;
            this.TextBox_q.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 398);
            this.Controls.Add(this.EncodeText);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DecodeText);
            this.Controls.Add(this.TextBox_Text);
            this.Controls.Add(this.TextBox_e);
            this.Controls.Add(this.TextBox_d);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_q);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_p);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEncrypt);
            this.Name = "Form1";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button Generate;

        private System.Windows.Forms.TextBox EncodeText;

        private System.Windows.Forms.TextBox TextBox_d;

        private System.Windows.Forms.TextBox TextBox_Text;

        private System.Windows.Forms.TextBox TextBox_e;

        private System.Windows.Forms.TextBox TextBox_q;

        private System.Windows.Forms.TextBox DecodeText;

        #endregion

        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_p;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button generatePrimes;
    }
}

