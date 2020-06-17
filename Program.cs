using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Por favor, insira sua altura: ");
            bool alturabool = Double.TryParse(Console.ReadLine(), out altura);
            Console.Write("Agora insira seu sexo (F para feminino e M para masculino): ");
            string sexo = Console.ReadLine().ToUpper();
            if (!alturabool || altura < 0 || sexo != "F" && sexo != "M")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido.");
                Console.ResetColor();
                Environment.Exit(-1);
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (sexo == "M")
                {
                    double resultadomasculino = altura * 72.7 - 58;
                    Console.WriteLine($"Seu peso ideal é {resultadomasculino:N1} kg."); 
                }
                else if (sexo == "F")
                {
                    double resultadofeminino = altura * 62.1 - 44.7;
                    Console.WriteLine($"Seu peso ideal é {resultadofeminino:N1} kg.");
                }
                Console.ResetColor();
            }
            Console.ReadKey();

        }
    }
}
