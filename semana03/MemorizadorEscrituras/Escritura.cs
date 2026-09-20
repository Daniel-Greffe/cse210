using System;
using System.Collections.Generic;
using System.Linq;

namespace MemorizadorEscrituras
{
    public class Escritura
    {
        private Referencia _referencia;
        private List<Palavra> _palavras;

        public Escritura(Referencia referencia, string texto)
        {
            _referencia = referencia;
            _palavras = new List<Palavra>();

            string[] palavrasMatriz = texto.Split(' ');
            foreach (string palavraTexto in palavrasMatriz)
            {
                _palavras.Add(new Palavra(palavraTexto));
            }
        }

        public void OcultarPalavrasAleatorias(int numeroParaOcultar)
        {
            Random random = new Random();

            for (int i = 0; i < numeroParaOcultar; i++)
            {
                if (_palavras.Count == 0) break;
                
                int indiceAleatorio = random.Next(_palavras.Count);
                _palavras[indiceAleatorio].Ocultar();
            }
        }

        public string ObterTexto()
        {
            List<string> palavrasFormatadas = new List<string>();
            foreach (Palavra palavra in _palavras)
            {
                palavrasFormatadas.Add(palavra.ObterTexto());
            }

            return $"{_referencia.ObterTexto()}\n\n{string.Join(" ", palavrasFormatadas)}";
        }

        public bool EstaCompletamenteOculta()
        {
            return _palavras.All(p => p.EstaOculta());
        }

        // Método para o desafio de criatividade: Contagem de palavras restantes
        public int ObterQuantidadePalavrasVisiveis()
        {
            return _palavras.Count(p => !p.EstaOculta());
        }
    }
}