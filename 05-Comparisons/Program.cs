Console.WriteLine("=== ESTUDO DE COMPARAÇÕES EM C# ===\n");

// 1. Operadores Matemáticos Básicos e Booleanos
Console.WriteLine("1. Comparações Numéricas:");
Console.WriteLine($"5 é maior que 4? {5 > 4}");
Console.WriteLine($"2 é menor ou igual a 1? {2 <= 1}");
Console.WriteLine($"8 é diferente de 8? {8 != 8}\n");

// 2. Armazenando em variáveis
Console.WriteLine("2. Variáveis Booleanas:");
int idade = 25;
bool maiorDeIdade = idade >= 18;
Console.WriteLine($"A pessoa tem {idade} anos. É maior de idade? {maiorDeIdade}\n");

// 3. Comparação de Strings
Console.WriteLine("3. Comparação de Textos:");
string nome1 = "João";
string nome2 = "João";
string nome3 = "Maria";

Console.WriteLine($"'João' é igual a 'João'? {nome1 == nome2}");
Console.WriteLine($"'João' é igual a 'Maria'? {nome1 == nome3}");

// Para saber quem vem antes no alfabeto:
int ordemAlfabetica = "Ana".CompareTo("Zebra");
// Retorna negativo porque Ana vem ANTES de Zebra
Console.WriteLine($"'Ana' comparada com 'Zebra' retorna: {ordemAlfabetica}\n");

// 4. Tipos Fortes impedem erros (Descomente para ver os erros de compilação)
Console.WriteLine("4. Tipagem Forte do C#:");
Console.WriteLine("No C#, o compilador impede comparações entre tipos diferentes.");
// Console.WriteLine(0 == false); // Erro: Não pode comparar int com bool
// Console.WriteLine("2" > 1);    // Erro: Não pode comparar string com int

Console.WriteLine("\n=== FIM DO EXEMPLO ===");