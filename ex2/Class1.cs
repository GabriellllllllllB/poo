using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculo
{
    private double Resultado;
    public double ValorA { get; set; }
    public double ValorB { get; set; }

    public void calcularsoma()
    {
        Resultado = ValorA + ValorB;
    }

    public void calcularsubtracao()
    {
        Resultado = ValorA - ValorB;
    }

    public void calcularmultiplicacao()
    {
        Resultado = ValorA * ValorB;
    }

    public void retornarmaior()
    {
        if (ValorA > ValorB)
        {
            Console.WriteLine("Maior valor entre A e B: " + ValorA);
        }
        else if (ValorB > ValorA)
        {
            Console.WriteLine("Maior valor entre A e B: " + ValorB);
        }
        else
        {
            Console.WriteLine("Valor A e B são iguais: " + ValorA);
        }
    }

    public void somageral(double valor)
    {
        Resultado = ValorA + ValorB + valor;
    }

    public void mostrarresultado()
    {
        Console.WriteLine(Resultado);
    }
}

