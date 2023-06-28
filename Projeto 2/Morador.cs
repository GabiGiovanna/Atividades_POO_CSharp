using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2
{
    public class Morador : Pessoa
    {
        public string mostrar()
        {
            return $"  Eu sou o morador {this.nome}, meu apartamento tem {this.area} mts e a cor da porta é {this.cor} ";
        }

    }
}
