using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2
{
    public class Porta
    {
        protected string cor { get; set; }

        public void constroiCor(string _cor)
        {
            if(_cor != string.Empty)
            {
                this.cor = _cor;

            }

            else
            {
                throw new Exception("A cor deve ser obrigatoriamente preenchida.");
            }

        }
            
        

        public string mostrar()
        {
            return "Eu sou uma porta, minha cor é " + this.cor;
        }

    }
}
