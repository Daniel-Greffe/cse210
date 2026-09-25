using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> listaVideos = new List<Video>();

        // Vídeo 1
        Video video1 = new Video("Aprenda a programar em 10 Minutos", "Dev Fácil", 600);
        video1.AdicionarComentario(new Comentario("Carlos Silva", "Excelente explicação, muito top!"));
        video1.AdicionarComentario(new Comentario("Ana Maria Braga", "Ajudou demais na minha prova."));
        video1.AdicionarComentario(new Comentario("Lucas Lima", "Poderia fazer um vídeo sobre C#?"));
        listaVideos.Add(video1);

        // Vídeo 2
        Video video2 = new Video("Tutorial Completo de Git e GitHub", "Código Aberto", 1250);
        video2.AdicionarComentario(new Comentario("Beatriz Lima", "Melhor tutorial que já assisti"));
        video2.AdicionarComentario(new Comentario("João Gomes", "Fiquei com dúvida no comando git rebase."));
        video2.AdicionarComentario(new Comentario("Maria Gadu", "Incrível! Parabéns pelo conteúdo."));
        listaVideos.Add(video2);

        // Vídeo 3
        Video video3 = new Video("Como Criar Diagramas com Mermaid", "Tech Dicas", 480);
        video3.AdicionarComentario(new Comentario("Rafael Santos", "Facilitou muito meus trabalhos do curso"));
        video3.AdicionarComentario(new Comentario("Juliana Alves", "Não sabia que o Mermaid fazia isso, muito legal!"));
        video3.AdicionarComentario(new Comentario("Thiago Oliveira", "Muito fácil, obrigado pelo vídeo!"));
        listaVideos.Add(video3);

        // Vídeo 4
        Video video4 = new Video("Introdução ao Design de Software", "EducaInfo", 900);
        video4.AdicionarComentario(new Comentario("Mariana Rocha", "Abstração e Encapsulamento explicados da melhor forma."));
        video4.AdicionarComentario(new Comentario("Gabriel Ramos", "Aula nota 10!"));
        video4.AdicionarComentario(new Comentario("Camila Torres", "Assisti até o final"));
        listaVideos.Add(video4);

        // Iteração e exibição de todos os vídeos e comentários
        foreach (Video video in listaVideos)
        {
            video.ExibirDetalhes();
        }
    }
}