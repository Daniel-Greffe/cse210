/*===================================================================================
  DEMONSTRAÇÃO DE CRIATIVIDADE:
 * 1. Biblioteca de Escrituras: O programa carrega uma lista com várias escrituras 
     diferentes e seleciona uma aleatoriamente a cada execução do programa.
 * 2. Contador de Progresso: Exibe em tempo real a quantidade de palavras que ainda 
     permanecem visíveis para que o usuário acompanhe o progresso da memorização.
  ===================================================================================*/

using System;
using System.Collections.Generic;

namespace MemorizadorEscrituras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Escritura> bibliotecaEscrituras = new List<Escritura>
            {
                new Escritura(
                    new Referencia("Provérbios", 3, 5, 6),
                    "Confia no Senhor de todo o teu coração, e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas."
                ),
                new Escritura(
                    new Referencia("João", 3, 16),
                    "Porque Deus amou o mundo de tal maneira, que deu o seu Filho Unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna."
                ),
                new Escritura(
                    new Referencia("Helamã", 5, 12),
                    "E agora, meus filhos, lembrai-vos, lembrai-vos de que é sobre a rocha de nosso Redentor, que é Cristo, o Filho de Deus, que deveis construir os vossos alicerces; para que, quando o diabo lançar a fúria de seus ventos, sim, seus dardos no torvelinho, sim, quando todo o seu granizo e violenta tempestade vos açoitarem, isso não tenha poder para vos arrastar ao abismo da miséria e angústia sem fim, por causa da rocha sobre a qual estais edificados, que é um alicerce seguro; e se os homens edificarem sobre esse alicerce, não cairão."
                ),
                new Escritura(
                    new Referencia("2 Néfi", 2, 25),
                    "Adão caiu para que os homens existissem; e os homens existem para que tenham alegria."
                )
            };

            Random random = new Random();
            int indiceAleatorio = random.Next(bibliotecaEscrituras.Count);
            Escritura escrituraSelecionada = bibliotecaEscrituras[indiceAleatorio];

            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("        PRÁTICA DE MEMORIZAÇÃO DE ESCRITURAS      ");
                Console.WriteLine($"      [Palavras restantes para ocultar: {escrituraSelecionada.ObterQuantidadePalavrasVisiveis()}]");
                Console.WriteLine("==================================================");
                Console.WriteLine(escrituraSelecionada.ObterTexto());
                Console.WriteLine("--------------------------------------------------");

                if (escrituraSelecionada.EstaCompletamenteOculta())
                {
                    Console.WriteLine("\nEscritura concluída com sucesso!");
                    break;
                }

                Console.WriteLine("\nPressione [ENTER] para continuar ou digite 'sair' para encerrar:");
                string entrada = Console.ReadLine()?.Trim().ToLower();

                if (entrada == "sair")
                {
                    break;
                }

                escrituraSelecionada.OcultarPalavrasAleatorias(2);
            }
        }
    }
}