using System;

public class Produto
{
    private string _nome;
    private int _id;
    private decimal _preco;
    private int _quantidade;

    public Produto(string nome, int id, decimal preco, int quantidade)
    {
        _nome = nome;
        _id = id;
        _preco = preco;
        _quantidade = quantidade;
    }

    public decimal CalcularPrecoTotal()
    {
        return _preco * _quantidade;
    }

    public string ObterNome()
    {
        return _nome;
    }

    public int ObterId()
    {
        return _id;
    }
}