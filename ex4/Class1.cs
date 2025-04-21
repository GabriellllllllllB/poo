public class VagaEstacionamento
{
    private int numeroVaga;
    private bool ocupada;
    private string tipoVeiculo;
    public VagaEstacionamento(int numero, string tipo)
    {
        if (!TipoValido(tipo))
        {
            Console.WriteLine("veiculo invalido");
            tipoVeiculo = "Carro";
        }
        else
        {
            tipoVeiculo = tipo;
        }

        numeroVaga = numero;
        ocupada = false;
    }
    public int NumeroVaga
    {
        get { return numeroVaga; }
    }
    public bool Ocupada
    {
        get { return ocupada; }
        private set { ocupada = value; }
    }
    public string TipoVeiculo
    {
        get { return tipoVeiculo; }
        private set
        {
            if (TipoValido(value))
            {
                tipoVeiculo = value;
            }
        }
    }
    public void ocuparvaga()
    {
        Ocupada = true;
        Console.WriteLine("vaga ocupada.");
    }
    public void liberarvaga()
    {
        Ocupada = false;
        Console.WriteLine("vaga liberada.");
    }
    public void alterartipoveiculo(string novoTipo)
    {
        if (Ocupada)
        {
            Console.WriteLine("a vaga está ocupada, não é possível alterar.");
            return;
        }

        if (TipoValido(novoTipo))
        {
            TipoVeiculo = novoTipo;
            Console.WriteLine("tipo de veículo alterado.");
        }
        else
        {
            Console.WriteLine("tipo inválido.");
        }
    }

    public void exibirinformacoes()
    {
        string status;

        if (Ocupada)
        {
            status = "ocupada";
        }
        else
        {
            status = "livre";
        }
        Console.WriteLine($"Vaga {NumeroVaga} | Tipo permitido: {TipoVeiculo} | Status: {status}");
    }
    private bool TipoValido(string tipo)
    {
        return tipo == "Carro" || tipo == "Moto" || tipo == "Caminhão";
    }
}
