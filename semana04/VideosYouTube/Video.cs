using System;
using System.Collections.Generic;

public class Video
{
    private string _titulo;
    private string _autor;
    private int _duracao;
    private List<Comentario> _comentarios;

    public Video(string titulo, string autor, int duracao)
    {
        _titulo = titulo;
        _autor = autor;
        _duracao = duracao;
        _comentarios = new List<Comentario>();
    }

    public void AdicionarComentario(Comentario novoComentario)
    {
        _comentarios.Add(novoComentario);
    }

    public int ObterQuantidadeComentarios()
    {
        return _comentarios.Count;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine("========================================");
        Console.WriteLine($"Título: {_titulo}");
        Console.WriteLine($"Autor: {_autor}");
        Console.WriteLine($"Duração: {_duracao} segundos");
        Console.WriteLine($"Número de Comentários: {ObterQuantidadeComentarios()}");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Comentários:");

        foreach (Comentario comentario in _comentarios)
        {
            Console.WriteLine($" - {comentario.ObterTextoFormatado()}");
        }

        Console.WriteLine("========================================\n");
    }
}