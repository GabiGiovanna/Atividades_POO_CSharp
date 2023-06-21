using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_Idades_n_3_
{
    public class Maior_Idade
    {
        private int idade;
        private string nome;
        public string M_nome = " ";
        public int M_idade= 0 ;


        public int Idade
        {


            set
            {

                if(value > 0)
                {
                    this.idade = value;
                    

                }
                else
                {
                    throw new Exception("Digite uma idade válida!!");
                }
            }


            get { return idade; }
        }



        public string Nome
        {

            set
            {
                if(value != string.Empty)
                {
                    this.nome = value;
                    
                }
                else 
                { 
                    throw new Exception("Digite um nome!!");
                }
            }
            get { return nome; }
        }



        public void Calculo()
        {

            if(this.idade > this.M_idade)
            {
                this.M_idade = this.idade;
                this.M_nome = this.nome;
            }


        }

        public string Exibir()
        {

            return this.M_nome + " possui a maior idade que é: " + this.M_idade;
        }










    }
}
