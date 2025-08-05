using System;

public class Program
{
    public static void Main(string[] args)
    {
        int codigo;
        double preco;
        int quantidade;
        Console.WriteLine("Produtos: 1 - Cachorro Quente");
        Console.WriteLine("Produtos: 2 - X-Salada");
        Console.WriteLine("Produtos: 3 - X-Bacon");
        Console.WriteLine("Produtos: 4 - Torrada Simples");
        Console.WriteLine("Produtos: 5 - Refrigerante");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Digite o codigo do produto(1 a 5): ");
        codigo = int.Parse(Console.ReadLine());
        Console.WriteLine("Agora digite a quantidade que você quer: ");
        quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine("-----------------------------");

        if (codigo == 1)
        {
            preco = quantidade * 4.00;
            Console.WriteLine($"Total: R$: {preco:F2}" );
        }
        else if(codigo == 2)
        {
            preco = quantidade * 4.50;
            Console.WriteLine($"Total: R$ {preco:F2}");
        }
        else if(codigo == 3)
        {
            preco = quantidade * 5.00;
            Console.WriteLine($"Total: R$ {preco:F2}");
        }
        else if(codigo == 4)
        {
            preco = quantidade * 2;
            Console.WriteLine($"Total: R$ {preco:F2}");
        }
        else if (codigo == 5)
        {
            preco = quantidade * 1.50;
            Console.WriteLine($"Total: R$ {preco:F2}");
        }
        else
        {
            Console.WriteLine("Código inválido!");
        }
    }
}