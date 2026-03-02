Console.WriteLine("=== ESTUDO DE TIPOS DE DADOS EM C# ===\n");

// 1. Tipos Numéricos
int numeroInteiro = 42;
double numeroQuebrado = 3.14159;
decimal valorMonetario = 199.99m; // O sufixo 'm' indica que é um decimal

Console.WriteLine("1. Números:");
Console.WriteLine($"Inteiro: {numeroInteiro}");
Console.WriteLine($"Double: {numeroQuebrado}");
Console.WriteLine($"Decimal (Dinheiro): {valorMonetario:C}\n");

// Comportamento especial do Double (NaN e Infinity)
double divisaoPorZero = 1.0 / 0.0;
double erroMatematico = 0.0 / 0.0;
Console.WriteLine($"Divisão por zero em double gera: {divisaoPorZero}");
Console.WriteLine($"Zero dividido por zero gera: {erroMatematico}\n");

// 2. String e Char
string saudacao = "Olá";
char pontuacao = '!';
string interpolacao = $"{saudacao}, Mundo{pontuacao}";

Console.WriteLine("2. Textos:");
Console.WriteLine(interpolacao + "\n");

// 3. Boolean
bool chovendo = false;
bool sol = true;
bool condicao = 10 > 5;

Console.WriteLine("3. Booleanos:");
Console.WriteLine($"Está chovendo? {chovendo}");
Console.WriteLine($"Está sol? {sol}");
Console.WriteLine($"Dez é maior que cinco? {condicao}\n");

// 4. Null e Nullable Types
string textoNulo = null; // Strings são tipos de referência, aceitam null naturalmente
int? numeroDesconhecido = null; // O '?' permite que um int receba null

Console.WriteLine("4. Valores Nulos:");
Console.WriteLine($"O número desconhecido tem valor? {numeroDesconhecido.HasValue}\n");

// 5. Verificando Tipos
Console.WriteLine("5. Verificação de Tipos:");
Console.WriteLine($"O tipo de 'saudacao' é: {saudacao.GetType()}");
Console.WriteLine($"'chovendo' é um boolean? {chovendo is bool}");

Console.WriteLine("\n=== FIM DO EXEMPLO ===");