using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço Desconto
            var preco = 220.0;
            var imposto = 55;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço do produto com desconto fica em: {0}", totalComDesconto);

            // IMC
            double peso = 70.0;
            double altura = 1.75;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}.");

            // Número Par/Impar
            int par = 1212;
            int impar = 333;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
