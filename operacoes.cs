using System;

public static class Operacoes
{
    public static void Executar(int escolha)
    {
        double a = 0, b = 0;

        try
        {
            if (escolha >= 1 && escolha <= 5)
            {
                Console.Write("Digite o primeiro número: ");
                a = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                b = double.Parse(Console.ReadLine());
            }
            else if (escolha == 6 || escolha == 9)
            {
                Console.Write("Digite o número: ");
                a = double.Parse(Console.ReadLine());
            }
            else if (escolha == 7 || escolha == 8)
            {
                Console.Write("Digite o ângulo em graus: ");
                a = double.Parse(Console.ReadLine());
                a = a * Math.PI / 180; // converte para radianos
            }
            else
            {
                Console.WriteLine("Operação inválida.");
                return;
            }
        }
        catch
        {
            Console.WriteLine("Entrada inválida. Use apenas números.");
            return;
        }

        switch (escolha)
        {
            case 1:
                Console.WriteLine($"Resultado: {a + b}");
                break;
            case 2:
                Console.WriteLine($"Resultado: {a - b}");
                break;
            case 3:
                Console.WriteLine($"Resultado: {a * b}");
                break;
            case 4:
                if (b == 0)
                    Console.WriteLine("Erro: divisão por zero.");
                else
                    Console.WriteLine($"Resultado: {a / b}");
                break;
            case 5:
                Console.WriteLine($"Resultado: {Math.Pow(a, b)}");
                break;
            case 6:
                if (a < 0)
                    Console.WriteLine("Erro: raiz quadrada de número negativo não é definida.");
                else
                    Console.WriteLine($"Resultado: {Math.Sqrt(a)}");
                break;
            case 7:
                Console.WriteLine($"Resultado: {Math.Sin(a)}");
                break;
            case 8:
                Console.WriteLine($"Resultado: {Math.Cos(a)}");
                break;
            case 9:
                if (a <= 0)
                    Console.WriteLine("Erro: logaritmo indefinido para zero ou números negativos.");
                else
                    Console.WriteLine($"Resultado: {Math.Log(a)}");
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
        }
    }
}
