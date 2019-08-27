using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W_liteKoll.br.com.lite.dotnet.service;

namespace W_liteKoll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            WCreatedServiceService wService = new WCreatedServiceService();
            string voltou = wService.ping("Luan Castro Alves");
            MessageBox.Show("Voltou " + voltou);


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            WCreatedServiceService wService = new WCreatedServiceService();
            carro[] carros = wService.getMeusCarro();
            foreach( carro  carroatual in carros)
            {
                MessageBox.Show("Voltou um " + carroatual.nome + " da cor " + carroatual.cor);
            }

        }
    }
}
