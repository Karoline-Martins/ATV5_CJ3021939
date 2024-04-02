using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirMenu();

            int opcao = LerOpcaoMenu();

            switch (opcao)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 5:
                    Exercicio5();
                    break;
                case 6:
                    Exercicio6();
                    break;
                case 7:
                    Exercicio7();
                    break;
                case 0:
                    Console.WriteLine("Encerrando o programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void ExibirMenu()
    {
        Console.WriteLine("Escolha um exercício:");
        Console.WriteLine("1. Imprimir números de 1 até o número lido");
        Console.WriteLine("2. Imprimir números pares de 1 até o número lido");
        Console.WriteLine("3. Imprimir números pares de 1000 até o número lido (menor que 1000)");
        Console.WriteLine("4. Imprimir números positivos até a soma atingir ou ultrapassar 200");
        Console.WriteLine("5. Imprimir divisores de um número");
        Console.WriteLine("6. Informar o maior e o menor número dentre 10 digitados");
        Console.WriteLine("7. Imprimir a soma dos números pares e ímpares até encontrar zero");
        Console.WriteLine("0. Sair");
    }

    static int LerOpcaoMenu()
    {
        Console.Write("Escolha uma opção: ");
        return int.Parse(Console.ReadLine());
    }

    static void Exercicio1()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void Exercicio2()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    static void Exercicio3()
    {
        Console.Write("Digite um número inteiro menor que 1000: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1000; i <= numero; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    static void Exercicio4()
    {
        int soma = 0;

        while (soma < 200)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                soma += numero;
                Console.WriteLine("Soma atual dos positivos: " + soma);
            }
        }
    }

    static void Exercicio5()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Divisores de " + numero + ":");

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    static void Exercicio6()
    {
        int maior = int.MinValue;
        int menor = int.MaxValue;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Digite o " + i + "º número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > maior)
            {
                maior = numero;
            }

            if (numero < menor)
            {
                menor = numero;
            }
        }

        Console.WriteLine("Maior número digitado: " + maior);
        Console.WriteLine("Menor número digitado: " + menor);
    }

    static void Exercicio7()
    {
        int somaPares = 0;
        int somaImpares = 0;

        int numero;

        do
        {
            Console.Write("Digite um número (0 para sair): ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                if (numero % 2 == 0)
                {
                    somaPares += numero;
                }
                else
                {
                    somaImpares += numero;
                }
            }
        } while (numero != 0);

        Console.WriteLine("Soma dos números pares: " + somaPares);
        Console.WriteLine("Soma dos números ímpares: " + somaImpares);
    }
}