using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClassContext.levelAccesses = -1;
        }

        private void Enterbutton1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Учёба\App\App\Database.mdf;Integrated Security=True");
            string query = "Select *from Users where login ='" + LoginTextBox1.Text + "' and password ='" + PasswordTextBox2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                sqlcon.Open();
                SqlCommand commandAll = new SqlCommand("Select post from Users where login ='" + LoginTextBox1.Text + "' and password ='" + PasswordTextBox2.Text + "'", sqlcon);
                ClassContext.levelAccesses = Convert.ToInt32(commandAll.ExecuteScalar());
                //sqlcon.Close();
                MainForm2 FM = new MainForm2();
                FM.Show();

            }
            else
            {
                MessageBox.Show("Ошибка",
                "Проверьте логин и пароль",
                MessageBoxButtons.OKCancel);
            }
        }

        private void Resumebutton1_Click(object sender, EventArgs e)
        {

            MainForm2 FM = new MainForm2();
            FM.Show();
        }
    }
}
