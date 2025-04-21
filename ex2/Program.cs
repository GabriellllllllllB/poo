using System;

class Program
{   
    public static void Main()
    {
        Program p = new Program();
        p.executarcalculadora();
}
    private Calculo calculo = new Calculo();

    public void lervalores()
    {
        Console.Write("Digite o valor A: ");
        calculo.ValorA = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor B: ");
        calculo.ValorB = double.Parse(Console.ReadLine());
    }

    public void executarcalculadora()
    {
        lervalores();

        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine("escolha uma opção:");
            Console.WriteLine("1 - soma");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - multiplicação");
            Console.WriteLine("4 - maior valor");
            Console.WriteLine("5 - soma geral");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    calculo.calcularsoma();
                    calculo.mostrarresultado();
                    break;
                case 2:
                    calculo.calcularsubtracao();
                    calculo.mostrarresultado();
                    break;
                case 3:
                    calculo.calcularmultiplicacao();
                    calculo.mostrarresultado();
                    break;
                case 4:
                    calculo.retornarmaior();
                    break;
                case 5:
                    Console.Write("escreva o valor extra para somar: ");
                    double extra = double.Parse(Console.ReadLine());
                    calculo.somageral(extra);
                    calculo.mostrarresultado();
                    break;
            }
        }
    }
}
