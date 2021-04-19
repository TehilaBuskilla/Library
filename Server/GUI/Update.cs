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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        int index = 0;
        List<UsersDTO> usersDTO = new List<UsersDTO>();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void Update_Load(object sender, EventArgs e)
        {
            usersDTO = UsersBLL.GetAll();
            textBox1.Text = usersDTO[index].NameUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index++;
            if (index == usersDTO.Count)
                index = 0;
            textBox1.Text = usersDTO[index].NameUser;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
                index = usersDTO.Count - 1;
            textBox1.Text= usersDTO[index].NameUser;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsersDTO userDTO = new UsersDTO();
            usersDTO[index].NameUser = textBox1.Text;
            UsersBLL.Update(usersDTO[index]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            usersDTO = UsersBLL.GetAll();
        }
    }
}
