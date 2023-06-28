using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Porta port = new Porta();
                port.constroiCor(txt_Cor.Text);
                MessageBox.Show(port.mostrar());
            }
            catch (Exception ex) { 
            
                MessageBox.Show(ex.Message);
            }
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Habtacao habt = new Habtacao();
                habt.constroiCor(txt_Cor.Text);
                habt.Base = double.Parse(txt_Base.Text);
                habt.Altura = double.Parse(txt_Altura.Text);
                habt.Area();
                MessageBox.Show(habt.mostrar());
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("A base ou a altura não pode ser vazia");
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                Pessoa pessoa = new Pessoa();
                pessoa.constroiNome(txt_Nome.Text);
                MessageBox.Show(pessoa.mostrar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        Morador morador = new Morador();

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                morador.constroiCor(txt_Cor.Text);
                morador.Base = double.Parse(txt_Base.Text);
                morador.Altura = double.Parse(txt_Altura.Text);
                morador.Area();
                morador.constroiNome(txt_Nome.Text);
                MessageBox.Show(morador.mostrar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
