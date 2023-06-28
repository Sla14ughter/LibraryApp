using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mail_LIB;
using MySqlConnector;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ne = "";
            if (!Mail.CheckMail(textBox1.Text)) ne = "не ";
            MessageBox.Show($"Email {ne}существует");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Данный email занят. Попробуйте использовать следующий: {Mail.GetMail(textBox1.Text)}");
        }
    }
}
