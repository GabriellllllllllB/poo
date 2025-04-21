class Program
{
    static void Main()
    {
        Console.WriteLine("cadastro de funcionario ou gerente:");
        Console.WriteLine("digite 1 para funcionário ou 2 para gerente:");
        string opcao = Console.ReadLine();

        if (opcao == "1")
        {
            funcionario f = new funcionario();

            Console.Write("escreva o nome completo: ");
            f.NomeCompleto = Console.ReadLine();

            Console.Write("escreva o salário: ");
            f.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("dados do funcionario:");
            f.exibirdados();
        }
        else if (opcao == "2")
        {
            gerente g = new gerente();

            Console.Write("escreva o nome completo: ");
            g.NomeCompleto = Console.ReadLine();

            Console.Write("escreva o salário: ");
            g.Salario = double.Parse(Console.ReadLine());

            Console.Write("escreva o departamento: ");
            g.Departamento = Console.ReadLine();

            Console.WriteLine("dados do gerente:");
            g.exibirdados();
        }
    }
}