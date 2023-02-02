namespace App
{
    partial class AddForm3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CategoryComboBox1 = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new App.DatabaseDataSet();
            this.ImageLabel6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DescriptionRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.OnStockTextBox2 = new System.Windows.Forms.TextBox();
            this.DiscontAmountTextBox1 = new System.Windows.Forms.TextBox();
            this.ExitButton2 = new System.Windows.Forms.Button();
            this.SaveButton1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.categoryTableAdapter = new App.DatabaseDataSetTableAdapters.CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryComboBox1
            // 
            this.CategoryComboBox1.DataSource = this.categoryBindingSource;
            this.CategoryComboBox1.DisplayMember = "CName";
            this.CategoryComboBox1.FormattingEnabled = true;
            this.CategoryComboBox1.Location = new System.Drawing.Point(159, 19);
            this.CategoryComboBox1.Name = "CategoryComboBox1";
            this.CategoryComboBox1.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox1.TabIndex = 39;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ImageLabel6
            // 
            this.ImageLabel6.AutoSize = true;
            this.ImageLabel6.Location = new System.Drawing.Point(130, 287);
            this.ImageLabel6.Name = "ImageLabel6";
            this.ImageLabel6.Size = new System.Drawing.Size(0, 13);
            this.ImageLabel6.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Добавить изображение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DescriptionRichTextBox1
            // 
            this.DescriptionRichTextBox1.Location = new System.Drawing.Point(118, 160);
            this.DescriptionRichTextBox1.Name = "DescriptionRichTextBox1";
            this.DescriptionRichTextBox1.Size = new System.Drawing.Size(289, 118);
            this.DescriptionRichTextBox1.TabIndex = 36;
            this.DescriptionRichTextBox1.Text = "";
            // 
            // OnStockTextBox2
            // 
            this.OnStockTextBox2.Location = new System.Drawing.Point(159, 105);
            this.OnStockTextBox2.Name = "OnStockTextBox2";
            this.OnStockTextBox2.Size = new System.Drawing.Size(100, 20);
            this.OnStockTextBox2.TabIndex = 35;
            // 
            // DiscontAmountTextBox1
            // 
            this.DiscontAmountTextBox1.Location = new System.Drawing.Point(158, 61);
            this.DiscontAmountTextBox1.Name = "DiscontAmountTextBox1";
            this.DiscontAmountTextBox1.Size = new System.Drawing.Size(100, 20);
            this.DiscontAmountTextBox1.TabIndex = 34;
            // 
            // ExitButton2
            // 
            this.ExitButton2.Location = new System.Drawing.Point(332, 454);
            this.ExitButton2.Name = "ExitButton2";
            this.ExitButton2.Size = new System.Drawing.Size(75, 23);
            this.ExitButton2.TabIndex = 33;
            this.ExitButton2.Text = "Отмена";
            this.ExitButton2.UseVisualStyleBackColor = true;
            this.ExitButton2.Click += new System.EventHandler(this.ExitButton2_Click);
            // 
            // SaveButton1
            // 
            this.SaveButton1.Location = new System.Drawing.Point(241, 454);
            this.SaveButton1.Name = "SaveButton1";
            this.SaveButton1.Size = new System.Drawing.Size(75, 23);
            this.SaveButton1.TabIndex = 32;
            this.SaveButton1.Text = "Сохранить";
            this.SaveButton1.UseVisualStyleBackColor = true;
            this.SaveButton1.Click += new System.EventHandler(this.AddButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Изображение:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Описание:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Количество на складе:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Действующая скидка:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Категория:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // AddForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 497);
            this.Controls.Add(this.CategoryComboBox1);
            this.Controls.Add(this.ImageLabel6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DescriptionRichTextBox1);
            this.Controls.Add(this.OnStockTextBox2);
            this.Controls.Add(this.DiscontAmountTextBox1);
            this.Controls.Add(this.ExitButton2);
            this.Controls.Add(this.SaveButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm3";
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.AddForm3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryComboBox1;
        private System.Windows.Forms.Label ImageLabel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox DescriptionRichTextBox1;
        private System.Windows.Forms.TextBox OnStockTextBox2;
        private System.Windows.Forms.TextBox DiscontAmountTextBox1;
        private System.Windows.Forms.Button ExitButton2;
        private System.Windows.Forms.Button SaveButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DatabaseDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
    }
}