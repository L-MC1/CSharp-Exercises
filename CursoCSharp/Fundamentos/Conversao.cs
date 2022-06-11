using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversao
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 89.51;
            int notaInt = (int)nota;
            Console.WriteLine($"Nota inteira: {notaInt} ", notaInt);

            Console.WriteLine("Digite sua idade:");
            string idadeS = Console.ReadLine();
            int idadeI = int.Parse(idadeS);
            Console.WriteLine("idade inserida: {0}", idadeI);

            idadeI = Convert.ToInt32(idadeS);
            Console.WriteLine("Resultado: {0}", idadeI);

            Console.WriteLine("Digite um numero:");
            string palavras = Console.ReadLine();
            int numero;
            int.TryParse(palavras, out numero);
            Console.WriteLine("Resultado: {0}", numero);

            //mais simples
            Console.WriteLine("Digite outro numero:");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado: {0}", numero2);
        }
    }
}
