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
                
                ShowButton3.Visible = false;
                AddButton1.Visible = false;
            }
            showData();
        }

        public void showData()
        {
            adpt = new SqlDataAdapter("SELECT t1.CName as Название, t2.NowDiscont as Скидка,t2.OnSclad as Количество,t2.TResume as Описание, t2.Picture as Изображение FROM Category t1, Tovar t2 WHERE t1.Id = t2.Category", con);
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
            addForm3.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { if (ClassContext.levelAccesses == 0)
            {
                AddForm3.category = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                AddForm3.nowDiscont = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                AddForm3.onSclad = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                AddForm3.resume = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                AddForm3.fileName = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                AddForm3 addForm3 = new AddForm3();
             
                addForm3.Show();
            }
        }
    }
}
