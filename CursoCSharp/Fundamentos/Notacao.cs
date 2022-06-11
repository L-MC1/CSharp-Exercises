using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Notacao
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, "inserido").Replace("inserido", " novo nome");
            Console.WriteLine(saudacao);
            Console.WriteLine(saudacao.Length);
        }
    }
}
