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
    public partial class AddOrderForm5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Учёба\App\App\Database.mdf;Integrated Security=True");
        public AddOrderForm5()
        {
            con.Open();
            InitializeComponent();
        }

        private void AddOrderForm5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet3.StatusO". При необходимости она может быть перемещена или удалена.
            this.statusOTableAdapter.Fill(this.databaseDataSet3.StatusO);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet2.PickupPoint". При необходимости она может быть перемещена или удалена.
            this.pickupPointTableAdapter.Fill(this.databaseDataSet2.PickupPoint);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet1.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.databaseDataSet1.Tovar);

        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(" INSERT INTO[dbo].[Orders] ([OrderId], [Composition], [Quantity], [OrderDate],[OrderDeliveryDate],[OrderPickUpPoint],[FIO],[cod],[OrderStatus]) VALUES(" + int.Parse(OrderIDtextBox.Text) + "," + CompositioncomboBox1.SelectedIndex + "," + QuantitynumericUpDown1.Value + ",'" + OrderDatetextBox3.Text + "','"+OrderDeliveryDatetextBox4.Text+"',"+ + OrderPickUpPointcomboBox2.SelectedIndex+",'" + FIOtextBox5.Text +"',"+int.Parse(CodtextBox6.Text)+","+ OrderStatuscomboBox3.SelectedIndex+ ")", con);
            
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешно добавлено",
                "Добавлен товар",
                MessageBoxButtons.OKCancel);
                this.Close();
            }
            else
            {
                MessageBox.Show("Что-то не так",
                "Что-то не так",
                MessageBoxButtons.OKCancel);
            }
        }
    }
}
