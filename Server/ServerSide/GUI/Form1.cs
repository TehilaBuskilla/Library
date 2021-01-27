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
using Models;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AudiencesBLL AudiencesBLL = new AudiencesBLL();
        private void button1_Click(object sender, EventArgs e)
        {
            AudiencesBLL.Add(new AudiencesBLL() { KindAudience =textBox1.Text});
            ShowDetails();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowDetails();
        }

        private void ShowDetails()
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            listBox1.Items.AddRange(AudiencesBLL.Get().Select(a=>a.KindAudience).ToArray());
            comboBox1.Items.AddRange(AudiencesBLL.Get().Select(a => a.KindAudience).ToArray());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Audiences audience = new Audiences();
            audience = AudiencesBLL.Get().Find(a => a.KindAudience==comboBox1.SelectedItem.ToString());
            AudiencesBLL.Delete(audience);
            ShowDetails();
        }
    }
}
