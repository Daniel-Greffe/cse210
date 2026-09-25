using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedido 1: Cliente nos EUA
        Endereco endereco1 = new Endereco("13 Main St", "Seattle", "WA", "USA");
        Cliente cliente1 = new Cliente("John Lemon", endereco1);
        
        Pedido pedido1 = new Pedido(cliente1);
        pedido1.AdicionarProduto(new Produto("Teclado Mecânico", 101, 49.99m, 1));
        pedido1.AdicionarProduto(new Produto("Mouse Sem Fio", 102, 27.49m, 1));
        pedido1.AdicionarProduto(new Produto("Mousepad Gigante", 103, 14.99m, 1));

        // Pedido 2: Cliente fora dos EUA (Brasil)
        Endereco endereco2 = new Endereco("Av. Sulista, 22", "São Paulo", "SP", "Brasil");
        Cliente cliente2 = new Cliente("Maria Eduarda", endereco2);
        
        Pedido pedido2 = new Pedido(cliente2);
        pedido2.AdicionarProduto(new Produto("Monitor 32 Polegadas Dell", 201, 299.90m, 1));
        pedido2.AdicionarProduto(new Produto("Cabo HDMI 4K banhado a ouro", 202, 12.00m, 2));

        // Exibição do Pedido 1
        Console.WriteLine("========================================");
        Console.WriteLine("PEDIDO 1");
        Console.Write(pedido1.ObterEtiquetaEmbalagem());
        Console.WriteLine();
        Console.Write(pedido1.ObterEtiquetaEnvio());
        Console.WriteLine();
        Console.WriteLine($"Custo Total do Pedido: ${pedido1.CalcularCustoTotal():F2}");
        Console.WriteLine("========================================\n");

        // Exibição do Pedido 2
        Console.WriteLine("========================================");
        Console.WriteLine("PEDIDO 2");
        Console.Write(pedido2.ObterEtiquetaEmbalagem());
        Console.WriteLine();
        Console.Write(pedido2.ObterEtiquetaEnvio());
        Console.WriteLine();
        Console.WriteLine($"Custo Total do Pedido: ${pedido2.CalcularCustoTotal():F2}");
        Console.WriteLine("========================================\n");
    }
}