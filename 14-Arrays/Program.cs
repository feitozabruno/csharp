Console.WriteLine("=== ESTUDO DE ARRAYS EM C# ===\n");

// 1. Declaração e Inicialização
Console.WriteLine("1. Gerenciando um histórico fixo de aportes:");

// Um array fixo contendo os aportes mensais
decimal[] depositosMensais = { 1800.00m, 1800.00m, 1800.00m, 1800.00m };
decimal saldoAtual = 5450.00m;

Console.WriteLine($"Saldo base inicial: {saldoAtual:C}");

// 2. Iterando com foreach e acessando a propriedade Length
Console.WriteLine($"\nProcessando {depositosMensais.Length} meses de depósito...");

foreach (decimal deposito in depositosMensais)
{
    saldoAtual += deposito;
}

Console.WriteLine($"Saldo após todos os aportes: {saldoAtual:C}");

// 3. Acessando índices diretos e reversos
Console.WriteLine("\n3. Acessando índices:");
Console.WriteLine($"Primeiro depósito registrado: {depositosMensais[0]:C}");
Console.WriteLine($"Último depósito registrado (usando ^1): {depositosMensais[^1]:C}");

// 4. Comparação de Arrays
Console.WriteLine("\n4. Comparando Arrays:");
decimal[] projecaoFutura = { 1800.00m, 1800.00m, 1800.00m, 1800.00m };

// Compara a referência na memória (Sempre False para arrays diferentes)
bool comparacaoIncorreta = depositosMensais == projecaoFutura;

// Compara o conteúdo item por item (True)
bool comparacaoCorreta = depositosMensais.SequenceEqual(projecaoFutura);

Console.WriteLine($"São o mesmo objeto na memória? (==) : {comparacaoIncorreta}");
Console.WriteLine($"Possuem os mesmos valores? (SequenceEqual) : {comparacaoCorreta}");

Console.WriteLine("\n=== FIM DO EXEMPLO ===");