using System.Text;
using DesafioProjetoHospedagem.Models;
using Microsoft.VisualBasic;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
Suite suite = new Suite();
List<string> hospedes = new List<string>();
Reserva reserva= new Reserva();

//Cadastra a suite
reserva.CadastrarSuite();

//Console.Clear();


//Cadastra os hospedes
string s = "s";

while (s == "s")
{
Console.WriteLine("\nAdicionar Hospede");

reserva.CadastrarHospedes();

Console.WriteLine("Adicionar outro hóspede? Precione 's' se SIM e 'n' para NÃO");
s = Console.ReadLine();
}

//Pergunta a quantidade de dias reservados e traz o valor da hospedagem

decimal diasReservados;
Console.WriteLine("Quantos dias de reserva: ");
diasReservados = Convert.ToDecimal(Console.ReadLine());
            
decimal valor = 0;
valor = diasReservados * suite.ValorDiaria;
Console.WriteLine($"{diasReservados} x {suite.ValorDiaria}");

Console.WriteLine($"O valor da diária é: {valor}");


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