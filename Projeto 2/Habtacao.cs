using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2
{
    public class Habtacao : Porta
    {
        protected double bases { get; set; }
        protected double altura { get; set; }
        protected double area = 0;

        public double Base
        {
            set
            {

                if (value != 0)
                {
                    this.bases = value;
                }

                else
                {
                    throw new Exception("A base deve ser obrigatoriamente preenchido.");
                };
            }
            get { return bases; }
        }
        public double Altura
        {
            set
            {

                if (value.ToString() != string.Empty) 
                {
                    this.altura = value;
                }

                else
                {
                    throw new Exception("A altura deve ser obrigatoriamente preenchido.");
                };
            }
            get { return altura; }
        }


        public double Area()
        {
            this.area = this.altura * this.bases;
            return this.area;

        }

        public string mostrar()
        {
            return $"Eu sou uma habitacao, minha area é {this.area} m2, e a cor da minha porta é {this.cor}";

        }


    }
}
