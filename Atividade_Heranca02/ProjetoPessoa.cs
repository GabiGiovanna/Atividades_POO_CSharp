using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Heranca02
{
    public class ProjetoPessoa 
    {

        //com os atributos privados nome, data de nascimento e altura.


        public string nome { get; set; }

        public DateTime data { get; set; }

        public string altura { get; set; }

        public int dependentes { get; set; }


        public string Dados(string nome,DateTime nasc,string altura)


        {
            this.nome = nome;
            this.data = nasc;
            this.altura = altura;

            DateTime hoje = DateTime.Now;

            int idade = 0;

            idade = hoje.Year - data.Year;

            return "Seu nome é: "+nome+"\nSua idade é: " + idade + "\n Sua altura é" + altura ;


        }


        public double Plano(int dependentes) {

            this.dependentes = dependentes;

            double ValorPlano = 0;

            if(dependentes >= 5)
            {
                ValorPlano = 0;
            }

            else if(dependentes == 1 || dependentes == 2)
            {
                ValorPlano = dependentes * 150;
            }

            else if (dependentes == 3 || dependentes == 4)
            {
                ValorPlano = dependentes * 100;
            }


            return ValorPlano;

        }

    
    }
}
