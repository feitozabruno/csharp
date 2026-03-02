Console.WriteLine("=== ESTUDO DE CONDICIONAIS EM C# ===\n");

Console.Write("Digite a sua idade: ");
string entrada = Console.ReadLine();

// Usando o TryParse que aprendemos anteriormente para garantir a segurança
if (int.TryParse(entrada, out int idade))
{
    // 1. Uso do if, else if e else
    Console.WriteLine("\n1. Teste de if/else:");
    if (idade < 13)
    {
        Console.WriteLine("Você é uma criança.");
    }
    else if (idade < 18)
    {
        Console.WriteLine("Você é um adolescente.");
    }
    else
    {
        Console.WriteLine("Você é um adulto.");
    }

    // 2. Operador Ternário
    Console.WriteLine("\n2. Teste do Operador Ternário (?):");
    string status = (idade >= 18) ? "Maior de idade" : "Menor de idade";
    Console.WriteLine($"Status: {status}");
}
else
{
    // O else captura o cenário de falha (ex: o usuário digitou "abc")
    Console.WriteLine("\nErro: Você não digitou um número válido.");
}

Console.WriteLine("\n=== FIM DO EXEMPLO ===");