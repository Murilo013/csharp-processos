using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BLL.conecta();
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BLL.desconecta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            chart1.Series[0].Points.Clear();
      
            Cliente.setCNPJ(textBox1.Text);
            BLL.validaCNPJ();
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
            {
                textBox2.Text = Cliente.getNome();
                DAL.ConsultaDados();

                while (!Erro.getErro())
                {
                    if (radioButton1.Checked)
                    {
                        chart1.Series[0].Points.AddXY(contador++, VendaCliente.getToneladas());
                        DAL.getProximo();
                    }
                    if (radioButton2.Checked)
                    {
                        chart1.Series[0].Points.AddXY(contador++, VendaCliente.getValor());
                        DAL.getProximo();
                    }
                }
            }
        }
    }
}
