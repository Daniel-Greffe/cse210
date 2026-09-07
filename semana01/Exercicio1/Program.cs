using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nQual é o seu primeiro nome? ");
        string nome = Console.ReadLine();

        Console.Write("\nQual é o seu sobrenome? ");
        string segundonome = Console.ReadLine();

        Console.WriteLine($"\nSeu nome é {segundonome}, {nome} {segundonome}.");
    }
}