namespace App
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
            this.Resumebutton1 = new System.Windows.Forms.Button();
            this.PasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.LoginTextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Enterbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Resumebutton1
            // 
            this.Resumebutton1.Location = new System.Drawing.Point(149, 206);
            this.Resumebutton1.Name = "Resumebutton1";
            this.Resumebutton1.Size = new System.Drawing.Size(166, 23);
            this.Resumebutton1.TabIndex = 11;
            this.Resumebutton1.Text = "Продолжить без входа";
            this.Resumebutton1.UseVisualStyleBackColor = true;
            this.Resumebutton1.Click += new System.EventHandler(this.Resumebutton1_Click);
            // 
            // PasswordTextBox2
            // 
            this.PasswordTextBox2.Location = new System.Drawing.Point(127, 101);
            this.PasswordTextBox2.Name = "PasswordTextBox2";
            this.PasswordTextBox2.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox2.TabIndex = 10;
            // 
            // LoginTextBox1
            // 
            this.LoginTextBox1.Location = new System.Drawing.Point(127, 44);
            this.LoginTextBox1.Name = "LoginTextBox1";
            this.LoginTextBox1.Size = new System.Drawing.Size(100, 20);
            this.LoginTextBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Логин";
            // 
            // Enterbutton1
            // 
            this.Enterbutton1.Location = new System.Drawing.Point(178, 163);
            this.Enterbutton1.Name = "Enterbutton1";
            this.Enterbutton1.Size = new System.Drawing.Size(75, 23);
            this.Enterbutton1.TabIndex = 6;
            this.Enterbutton1.Text = "Войти";
            this.Enterbutton1.UseVisualStyleBackColor = true;
            this.Enterbutton1.Click += new System.EventHandler(this.Enterbutton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 286);
            this.Controls.Add(this.Resumebutton1);
            this.Controls.Add(this.PasswordTextBox2);
            this.Controls.Add(this.LoginTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enterbutton1);
            this.Name = "Form1";
            this.Text = "Войти";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Resumebutton1;
        private System.Windows.Forms.TextBox PasswordTextBox2;
        private System.Windows.Forms.TextBox LoginTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Enterbutton1;
    }
}

