using System;

class Program
{
    static void Main(string[] args)
    {

        Random geradorRandomico = new Random();
        int numeroAleatorio = geradorRandomico.Next(1, 101);

        int palpite;

        Console.Write("\nAdvinhe um número entre 1 e 100!\n");
        
        do
        {
            Console.Write("\nQual é o seu palpite? ");
            palpite = int.Parse(Console.ReadLine());

            if (numeroAleatorio > palpite)
            {
                Console.WriteLine("Diga um número maior");
            }
            else if (numeroAleatorio< palpite)
            {
                Console.WriteLine("Diga um número menor");
            }
            else
            {
                Console.WriteLine("\nVocê adivinhou!!!\n");
            }

        } while (palpite != numeroAleatorio);
    }
}