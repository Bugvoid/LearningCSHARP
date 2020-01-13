using DLL_TESTE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_DLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Exemplo obj = new Exemplo();
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(obj.soma(Convert.ToSingle(textBox1.Text), Convert.ToSingle(textBox3.Text)));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(obj.subtracao(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox3.Text)));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(obj.multiplicacao(Convert.ToSingle(textBox1.Text), Convert.ToSingle(textBox3.Text)));
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(obj.divisao(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox3.Text)));
        }
    }
}
