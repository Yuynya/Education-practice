namespace App
{
    partial class AddOrderForm5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CompositioncomboBox1 = new System.Windows.Forms.ComboBox();
            this.OrderPickUpPointcomboBox2 = new System.Windows.Forms.ComboBox();
            this.OrderStatuscomboBox3 = new System.Windows.Forms.ComboBox();
            this.OrderIDtextBox = new System.Windows.Forms.TextBox();
            this.OrderDatetextBox3 = new System.Windows.Forms.TextBox();
            this.OrderDeliveryDatetextBox4 = new System.Windows.Forms.TextBox();
            this.FIOtextBox5 = new System.Windows.Forms.TextBox();
            this.CodtextBox6 = new System.Windows.Forms.TextBox();
            this.QuantitynumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Addbutton1 = new System.Windows.Forms.Button();
            this.databaseDataSet1 = new App.DatabaseDataSet1();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter = new App.DatabaseDataSet1TableAdapters.TovarTableAdapter();
            this.databaseDataSet2 = new App.DatabaseDataSet2();
            this.pickupPointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pickupPointTableAdapter = new App.DatabaseDataSet2TableAdapters.PickupPointTableAdapter();
            this.databaseDataSet3 = new App.DatabaseDataSet3();
            this.statusOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusOTableAdapter = new App.DatabaseDataSet3TableAdapters.StatusOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QuantitynumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickupPointBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Заказ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Колличество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата заказа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата доставки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Пункт выдачи";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ФИО покупател(ницы)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Код для получения";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Статус заказа";
            // 
            // CompositioncomboBox1
            // 
            this.CompositioncomboBox1.DataSource = this.tovarBindingSource;
            this.CompositioncomboBox1.DisplayMember = "id";
            this.CompositioncomboBox1.FormattingEnabled = true;
            this.CompositioncomboBox1.Location = new System.Drawing.Point(162, 70);
            this.CompositioncomboBox1.Name = "CompositioncomboBox1";
            this.CompositioncomboBox1.Size = new System.Drawing.Size(121, 21);
            this.CompositioncomboBox1.TabIndex = 9;
            // 
            // OrderPickUpPointcomboBox2
            // 
            this.OrderPickUpPointcomboBox2.DataSource = this.pickupPointBindingSource;
            this.OrderPickUpPointcomboBox2.DisplayMember = "Adress";
            this.OrderPickUpPointcomboBox2.FormattingEnabled = true;
            this.OrderPickUpPointcomboBox2.Location = new System.Drawing.Point(162, 206);
            this.OrderPickUpPointcomboBox2.Name = "OrderPickUpPointcomboBox2";
            this.OrderPickUpPointcomboBox2.Size = new System.Drawing.Size(121, 21);
            this.OrderPickUpPointcomboBox2.TabIndex = 10;
            // 
            // OrderStatuscomboBox3
            // 
            this.OrderStatuscomboBox3.DataSource = this.statusOBindingSource;
            this.OrderStatuscomboBox3.DisplayMember = "SName";
            this.OrderStatuscomboBox3.FormattingEnabled = true;
            this.OrderStatuscomboBox3.Location = new System.Drawing.Point(162, 318);
            this.OrderStatuscomboBox3.Name = "OrderStatuscomboBox3";
            this.OrderStatuscomboBox3.Size = new System.Drawing.Size(121, 21);
            this.OrderStatuscomboBox3.TabIndex = 11;
            // 
            // OrderIDtextBox
            // 
            this.OrderIDtextBox.Location = new System.Drawing.Point(162, 39);
            this.OrderIDtextBox.Name = "OrderIDtextBox";
            this.OrderIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.OrderIDtextBox.TabIndex = 12;
            // 
            // OrderDatetextBox3
            // 
            this.OrderDatetextBox3.Location = new System.Drawing.Point(162, 135);
            this.OrderDatetextBox3.Name = "OrderDatetextBox3";
            this.OrderDatetextBox3.Size = new System.Drawing.Size(100, 20);
            this.OrderDatetextBox3.TabIndex = 14;
            // 
            // OrderDeliveryDatetextBox4
            // 
            this.OrderDeliveryDatetextBox4.Location = new System.Drawing.Point(162, 171);
            this.OrderDeliveryDatetextBox4.Name = "OrderDeliveryDatetextBox4";
            this.OrderDeliveryDatetextBox4.Size = new System.Drawing.Size(100, 20);
            this.OrderDeliveryDatetextBox4.TabIndex = 15;
            // 
            // FIOtextBox5
            // 
            this.FIOtextBox5.Location = new System.Drawing.Point(162, 242);
            this.FIOtextBox5.Name = "FIOtextBox5";
            this.FIOtextBox5.Size = new System.Drawing.Size(246, 20);
            this.FIOtextBox5.TabIndex = 16;
            // 
            // CodtextBox6
            // 
            this.CodtextBox6.Location = new System.Drawing.Point(162, 280);
            this.CodtextBox6.Name = "CodtextBox6";
            this.CodtextBox6.Size = new System.Drawing.Size(100, 20);
            this.CodtextBox6.TabIndex = 17;
            // 
            // QuantitynumericUpDown1
            // 
            this.QuantitynumericUpDown1.Location = new System.Drawing.Point(163, 103);
            this.QuantitynumericUpDown1.Name = "QuantitynumericUpDown1";
            this.QuantitynumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.QuantitynumericUpDown1.TabIndex = 18;
            // 
            // Addbutton1
            // 
            this.Addbutton1.Location = new System.Drawing.Point(304, 360);
            this.Addbutton1.Name = "Addbutton1";
            this.Addbutton1.Size = new System.Drawing.Size(75, 23);
            this.Addbutton1.TabIndex = 19;
            this.Addbutton1.Text = "Добавить";
            this.Addbutton1.UseVisualStyleBackColor = true;
            this.Addbutton1.Click += new System.EventHandler(this.Addbutton1_Click);
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "Tovar";
            this.tovarBindingSource.DataSource = this.databaseDataSet1;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // databaseDataSet2
            // 
            this.databaseDataSet2.DataSetName = "DatabaseDataSet2";
            this.databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pickupPointBindingSource
            // 
            this.pickupPointBindingSource.DataMember = "PickupPoint";
            this.pickupPointBindingSource.DataSource = this.databaseDataSet2;
            // 
            // pickupPointTableAdapter
            // 
            this.pickupPointTableAdapter.ClearBeforeFill = true;
            // 
            // databaseDataSet3
            // 
            this.databaseDataSet3.DataSetName = "DatabaseDataSet3";
            this.databaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusOBindingSource
            // 
            this.statusOBindingSource.DataMember = "StatusO";
            this.statusOBindingSource.DataSource = this.databaseDataSet3;
            // 
            // statusOTableAdapter
            // 
            this.statusOTableAdapter.ClearBeforeFill = true;
            // 
            // AddOrderForm5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.Addbutton1);
            this.Controls.Add(this.QuantitynumericUpDown1);
            this.Controls.Add(this.CodtextBox6);
            this.Controls.Add(this.FIOtextBox5);
            this.Controls.Add(this.OrderDeliveryDatetextBox4);
            this.Controls.Add(this.OrderDatetextBox3);
            this.Controls.Add(this.OrderIDtextBox);
            this.Controls.Add(this.OrderStatuscomboBox3);
            this.Controls.Add(this.OrderPickUpPointcomboBox2);
            this.Controls.Add(this.CompositioncomboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOrderForm5";
            this.Text = "AddOrderForm5";
            this.Load += new System.EventHandler(this.AddOrderForm5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantitynumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickupPointBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CompositioncomboBox1;
        private System.Windows.Forms.ComboBox OrderPickUpPointcomboBox2;
        private System.Windows.Forms.ComboBox OrderStatuscomboBox3;
        private System.Windows.Forms.TextBox OrderIDtextBox;
        private System.Windows.Forms.TextBox OrderDatetextBox3;
        private System.Windows.Forms.TextBox OrderDeliveryDatetextBox4;
        private System.Windows.Forms.TextBox FIOtextBox5;
        private System.Windows.Forms.TextBox CodtextBox6;
        private System.Windows.Forms.NumericUpDown QuantitynumericUpDown1;
        private System.Windows.Forms.Button Addbutton1;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private DatabaseDataSet1TableAdapters.TovarTableAdapter tovarTableAdapter;
        private DatabaseDataSet2 databaseDataSet2;
        private System.Windows.Forms.BindingSource pickupPointBindingSource;
        private DatabaseDataSet2TableAdapters.PickupPointTableAdapter pickupPointTableAdapter;
        private DatabaseDataSet3 databaseDataSet3;
        private System.Windows.Forms.BindingSource statusOBindingSource;
        private DatabaseDataSet3TableAdapters.StatusOTableAdapter statusOTableAdapter;
    }
}