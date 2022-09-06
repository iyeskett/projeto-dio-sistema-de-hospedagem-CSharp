// See https://aka.ms/new-console-template for more information
using projeto_dio_sistema_de_hospedagem_CSharp.Models;


// Cria lista de hóspedes e faz o cadastro
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa pessoa1 = new Pessoa();
Pessoa pessoa2 = new Pessoa();

hospedes.Add(pessoa1);
hospedes.Add(pessoa2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

// Cria uma nova reserva com a suíte e hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValor()}");



