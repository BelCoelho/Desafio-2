using System.Text;
using DesafioProjetoHospedagem.Models;
using Microsoft.VisualBasic;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
Suite suite = new Suite();

List<string> hospedes = new List<string>();

Pessoa p = new Pessoa();




string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Registrar Hóspede");
    Console.WriteLine("2 - Reservar Suíte");
    Console.WriteLine("3 - Lista de Hóspedes");
    Console.WriteLine("5 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Nome do hospede: ");
            string nome = Console.ReadLine();
            hospedes.Add(nome);
            break;

        case "2":
            Console.WriteLine("Reservar Suíte");

            
          

            break;


        case "3":
            Console.WriteLine("Lista de Hóspedes");
            for (int contador = 0;contador < hospedes.Count; contador++)
            {
                Console.WriteLine($"Posição N° {contador + 1}° - {hospedes[contador]}");
            }
            break;

        case "5":
            Console.WriteLine("Encerrando");
            exibirMenu = false;
            break;

    }

    Console.WriteLine("\nPressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("\nO programa se encerrou");




/*

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");*/