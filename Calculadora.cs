using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.NETS8
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y}");
        }

        public void Subtrair(int x, int y)
        {

            Console.WriteLine($"{x} - {y}");
        }

        public void Multiplicar(int x, int y)
        {

            Console.WriteLine($"{x} * {y}");
        }

        public void Dividir(int x, int y)
        {

            Console.WriteLine($"{x} / {y}");
        }
    }
}