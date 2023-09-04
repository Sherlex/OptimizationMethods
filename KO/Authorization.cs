using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KO
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void entry_Click(object sender, EventArgs e)
        {
            if (login.Text == "admin" && password.Text == "1378")
            {
                EditDB edit = new EditDB();
                edit.Show();
                Hide();
            }
            else
            {
                login.Text = "";
                password.Text = "";

                MessageBox.Show("Неправильный логин или пароль","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
