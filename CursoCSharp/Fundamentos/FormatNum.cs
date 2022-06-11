using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatNum
    {
        public static void Executar()
        {
            double valor = 15.751;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.###"));

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C3", cultura));
            //CultureInfo cultura = new CultureInfo("en-US");

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
