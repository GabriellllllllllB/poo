using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int quantidade;
    public int Quantidadetotal { get; private set; }

    public int Quantidade
    {
        set { quantidade = value; }
    }

    public void adicionarestoque()
    {
        Quantidadetotal = quantidade + Quantidadetotal;
        Console.WriteLine("Estoque aumentado");
    }
    public void removerestoque(int valor)
    {
        if (valor > 0)
        {
            Quantidadetotal = Quantidadetotal - valor;
            Console.WriteLine("Estoque diminuido");
        }
        else
        {
            Console.WriteLine("Estoque insuficiente");
        }
    }
    public void valortotalemestoque()
    {
        double valortotal = Preco * Quantidadetotal;
        Console.WriteLine("Valor total em estoque: " + valortotal.ToString("F2"));
    }

    public void mostrarproduto()
    {
        Console.WriteLine("Nome do produto: " + Nome);
        Console.WriteLine("Preço do produto: " + Preco.ToString("F2"));
        Console.WriteLine("Quantidade total do produto: " + Quantidadetotal);
    }

}