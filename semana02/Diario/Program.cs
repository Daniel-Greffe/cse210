using System;

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();
        GeradorDePerguntas gerador = new GeradorDePerguntas();

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Adicionar registro");
            Console.WriteLine("2. Exibir todos os registros");
            Console.WriteLine("3. Salvar diário em arquivo");
            Console.WriteLine("4. Carregar diário de arquivo");
            Console.WriteLine("5. Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    string pergunta = gerador.ObterPerguntaAleatoria();
                    Console.WriteLine($"\nPergunta: {pergunta}");
                    Console.Write("Digite sua resposta: ");
                    string resposta = Console.ReadLine();
                    string data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    Registro novoRegistro = new Registro(data, pergunta, resposta);
                    diario.AdicionarRegistro(novoRegistro);
                    break;

                case "2":
                    diario.ExibirTodos();
                    break;

                case "3":
                    Console.Write("Digite o nome do arquivo para salvar: ");
                    string nomeArquivoSalvar = Console.ReadLine();
                    diario.SalvarNoArquivo(nomeArquivoSalvar);
                    break;

                case "4":
                    Console.Write("Digite o nome do arquivo para carregar: ");
                    string nomeArquivoCarregar = Console.ReadLine();
                    diario.CarregarDoArquivo(nomeArquivoCarregar);
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
        }
    }
}