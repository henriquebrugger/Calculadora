using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== CALCULADORA CIENTÍFICA ===");
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Potência");
            Console.WriteLine("6 - Raiz Quadrada");
            Console.WriteLine("7 - Seno");
            Console.WriteLine("8 - Cosseno");
            Console.WriteLine("9 - Logaritmo");
            Console.WriteLine("0 - Sair");

            Console.Write("Opção: ");
            string input = Console.ReadLine();

            if (input == "0") break;

            if (!int.TryParse(input, out int escolha) || escolha < 0 || escolha > 9)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            Operacoes.Executar(escolha);
        }
    }
}
