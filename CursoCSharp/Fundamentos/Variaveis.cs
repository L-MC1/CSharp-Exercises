using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Variaveis
    {
        public static void Executar()
        {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio *raio;
            Console.WriteLine("A área é " + area);

            //Tipos internos

            bool VouF = true;
            Console.WriteLine(VouF);

            byte numeroB = 45;
            Console.WriteLine(numeroB);

            sbyte numeroB2 = sbyte.MinValue;
            Console.WriteLine(numeroB2);

            short numeroInt0 = short.MaxValue;
            Console.WriteLine(numeroInt0);

            int numeroInt1 = int.MinValue;
            Console.WriteLine(numeroInt1);

            uint numeroInt2 = uint.MaxValue;
            Console.WriteLine(numeroInt2);

            long numeroInt3 = long.MinValue;
            Console.WriteLine(numeroInt3);

            ulong numeroInt4 = ulong.MaxValue;
            Console.WriteLine(numeroInt4);

            float numeroFloat = 12.56f;
            Console.WriteLine(numeroFloat);

            double numeroDouble = 12.56;
            Console.WriteLine(numeroDouble);

            decimal numeroDecimal = decimal.MaxValue;
            Console.WriteLine(numeroDecimal);

            char letra = 'a';
            Console.WriteLine(letra);

            string texto = "texto exemplo";
            Console.WriteLine(texto);
        }
    }
}
