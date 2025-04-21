class Program
{
    static void Main()
    {
        Console.WriteLine("escreva o numero da vaga:");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("escreva o tipo de veículo(Carro, Moto ou Caminhão):");
        string tipo = Console.ReadLine();

        VagaEstacionamento vaga = new VagaEstacionamento(numero, tipo);
        bool sair = false;
        while (!sair)
        {
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - ocupar vaga");
            Console.WriteLine("2 - liberar vaga");
            Console.WriteLine("3 - alterar tipo de veiculo");
            Console.WriteLine("4 - exibir nformações");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    vaga.ocuparvaga();
                    break;
                case "2":
                    vaga.liberarvaga();
                    break;
                case "3":
                    Console.Write("escreva o novo tipo de veículo: ");
                    string novoTipo = Console.ReadLine();
                    vaga.alterartipoveiculo(novoTipo);
                    break;
                case "4":
                    vaga.exibirinformacoes();
                    break;
            }
        }
    }
}
