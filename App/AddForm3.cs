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
      
        public static string fileName;
        public static string category;
        public static string nowDiscont;
        public static string onSclad;
        public static string resume;
        public static byte[] image_bytes;
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Учёба\App\App\Database.mdf;Integrated Security=True");

        public AddForm3()
        {
            sqlcon.Open();
            InitializeComponent();
            if(resume!= null)
            {

                CategoryComboBox1.Text = category;
                DiscontAmountTextBox1.Text = nowDiscont;
                OnStockTextBox2.Text = onSclad;
                DescriptionRichTextBox1.Text = resume;
                category = null;



            }
            if (fileName != null)
            {
                ImageLabel6.Text = fileName;
                fileName = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void AddButton1_Click(object sender, EventArgs e)
        {if (CategoryComboBox1.Text != null & DiscontAmountTextBox1.Text!=null & OnStockTextBox2.Text != null & DescriptionRichTextBox1.Text != null)
            {
                SqlCommand command = new SqlCommand(" INSERT INTO[dbo].[Tovar] ([Category], [NowDiscont], [OnSclad], [TResume]) VALUES(" + CategoryComboBox1.SelectedIndex + "," + DiscontAmountTextBox1.Text + "," + OnStockTextBox2.Text + ",N'" + DescriptionRichTextBox1.Text+ "')", sqlcon);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Успешно добавлено",
                    "Добавлен товар",
                    MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("Что-то не так",
                    "Что-то не так",
                    MessageBoxButtons.OKCancel);
                }
            }
            
        }

        private void ExitButton2_Click(object sender, EventArgs e)
        {
            sqlcon.Close();
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            
            fileName = openFileDialog1.FileName;
            if (string.IsNullOrEmpty(fileName))
            {
                return;
            }
            ImageLabel6.Text = fileName;
           // image_bytes = File.ReadAllBytes(fileName);
        }

        private void AddForm3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.databaseDataSet.Category);

        }
    }
}
