using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2._1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.comboBox1.Items.Add("3-letnie");
            this.comboBox1.Items.Add("3,5-letnie");
            this.comboBox1.Items.Add("5-letnie");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "";
            message += this.textBox1.Text + '\n';
            message += this.textBox2.Text + '\n';
            message += "studia " + this.comboBox1.Text + '\n';
            if(checkBox1.Checked)
            {
                message += this.checkBox1.Text + '\n';
            }
            else
            {
                if(checkBox2.Checked)
                {
                    message += this.checkBox2.Text + '\n';
                }
            }
            MessageBox.Show(message, "Uczelnia");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
