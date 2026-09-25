using System;
using System.Collections.Generic;
using System.Text;

public class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public decimal CalcularCustoTotal()
    {
        decimal totalProdutos = 0;

        foreach (Produto produto in _produtos)
        {
            totalProdutos += produto.CalcularPrecoTotal();
        }

        decimal taxaEnvio = _cliente.MoraNosEua() ? 5.00m : 35.00m;

        return totalProdutos + taxaEnvio;
    }

    public string ObterEtiquetaEmbalagem()
    {
        StringBuilder etiqueta = new StringBuilder();
        etiqueta.AppendLine("ETIQUETA DE EMBALAGEM:");

        foreach (Produto produto in _produtos)
        {
            etiqueta.AppendLine($" - Item: {produto.ObterNome()} (ID: {produto.ObterId()})");
        }

        return etiqueta.ToString();
    }

    public string ObterEtiquetaEnvio()
    {
        StringBuilder etiqueta = new StringBuilder();
        etiqueta.AppendLine("ETIQUETA DE ENVIO:");
        etiqueta.AppendLine($"Cliente: {_cliente.ObterNome()}");
        etiqueta.AppendLine(_cliente.ObterEndereco().ObterEnderecoCompleto());

        return etiqueta.ToString();
    }
}