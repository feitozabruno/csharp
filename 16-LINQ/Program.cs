Console.WriteLine("=== ESTUDO DE LINQ EM C# ===\n");

// Simulando um histórico de movimentações financeiras
// O saldo base é 5450.00 e temos aportes mensais de 1800.00
List<decimal> movimentacoes = new List<decimal>
{
    5450.00m,   // Saldo inicial salvo
    1800.00m,   // Aporte Mês 1
    1800.00m,   // Aporte Mês 2
    -150.00m,   // Gasto imprevisto
    1800.00m    // Aporte Mês 3
};

Console.WriteLine("1. Agregações Básicas (Sum, Max, Average):");
Console.WriteLine($"Total acumulado na conta: {movimentacoes.Sum():C}");
Console.WriteLine($"Maior valor movimentado: {movimentacoes.Max():C}");
Console.WriteLine($"Média por movimentação: {movimentacoes.Average():C}\n");

Console.WriteLine("2. Filtragem com Where:");
// Pegamos apenas os depósitos (valores maiores que zero)
List<decimal> apenasAportes = movimentacoes.Where(m => m > 0).ToList();

foreach (var aporte in apenasAportes)
{
    Console.WriteLine($"+ Entrada identificada: {aporte:C}");
}

Console.WriteLine("\n3. Transformação com Select:");
// Vamos simular quanto cada aporte isolado renderia com 1% ao mês
var simulacaoRendimentos = apenasAportes.Select(a => a * 1.01m).ToList();

for (int i = 0; i < simulacaoRendimentos.Count; i++)
{
    Console.WriteLine($"Aporte {i + 1} com 1% de rendimento: {simulacaoRendimentos[i]:C}");
}

Console.WriteLine("\n4. Buscas com FirstOrDefault e Any:");
bool teveSaque = movimentacoes.Any(m => m < 0);
Console.WriteLine($"Houve algum saque ou gasto neste período? {teveSaque}");

// Busca o primeiro saque registrado. Se não houver, retorna 0 (padrão do decimal)
decimal primeiroSaque = movimentacoes.FirstOrDefault(m => m < 0);
if (primeiroSaque != 0)
{
    Console.WriteLine($"O primeiro saque registrado foi de: {primeiroSaque:C}");
}

Console.WriteLine("\n=== FIM DO EXEMPLO ===");