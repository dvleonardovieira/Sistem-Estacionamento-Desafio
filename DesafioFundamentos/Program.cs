using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoPorHora = 5.00m;

Console.WriteLine("===================================");
Console.WriteLine("Seja bem vindo ao Sistemas:");
Console.WriteLine(">>>>>>>>JOE Parking<<<<<<<");
Console.WriteLine($"Valor: ${precoPorHora} por hora");
Console.WriteLine("===================================\n");

//Fazer uma pause, esperar o usuario interagir
Console.WriteLine("Pressione ENTER para continuar...");
Console.ReadLine();

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo (Entrada)");
    Console.WriteLine("2 - Remover veículo (Saida)");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
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
