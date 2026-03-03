Console.WriteLine("=== ESTUDO DE LISTAS (List<T>) EM C# ===\n");

// 1. Declaração e inicialização
Console.WriteLine("1. Inicializando histórico de aportes:");
List<decimal> aportes = new List<decimal> { 1800.00m, 1800.00m };
Console.WriteLine($"Total de aportes registrados: {aportes.Count}");

// 2. Adicionando e Inserindo
Console.WriteLine("\n2. Registrando novos aportes:");
aportes.Add(1800.00m); // Adiciona no final
aportes.Insert(0, 50.00m); // Insere um pequeno aporte esquecido no início (índice 0)

foreach (decimal valor in aportes)
{
    Console.WriteLine($"+ {valor:C}");
}

// 3. Pesquisando
Console.WriteLine("\n3. Pesquisando na lista:");
decimal valorBuscado = 50.00m;

if (aportes.Contains(valorBuscado))
{
    int posicao = aportes.IndexOf(valorBuscado);
    Console.WriteLine($"O aporte de {valorBuscado:C} foi encontrado no índice {posicao}.");
}

// 4. Removendo itens
Console.WriteLine("\n4. Removendo itens:");
aportes.Remove(50.00m); // Remove o valor específico
Console.WriteLine($"Aporte de {50.00m:C} removido. Aportes restantes: {aportes.Count}");

// 5. Ordenação
Console.WriteLine("\n5. Ordenando a lista:");
aportes.Add(2500.00m); // Adicionando um valor maior para testar a ordenação
aportes.Sort(); // Ordena do menor para o maior
aportes.Reverse(); // Inverte para ficar do maior para o menor

Console.WriteLine("Aportes do maior para o menor:");
foreach (decimal valor in aportes)
{
    Console.WriteLine($"- {valor:C}");
}

Console.WriteLine("\n=== FIM DO EXEMPLO ===");