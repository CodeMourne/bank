using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WinFormsApp4
{

    public partial class Form1 : Form
    {
        Account acc;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            acc = new Account(Convert.ToInt32(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            acc.Add(Convert.ToInt32(textBox3.Text));
            listBox1.Items.Add($"Клиент - прочерк, операция - зачисление, сумма зачисления: {textBox3.Text}.");
            listBox1.Items.Add($"Cумма на счете до/после операции: {acc.}/{(Convert.ToInt32(textBox2.Text))+(Convert.ToInt32(textBox3.Text))}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

