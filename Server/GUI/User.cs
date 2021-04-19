using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DataObject;

namespace GUI
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsersDTO usersDTO = new UsersDTO();
            usersDTO = UsersBLL.GetAll().Find(a => a.IdUser==int.Parse(textBox1.Text));

            if (usersDTO == null)
            {
                label3.Text = "אין משתמש";


            }
            else
            {
                label3.Text = usersDTO.NameUser;
            }
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
