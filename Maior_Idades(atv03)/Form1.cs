using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maior_Idades_n_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Maior_Idade maior = new Maior_Idade();
        int Cont = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            

            try
            {

                maior.Nome = txt_Nome.Text;
                maior.Idade = int.Parse(txt_Idade.Text);
                maior.Calculo();
                txt_Nome.Text = " ";
                txt_Idade.Text = " ";
                lbl_Resposta.Text = "Pessoa Cadastrada co sucesso!";
                Cont++;
                
                if(Cont == 3)
                {
                    
                    MessageBox.Show(maior.Exibir(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
               

            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Digite um valor!!","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

     
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
