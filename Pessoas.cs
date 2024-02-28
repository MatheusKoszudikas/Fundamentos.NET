using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploFundamentos.NETS;

namespace ExemploFundamentos.NETS
{
    public class Pessoas
    {

        /// <summary>
        /// Representa a propriedades de uma pessoa fisíca.
        /// </summary>
        public string? Nome { get; set; }

        public int Idade { get; set; }
        
        /// <summary>
        /// Faz a pessoa se apresentar, passando seu nome e idade.
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade}");
        }
    }
}
