using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace KO
{
    public partial class Form1 : Form
    {
        int selected = 0;
        SqlConnection sqlConnection;
        ToolTip tooltrip = new ToolTip();
        public Form1()
        {
            InitializeComponent();
            
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Integrated Security=SSPI; AttachDBFilename=|DataDirectory|\Database1.mdf";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            DataTable Methods = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM [Methods]", sqlConnection);
            SqlDataAdapter methodDataAdapter = new SqlDataAdapter(command);
            methodDataAdapter.Fill(Methods);
            methodComboBox.DataSource = Methods;
            methodComboBox.DisplayMember = "Method";

            DataTable Options = new DataTable();
            SqlCommand command2 = new SqlCommand("SELECT * FROM [Options]", sqlConnection);
            SqlDataAdapter optionsDataAdapter = new SqlDataAdapter(command2);

            optionsDataAdapter.Fill(Options);
            optionComboBox.DataSource = Options;
            optionComboBox.DisplayMember = "Opti";
            
        }

        private void optionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Integrated Security=SSPI; AttachDBFilename=|DataDirectory|\Database1.mdf";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            if (optionComboBox.Text != "System.Data.DataRowView")
           
            selected = Convert.ToInt32(optionComboBox.Text);
            
            DataTable OptionsTo = new DataTable();
            SqlCommand commandVar = new SqlCommand("SELECT * FROM [Options] WHERE [Opti] = @par", sqlConnection);
            commandVar.Parameters.AddWithValue("par", selected);
       
            SqlDataAdapter optionsVarDataAdapter = new SqlDataAdapter(commandVar);
            SqlDataReader reader = commandVar.ExecuteReader();

            while (reader.Read())
            {
                V1textBox.Text = reader[1].ToString();
                V2textBox.Text = reader[2].ToString();
                A1fromtextBox.Text = reader[3].ToString();
                A1totextBox.Text = reader[4].ToString();
                A2fromtextBox.Text = reader[5].ToString();
                A2totextBox.Text = reader[6].ToString();
                atextBox.Text = reader[7].ToString();
                a1textBox.Text = reader[8].ToString();
                btextBox.Text = reader[9].ToString();
                b1textBox.Text = reader[10].ToString();
                utextBox.Text = reader[11].ToString();
                u1textBox.Text = reader[12].ToString();
                hourstextBox.Text = reader[13].ToString();
                accuracytextBox.Text = reader[14].ToString();
            }
        }


        public double Calculate(double a, double b)
        {
            double result, V1, V2, alpha, alpha1, beta, beta1, mu, mu1, h;

            V1 = Convert.ToDouble(V1textBox.Text);
            V2 = Convert.ToDouble(V2textBox.Text);
            alpha = Convert.ToDouble(atextBox.Text);
            alpha1 = Convert.ToDouble(a1textBox.Text);
            beta = Convert.ToDouble(btextBox.Text);
            beta1 = Convert.ToDouble(b1textBox.Text);
            mu = Convert.ToDouble(utextBox.Text);
            mu1 = Convert.ToDouble(u1textBox.Text);
            h = Convert.ToDouble(hourstextBox.Text);
            result = alpha * Math.Pow((a * a + beta * b - mu * V1), 2) + alpha1 * Math.Pow((beta1 * a + b * b - mu * V2), 2);
            return result;
        }

        private void calculatebutton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            double i, j, i0, j0, h, max, F0, F1, a1, a2, b1, b2;
            h = 1;
            j = 0;
            i0 = 0;
            j0 = 0;
            double T1 = -100;
            double T2 = -100;
            max = 0.001;
            if (check(V1textBox))
            {
                a1 = Convert.ToDouble(A1fromtextBox.Text);
                a2 = Convert.ToDouble(A2fromtextBox.Text);
                b1 = Convert.ToDouble(A1totextBox.Text);
                b2 = Convert.ToDouble(A2totextBox.Text);
                double eps = Convert.ToDouble(accuracytextBox.Text) / Convert.ToDouble(hourstextBox.Text);
                double C;
                for (;;)
                {
                    for (i = a1; i <= b1; i += h)
                    {
                        for (j = a2; j <= b2; j += h)
                        {
                            if (j + i <= 8)
                            {
                                C = Calculate(i, j);
                                dataGridView1.Rows.Add(i, j, C);
                            }
                            if ((max < Calculate(i, j)) && (j + i <= 8))
                            {
                                max = Calculate(i, j);
                                T1 = i;
                                T2 = j;
                            }
                        }
                    }
                    i0 = T1 - h;
                    j0 = T2 - h;
                    F0 = Calculate(i0, j0);
                    F1 = max;
                    if (Math.Abs(F1 - F0) < eps)
                    {
                        T1 = Math.Round(T1, 4);
                        T2 = Math.Round(T2, 4);
                        max = Math.Round(max, 4);
                        resA1textBox.Text = T1.ToString();
                        resA2textBox.Text = T2.ToString();
                        maxtextBox.Text = max.ToString();
                        break;
                    }
                    else
                    {
                        h /= 2;
                        a1 = T1 - h;
                        a2 = T2 - h;
                        b1 = T1 + h;
                        b2 = T2 + h;
                    }
                }
            }
            else
                MessageBox.Show("Одно или несколько полей пусты или содержат некорректные значения! Повторитет ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorization auth = new Authorization();
            auth.Show();
        }

        private void Any_main_TextChanged(object sender, EventArgs e)
        {
            if ((V1textBox.Text != "") && (V2textBox.Text != "") && (A1fromtextBox.Text != "") &&
                (A1totextBox.Text != "") && (A2fromtextBox.Text != "") && (A2totextBox.Text != "") &&
                (atextBox.Text != "") && (a1textBox.Text != "") && (btextBox.Text != "") && (b1textBox.Text != "") &&
                (utextBox.Text != "") && (u1textBox.Text != "") && (hourstextBox.Text != "") && (accuracytextBox.Text != ""))
                calculatebutton.Enabled = true;
        }

        private void button2d_Click(object sender, EventArgs e)
        {
            if (check(V1textBox))
            {
                Params paramss = new Params
                {
                    V1 = Convert.ToDouble(V1textBox.Text),
                    V2 = Convert.ToDouble(V2textBox.Text),
                    a1 = Convert.ToDouble(A1fromtextBox.Text),
                    a2 = Convert.ToDouble(A1totextBox.Text),
                    b1 = Convert.ToDouble(A2fromtextBox.Text),
                    b2 = Convert.ToDouble(A2totextBox.Text),
                    alpha = Convert.ToDouble(atextBox.Text),
                    alpha1 = Convert.ToDouble(a1textBox.Text),
                    beta = Convert.ToDouble(btextBox.Text),
                    beta1 = Convert.ToDouble(b1textBox.Text),
                    mu = Convert.ToDouble(utextBox.Text),
                    mu1 = Convert.ToDouble(u1textBox.Text),
                };

                Form2d form2d = new Form2d(paramss);
                form2d.Show();
            }
            else
                MessageBox.Show("Одно или несколько полей пусты или содержат некорректные значения! Повторитет ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3d_Click(object sender, EventArgs e)
        {
            if (check(V1textBox))
            {
                Params paramss = new Params
                {
                    V1 = Convert.ToDouble(V1textBox.Text),
                    V2 = Convert.ToDouble(V2textBox.Text),
                    a1 = Convert.ToDouble(A1fromtextBox.Text),
                    a2 = Convert.ToDouble(A1totextBox.Text),
                    b1 = Convert.ToDouble(A2fromtextBox.Text),
                    b2 = Convert.ToDouble(A2totextBox.Text),
                    alpha = Convert.ToDouble(atextBox.Text),
                    alpha1 = Convert.ToDouble(a1textBox.Text),
                    beta = Convert.ToDouble(btextBox.Text),
                    beta1 = Convert.ToDouble(b1textBox.Text),
                    mu = Convert.ToDouble(utextBox.Text),
                    mu1 = Convert.ToDouble(u1textBox.Text),
                };

                Form3d form3d = new Form3d(paramss);
                form3d.Show();
            }
            else
                MessageBox.Show("Одно или несколько полей пусты или содержат некорректные значения! Повторитет ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void V1textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {

                if ((sender as TextBox).Text.Contains(",")) 
                {
                    e.Handled = true;
                }

                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        private void savetableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "xlsx files (*.xlsx)|*.xlsx|All files(*.*)|*.*";
            string file_name = string.Empty;

            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            if (save.ShowDialog() == DialogResult.OK)
            {
                file_name = save.FileName;
                try
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            worksheet.Rows[i + 1].Columns[j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                        }
                    }
                    excelapp.AlertBeforeOverwriting = false;
                    workbook.SaveAs(file_name, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    save.Dispose();
                    excelapp.Quit();

                    MessageBox.Show(text: "Данные сохранены успешно!", caption: "Информация",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show(text: "При сохранении данных произошла ошибка!", caption: "Ошибка!",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Автор программы: Голова Елена, 474\n" +
              "Назначение программы - поиск \n" +
              "оптимального решения задачи \n" +
              "при заданных условиях.\n",
              caption: "О программе",
              buttons: MessageBoxButtons.OK,
              icon: MessageBoxIcon.Information);
        }

        private bool check(TextBox textbox)
        {
            if ((V1textBox.Text != "") && (V2textBox.Text != "") && (A1fromtextBox.Text != "") &&
              (A1totextBox.Text != "") && (A2fromtextBox.Text != "") && (A2totextBox.Text != "") &&
              (atextBox.Text != "") && (a1textBox.Text != "") && (btextBox.Text != "") && (b1textBox.Text != "") &&
              (utextBox.Text != "") && (u1textBox.Text != "") && (hourstextBox.Text != "") && (accuracytextBox.Text != "") && (accuracytextBox.Text != "0") &&
              (V1textBox.Text != ",") && (V2textBox.Text != ",") && (A1fromtextBox.Text != ",") &&
              (A1totextBox.Text != ",") && (A2fromtextBox.Text != ",") && (A2totextBox.Text != ",") &&
              (atextBox.Text != ",") && (a1textBox.Text != ",") && (btextBox.Text != ",") && (b1textBox.Text != ",") &&
              (utextBox.Text != ",") && (u1textBox.Text != ",") && (hourstextBox.Text != ",") && (accuracytextBox.Text != ","))
                return true;
            else
                return false;
        }

        private void methodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tooltrip.SetToolTip(methodComboBox, methodComboBox.Text);
        }
    }
}
