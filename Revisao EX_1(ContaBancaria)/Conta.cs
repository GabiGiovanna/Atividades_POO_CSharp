using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão_Prova_Técnica
{
    public class Conta
    {

        private double saldo { get; set; }
        private DateTime dataAbertura { get; } 
        
        public Conta()
        {
            this.saldo = 0.0;
            this.dataAbertura = DateTime.Now;
        }

        public string getDataAberturaFormatada()
        {
            return dataAbertura.ToString("dd/MM/yyyy");

        }
        public string getSaldoFormatado()
        {
            return saldo.ToString("C");

        }

        public double depositar(double valor)
        {

            this.saldo = valor + this.saldo;
            return this.saldo;
        }

        public double sacar(double valor)
        {
            if(valor > this.saldo)
            {
                throw new Exception("Saldo insuficiente");
            }

            else
            {
                this.saldo = this.saldo - valor;
                return this.saldo;
            }
                 
        }

    

    }
}
