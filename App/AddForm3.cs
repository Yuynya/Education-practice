using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class AddForm3 : Form
    {

        byte[] image_bytes;
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Учёба\App\App\Database.mdf;Integrated Security=True");

        public AddForm3()
        {
            sqlcon.Open();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void AddButton1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(" INSERT INTO[dbo].[Tovar] ([Category], [NowDiscont], [OnSclad], [Resume],[Picture]) VALUES(" + CategoryComboBox1.SelectedIndex + "," + DiscontAmountTextBox1.Text + "," + OnStockTextBox2.Text + ",N'" + DescriptionRichTextBox1.Text + "'" + "N'" + image_bytes + "')", sqlcon);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешно добавлено",
                "Добавлен товар",
                MessageBoxButtons.OKCancel);
            }
        }

        private void ExitButton2_Click(object sender, EventArgs e)
        {
            sqlcon.Close();
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            var fileName = openFileDialog1.FileName;
            if (string.IsNullOrEmpty(fileName))
            {
                return;
            }
            ImageLabel6.Text = fileName;
            image_bytes = File.ReadAllBytes(fileName);
        }
    }
}
