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

namespace KO
{
    public partial class EditDB : Form
    {
        SqlConnection sqlConnection;
        public EditDB()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command1 = new SqlCommand("INSERT INTO [Methods] (Method) VALUES(@method)", sqlConnection);
                command1.Parameters.AddWithValue("method", methodtextBox2.Text);
                command1.ExecuteNonQuery();
                MessageBox.Show("Данные успешно добавлены в базу!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка! Повторите ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                methodtextBox2.Clear();
            }
          
        }

        private void EditDB_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Integrated Security=SSPI; AttachDBFilename=|DataDirectory|\Database1.mdf";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }

        private void addOptionbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Options] (Opti, V1, V2, A1from, A1to, A2from, A2to, a, a1, b, b1, u, u1, Hours, Accuracy) VALUES(@Opti, @V1, @V2, @A1from, @A1to, @A2from, @A2to, @a, @a1, @b, @b1, @u, @u1, @Hours, @Accuracy)", sqlConnection);
                command.Parameters.AddWithValue("Opti", optiontextBox2.Text);
                command.Parameters.AddWithValue("V1", V1textBox2.Text);
                command.Parameters.AddWithValue("V2", V2textBox2.Text);
                command.Parameters.AddWithValue("A1from", A1fromtextBox2.Text);
                command.Parameters.AddWithValue("A1to", A1totextBox2.Text);
                command.Parameters.AddWithValue("A2from", A2fromtextBox2.Text);
                command.Parameters.AddWithValue("A2to", A2totextBox2.Text);
                command.Parameters.AddWithValue("a", atextBox2.Text);
                command.Parameters.AddWithValue("a1", a1textBox2.Text);
                command.Parameters.AddWithValue("b", btextBox2.Text);
                command.Parameters.AddWithValue("b1", b1textBox2.Text);
                command.Parameters.AddWithValue("u", utextBox2.Text);
                command.Parameters.AddWithValue("u1", u1textBox2.Text);
                command.Parameters.AddWithValue("Hours", hourstextBox2.Text);
                command.Parameters.AddWithValue("Accuracy", accuracytextBox2.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Данные успешно добавлены в базу!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }
            catch
            {
                MessageBox.Show("Произошла ошибка! Повторите ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                optiontextBox2.Clear();
                V1textBox2.Clear();
                V2textBox2.Clear();
                A1fromtextBox2.Clear();
                A1totextBox2.Clear();
                A2fromtextBox2.Clear();
                A2totextBox2.Clear();
                atextBox2.Clear();
                a1textBox2.Clear();
                btextBox2.Clear();
                b1textBox2.Clear();
                utextBox2.Clear();
                u1textBox2.Clear();
                hourstextBox2.Clear();
                accuracytextBox2.Clear();
            }
        }

        private void optiontextBoxes_TextChanged(object sender, EventArgs e)
        {
            if ((optiontextBox2.Text != "") && (V1textBox2.Text != "") && (V2textBox2.Text != "") && (A1fromtextBox2.Text != "") &&
               (A1totextBox2.Text != "") && (A2fromtextBox2.Text != "") && (A2totextBox2.Text != "") &&
               (atextBox2.Text != "") && (a1textBox2.Text != "") && (btextBox2.Text != "") && (b1textBox2.Text != "") &&
               (utextBox2.Text != "") && (u1textBox2.Text != "") && (hourstextBox2.Text != "") && (accuracytextBox2.Text != ""))
                addOptionbutton.Enabled = true;
            else addOptionbutton.Enabled = false;
        }

        private void methodtextBox2_TextChanged(object sender, EventArgs e)
        {
            if (methodtextBox2.Text != "") addbutton.Enabled = true;
            else addbutton.Enabled = false;
        }
    }
}
