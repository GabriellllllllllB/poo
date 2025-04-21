class Program
{
    static void Main()
    {
        produto produto = new produto();

        Console.WriteLine("Digite o nome do produto:");
        produto.Nome = Console.ReadLine();
        Console.WriteLine("Digite o preço do produto:");
        produto.Preco = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade do produto:");
        produto.Quantidade = int.Parse(Console.ReadLine());
        produto.adicionarestoque();

        int escolha = 0;

        while (escolha != 4)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Adicionar ao estoque");
            Console.WriteLine("2. Remover do estoque");
            Console.WriteLine("3. Mostrar valor total em estoque");
            Console.WriteLine("4. Mostrar produto");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Digite a quantidade a ser adicionada:");
                    produto.quantidade = int.Parse(Console.ReadLine());
                    produto.adicionarestoque();
                    break;
                case 2:
                    Console.WriteLine("Digite a quantidade a ser removido:");
                    produto.quantidade = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    produto.valortotalemestoque();
                    break;
                case 4:
                    produto.mostrarproduto();
                    break;
            }
        }

    }
}