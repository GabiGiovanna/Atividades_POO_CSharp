using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Retangulo
{
    public class Area
    {


        private double bases;
        private double altura;
        

        public double Base{

            set
            {
                if(value > 0)
                {

                    this.bases = value;
                    

                }
                else
                {
                    throw new Exception("O número digitado é invalido");
                }

            }
            get { return bases; }
    
        }

        public double Altura
        {
            set
            {
                if(value > 0)
                {
                    this.altura = value; 
                }
                else
                {
                    throw new Exception("O número digitado é invalido");
                }
            }

            get { return altura; }
        }

        public double Total;

        public void Calculo()
        {
          Total = this.bases * this.altura;
        }

       

        public string Retorno()
        {
            return "A area desse quadrado/retangulo \nDe altura: " + this.Altura +
                "\nBase: " + this.Base +
                "\nTem valor total de: " + this.Total;
        }

    }


}
