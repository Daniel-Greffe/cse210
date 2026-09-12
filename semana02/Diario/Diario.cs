using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{
    public List<Registro> _registros = new List<Registro>();

    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro);
    }

    public void ExibirTodos()
    {
        if (_registros.Count == 0)
        {
            Console.WriteLine("\nO diário está vazio");
            return;
        }
        Console.WriteLine("---- REGISTROS DO DIÁRIO ----");
        foreach (Registro registro in _registros)
        {
            registro.Exibir();
        }
    }

    public void SalvarNoArquivo(string arquivo)
    {
        using (StreamWriter arquivoSaida = new StreamWriter(arquivo))
        {
            foreach (Registro registro in _registros)
            {
                arquivoSaida.WriteLine($"{registro._data}~|~{registro._textoPergunta}~|~{registro._textoResposta}");
            }
        }
        Console.WriteLine($"\nDiário salvo com sucesso!");
    }

    public void CarregarDoArquivo(string arquivo)
    {
        if (!File.Exists(arquivo))
        {
            Console.WriteLine("\nArquivo não encontrado, tente um nome de arquivo válido.");
            return;
        }
        _registros.Clear();
        string[] linhas = File.ReadAllLines(arquivo);

        foreach (string linha in linhas)
        {
            string[] partes = linha.Split("~|~");
            if (partes.Length == 3)
            {
                Registro registro = new Registro(partes[0], partes[1], partes[2]);
                _registros.Add(registro);
            }
        }
        Console.WriteLine("\nDiário carregado com sucesso!");
    }
}