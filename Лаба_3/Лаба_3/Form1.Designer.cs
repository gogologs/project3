namespace Лаба_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itog = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.eng = new System.Windows.Forms.CheckBox();
            this.rus = new System.Windows.Forms.CheckBox();
            this.decrypt = new System.Windows.Forms.Button();
            this.crypt = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(172, 688);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Нет зашифрованного текста";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(21, 708);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1130, 109);
            this.label6.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(172, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Не введен текст или ключ!";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(21, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Введите ваш текст:";
            // 
            // itog
            // 
            this.itog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itog.ForeColor = System.Drawing.Color.Lime;
            this.itog.Location = new System.Drawing.Point(21, 531);
            this.itog.Name = "itog";
            this.itog.Size = new System.Drawing.Size(1130, 109);
            this.itog.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(21, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Вводите только на выбранном языке!";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(18, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ошибка ввода";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(18, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ключ:";
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.Lime;
            this.title.Location = new System.Drawing.Point(21, 15);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1130, 26);
            this.title.TabIndex = 23;
            this.title.Text = "Приветствуем! Программа посвящена шифру Цезаря. Выберите язык, введите текст, цел" +
    "очисленный ключ и выберите нужную опцию.\r\n";
            // 
            // eng
            // 
            this.eng.AutoSize = true;
            this.eng.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eng.ForeColor = System.Drawing.Color.Lime;
            this.eng.Location = new System.Drawing.Point(123, 70);
            this.eng.Name = "eng";
            this.eng.Size = new System.Drawing.Size(120, 21);
            this.eng.TabIndex = 22;
            this.eng.Text = "английский";
            this.eng.UseVisualStyleBackColor = true;
            this.eng.CheckedChanged += new System.EventHandler(this.eng_CheckedChanged);
            // 
            // rus
            // 
            this.rus.AutoSize = true;
            this.rus.Checked = true;
            this.rus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rus.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rus.ForeColor = System.Drawing.Color.Lime;
            this.rus.Location = new System.Drawing.Point(24, 70);
            this.rus.Name = "rus";
            this.rus.Size = new System.Drawing.Size(93, 21);
            this.rus.TabIndex = 21;
            this.rus.Text = "русский";
            this.rus.UseVisualStyleBackColor = true;
            this.rus.CheckedChanged += new System.EventHandler(this.rus_CheckedChanged);
            // 
            // decrypt
            // 
            this.decrypt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrypt.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decrypt.ForeColor = System.Drawing.Color.Lime;
            this.decrypt.Location = new System.Drawing.Point(21, 666);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(145, 39);
            this.decrypt.TabIndex = 20;
            this.decrypt.Text = "Расшифровать";
            this.decrypt.UseVisualStyleBackColor = false;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // crypt
            // 
            this.crypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crypt.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.crypt.ForeColor = System.Drawing.Color.Lime;
            this.crypt.Location = new System.Drawing.Point(21, 489);
            this.crypt.Name = "crypt";
            this.crypt.Size = new System.Drawing.Size(145, 39);
            this.crypt.TabIndex = 19;
            this.crypt.Text = "Зашифровать";
            this.crypt.UseVisualStyleBackColor = true;
            this.crypt.Click += new System.EventHandler(this.crypt_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.ForeColor = System.Drawing.Color.Lime;
            this.textBox3.Location = new System.Drawing.Point(21, 418);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1130, 22);
            this.textBox3.TabIndex = 18;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(24, 121);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1127, 233);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1168, 832);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.eng);
            this.Controls.Add(this.rus);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.crypt);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label itog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.CheckBox eng;
        private System.Windows.Forms.CheckBox rus;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Button crypt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

