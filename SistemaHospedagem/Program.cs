using SistemaHospedagem.Models;
using SistemaHospedagem.Services;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

try
{
    Console.WriteLine("=========== HOTEL MARICA ===========");
    Console.Write("Digite o tipo da suíte: ");
    string tipoSuite = Console.ReadLine();
    Console.Write("Digite a capacidade de hospedes da suíte: ");
    int capacidade = int.Parse(Console.ReadLine());
    Console.Write("Digite o valor da diária da suíte: ");
    decimal diariaSuite = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Digite a capacidade de da suíte: ");
    Suite suite = new Suite(tipoSuite, capacidade, diariaSuite);

    Console.Clear();

    Console.Write("Digite a quantidade de hospedes: ");
    int n = int.Parse(Console.ReadLine());
    List<Pessoa> hospedes = new List<Pessoa>();

    for (int i = 0; i < n; i++)
    {
        Console.Clear();
        Console.Write($"Digite o nome do {i + 1} hospede: ");
        string nome = Console.ReadLine();
        Console.Write($"Digite o sobrenome do {i + 1} hospede: ");
        string sobrenome = Console.ReadLine();
        Pessoa pessoa = new Pessoa(nome, sobrenome);
        hospedes.Add(pessoa);
    }

    Reserva reserva = new Reserva(diasReservados: 10);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);

    Console.WriteLine();
    Console.WriteLine($"Suíte: {reserva.Suite}");
    Console.WriteLine($"Quantidade de Hospedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor da hospedagem: {reserva.CalcularValorDiario()}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message );
}