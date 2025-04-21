using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class funcionario
{
    public string NomeCompleto{  get; set; }
    public double Salario{ get; set; }

    public virtual void exibirdados()
    {
        string[] nomes = NomeCompleto.Split(' ');
        string ultimosobrenome = nomes[nomes.Length - 1].ToUpper();

        Console.WriteLine("sobrenome do funcionario: " + ultimosobrenome);
        Console.WriteLine("salario: " + Salario.ToString("C", new CultureInfo("pt-BR")));
    }
}
