Console.WriteLine("=== SIMULADOR FINANCEIRO (ESTUDO DE SWITCH) ===\n");

double saldoPoupanca = 5450.00;
double depositoMensal = 1800.00;

Console.WriteLine("Escolha uma operação:");
Console.WriteLine("1 - Ver Saldo Atual");
Console.WriteLine("2 - Simular rendimento em 1 mês (com depósito)");
Console.WriteLine("3 - Ver regras da Poupança");
Console.WriteLine("4 - Falar com atendente");
Console.Write("Opção: ");

string entrada = Console.ReadLine();

// 1. O switch clássico
Console.WriteLine("\n--- Usando Switch Clássico ---");
switch (entrada)
{
    case "1":
        Console.WriteLine($"Seu saldo atual é: {saldoPoupanca:C}");
        break; // Obrigatório no C#

    case "2":
        double novoSaldo = saldoPoupanca + depositoMensal;
        double rendimentoSimulado = novoSaldo * 0.005; // 0.5% ao mês
        Console.WriteLine($"Após depositar {depositoMensal:C}, seu novo saldo base será {novoSaldo:C}.");
        Console.WriteLine($"O rendimento no próximo mês seria de aprox. {rendimentoSimulado:C}.");
        break;

    case "3": // Agrupando cases vazios
    case "4":
        Console.WriteLine("Transferindo para o menu de atendimento especial...");
        break;

    default:
        Console.WriteLine("Opção inválida. Tente novamente.");
        break;
}

// 2. O Switch Expression (C# moderno)
Console.WriteLine("\n--- Usando Switch Expression (C# 8+) ---");
string statusMensagem = entrada switch
{
    "1" => "Consulta de saldo realizada.",
    "2" => "Simulação concluída com sucesso.",
    "3" or "4" => "Atendimento acionado.", // Outra forma de agrupar no C# moderno
    _ => "Nenhuma ação tomada."
};

Console.WriteLine(statusMensagem);

Console.WriteLine("\n=== FIM DO EXEMPLO ===");