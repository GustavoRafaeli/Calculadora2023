using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp.Entities
{
    public class Calculo
    {
        public double Valor1 { get; set; }

        public double Valor2 { get; set; }

        public double Resultado { get; set; }

        public Calculo(double valor1, double valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public void Soma()
        {
            Resultado = Valor1 + Valor2;
        }

        public void Sub()
        {
            Resultado = Valor1 - Valor2;
        }

        public void Div()
        {
            Resultado = Valor1 / Valor2;
        }

        public void Mult()
        {
            Resultado = Valor1 * Valor2;
        }
    }
}