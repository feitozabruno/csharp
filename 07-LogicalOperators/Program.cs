Console.WriteLine("=== ESTUDO DE OPERADORES LÓGICOS EM C# ===\n");

// 1. Operador OR (||)
Console.WriteLine("1. Operador OR (||):");
bool temPassaporte = false;
bool temIdentidade = true;
bool podeViajar = temPassaporte || temIdentidade;
Console.WriteLine($"Tem passaporte ou identidade? {podeViajar}\n");

// 2. Operador AND (&&)
Console.WriteLine("2. Operador AND (&&):");
int idade = 20;
bool temHabilitacao = true;
bool podeDirigir = idade >= 18 && temHabilitacao;
Console.WriteLine($"Maior de idade E tem habilitação? {podeDirigir}\n");

// 3. Operador NOT (!)
Console.WriteLine("3. Operador NOT (!):");
bool fimDeSemana = false;
Console.WriteLine($"É dia útil? {!fimDeSemana}\n");

// 4. Demonstração de Curto-Circuito
Console.WriteLine("4. Avaliação de Curto-Circuito:");

// Função auxiliar apenas para demonstrar o curto-circuito
bool MetodoLento()
{
    Console.WriteLine("    [!] MetodoLento() foi executado!");
    return true;
}

Console.WriteLine("  Teste com OR (||) onde o primeiro é TRUE:");
// Como o primeiro é true, o C# não precisa rodar o MetodoLento() para saber o resultado.
bool testeOr = true || MetodoLento();
Console.WriteLine("  Nenhuma mensagem do MetodoLento apareceu acima.\n");

Console.WriteLine("  Teste com AND (&&) onde o primeiro é FALSE:");
// Como o primeiro é false, o C# sabe que o resultado final só pode ser false, e ignora o MetodoLento().
bool testeAnd = false && MetodoLento();
Console.WriteLine("  Nenhuma mensagem do MetodoLento apareceu acima.\n");

Console.WriteLine("=== FIM DO EXEMPLO ===");