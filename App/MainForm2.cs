﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class MainForm2 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Учёба\App\App\Database.mdf;Integrated Security=True");
        SqlDataAdapter adpt;
        DataTable dt;
        public MainForm2()
        {
            InitializeComponent();
            if (ClassContext.levelAccesses == -1 | ClassContext.levelAccesses == 1)
            {
                EditButton2.Visible = false;
                ShowButton3.Visible = false;
                AddButton1.Visible = false;
            }
            showData();
        }

        public void showData()
        {
            adpt = new SqlDataAdapter("SELECT t1.CName as Название, t2.NowDiscont as Скидка,t2.OnSclad as Количество,t2.TResume as Описание FROM Category t1, Tovar t2 WHERE t1.Id = t2.Category", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void ShowButton3_Click(object sender, EventArgs e)
        {
            OrdersForm4 ordersForm4 = new OrdersForm4();
            ordersForm4.Show();
        }

        private void AddButton1_Click(object sender, EventArgs e)
        {
            AddForm3 addForm3 = new AddForm3();
            addForm3.Show();
        }

        private void EditButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
