using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class gerente : funcionario
{
    public string Departamento { get; set; }

    public override void exibirdados()
    {
        base.exibirdados();

        Console.WriteLine("departamento: " + Departamento);

        if (Salario > 10000)
        {
            Console.WriteLine("status: alta gestão");
        }
    }
}
