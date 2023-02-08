using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class OrdersForm4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Учёба\App\App\Database.mdf;Integrated Security=True");
        SqlDataAdapter adpt;
        DataTable dt;
        public OrdersForm4()
        {
            InitializeComponent();
            showData();
        }
        public void showData()
        {
            adpt = new SqlDataAdapter("SELECT o.Composition, o.Quantity, o.OrderDate, o.OrderDeliveryDate, o.OrderPickupPoint, o.FIO, o.cod, o.OrderStatus FROM Orders o, Tovar t, StatusO s WHERE t.Id=o.Composition AND  s.Id=o.OrderStatus", con);
           
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
            private void ExitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddOrderForm5 addOrderForm5 = new AddOrderForm5();
            addOrderForm5.ShowDialog();
        }
    }
}
