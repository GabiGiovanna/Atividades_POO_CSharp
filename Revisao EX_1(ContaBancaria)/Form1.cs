using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisão_Prova_Técnica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Conta conta = new Conta();

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                conta.getSaldoFormatado();
                conta.depositar(double.Parse(txt_Deposito.Text));
                MessageBox.Show("Seu saldo atua é de: "+ conta.getSaldoFormatado().ToString() + "\nA data do deposito é : " + conta.getDataAberturaFormatada());

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
               
                conta.sacar(double.Parse(txt_Saque.Text));
                MessageBox.Show("Seu saldo atua é de: " + conta.getSaldoFormatado().ToString() + "A data do saque é : " + conta.getDataAberturaFormatada());

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Seu saldo atua é de: " + conta.getSaldoFormatado().ToString() + "A data atual é: " + conta.getDataAberturaFormatada());

        }
    }
}
