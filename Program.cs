using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;


List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine(" ** Desafio: Construindo um sistema de hospedagem de um hotel no C# ** ");
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Quantidade de Hóspedes");
    Console.WriteLine("2 - Valor Final da Diária");
    Console.WriteLine("3 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            break;

        case "2":
           Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
            break;

        case "3":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
