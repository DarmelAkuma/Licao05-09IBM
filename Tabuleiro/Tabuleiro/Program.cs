using System;

namespace Tabuleiro {
    class Program {
        static void Main(string[] args) {
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Qual a dimensão do tabuleiro?");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine((n * n) - ((n * n) / 2) + " Casas Brancas E " + ((n * n) / 2) + " Casas Pretas ");
            }
        }
    }
}