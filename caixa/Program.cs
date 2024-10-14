using System;

namespace CaixaEletronico
{
	class Program
	{
		static void Main(string[] args)
		{
			double saldo = 1000.0; //saldo inicial
			string nomeTitular = "Márcia"; //nome do titular
			bool continuar = true;
			while (continuar)
			{
				Console.WriteLine("\nBem-vindo ao Caixa Eletrônico");
				Console.WriteLine("1. Depósito");
				Console.WriteLine("2. Saque");
				Console.WriteLine("3. Extrato");
				Console.WriteLine("4. Transferência");
				Console.WriteLine("5. Sair");
				Console.Write("Escolha uma opção: ");
				string opcao = Console.ReadLine();
				switch (opcao)
				{
					case "1": //deposito
						Console.Write("Digite o valor do depósito: ");
						double valorDeposito = Convert.ToDouble(Console.ReadLine());
						saldo += valorDeposito;
						Console.WriteLine($"Depósito de {valorDeposito:C} realizado com sucesso!");
						break;
					case "2": //saque
						Console.Write("Digite o valor do saque: ");
						double valorSaque = Convert.ToDouble(Console.ReadLine());
						if (valorSaque <= saldo)
						{
							saldo -= valorSaque;
							Console.WriteLine($"Saque de {valorSaque:C} realizado com sucesso!");
						}
						else
						{
							Console.WriteLine("Saldo insuficiente para realizar o saque.");
						}

						break;
					case "3": //extrato
						Console.WriteLine($"\nExtrato de {nomeTitular}:");
						Console.WriteLine($"Saldo atual: {saldo:C}");
						break;
					case "4": //transferencia
						Console.Write("Digite o valor da transferência: ");
						double valorTransferencia = Convert.ToDouble(Console.ReadLine());
						if (valorTransferencia <= saldo)
						{
							saldo -= valorTransferencia;
							Console.WriteLine($"Transferência de {valorTransferencia:C} realizada com sucesso!");
						}
						else
						{
							Console.WriteLine("Saldo insuficiente para realizar a transferência.");
						}

						break;
					case "5": //sair
						continuar = false;
						Console.WriteLine("Saindo... ");
						break;
					default:
						Console.WriteLine("Opção inválida, tente novamente.");
						break;
				}
			}
		}
	}
}