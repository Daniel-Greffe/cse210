using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        int numeroEscolha;

        do
        {
            Console.Write("\nDigite um número, digite 0 para sair: ");

            string resposta = Console.ReadLine();
            numeroEscolha = int.Parse(resposta);

            if (numeroEscolha != 0)
            {
                numeros.Add(numeroEscolha);
            }

        } while (numeroEscolha != 0);

        int soma = 0;
        foreach (int numero in numeros)
        {
            soma += numero;
        }

        Console.WriteLine($"\nA soma é: {soma}\n");


        float media = ((float)soma) / numeros.Count;
        Console.WriteLine($"\nA média é: {media}\n");

        int maior = numeros[0];

        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
                maior = numero;
            }
        }

        Console.WriteLine($"\nO maior valor é: {maior}\n");
    }
}