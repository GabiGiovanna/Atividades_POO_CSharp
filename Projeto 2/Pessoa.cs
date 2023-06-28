using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2
{
    public class Pessoa : Habtacao
    {
        protected string nome;

        public void constroiNome(string _nome)
        {
            if( _nome != string.Empty) {
                this.nome = _nome;
            }
            else
            {
                throw new Exception("O nome não pode ficar vazio");
            }
            
        }

        public string mostrar()
        {

            return $"Eu sou uma habitacao, com o nome:  {this.nome}";

        }
    }
}
