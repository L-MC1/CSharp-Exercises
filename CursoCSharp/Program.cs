using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e constantes - Fundamentos", Variaveis.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolaçãp - Fundamentos", Interpolacao.Executar},
                {"Notação ponto - Fundamentos", Notacao.Executar},
                {"Lendo dados no console - Fundamentos", Lendodados.Executar},
                {"Formatando números - Fundamentos", FormatNum.Executar},
                {"Conversçao de valores - Fundamentos", Conversao.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}