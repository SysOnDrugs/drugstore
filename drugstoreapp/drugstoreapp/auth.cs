using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drugstoreapp
{
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();
        }

        private void sign_in_btn_Click(object sender, EventArgs e)
        {
            {
                if (logintbox.Text == "Кладовщик")
                {
                    if (passwdtbox.Text == "st")
                    {
                        this.Hide();
                        storekeeper storekeeper = new storekeeper();
                        storekeeper.Show();
                    }
                    else
                        MessageBox.Show("Пароль неверный!");
                }
                if (logintbox.Text == "Баба Клава")
                {
                    if (passwdtbox.Text == "dl")
                    {
                        this.Hide();
                        dealer dealer = new dealer();
                        dealer.Show();
                    }
                    else
                        MessageBox.Show("Пароль неверный!");
                }

                else
                    MessageBox.Show("Логин неверый!");
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
