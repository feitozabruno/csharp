Console.WriteLine("=== ESTUDO DE OPERADORES BÁSICOS EM C# ===\n");

// 1. Matemática Básica e Resto (%)
int a = 10;
int b = 3;
Console.WriteLine("1. Matemática Básica:");
Console.WriteLine($"Adição: {a + b}");
Console.WriteLine($"Divisão inteira: {a / b}"); // Em C#, divisão de int por int retorna int!
Console.WriteLine($"Resto da divisão ({a} % {b}): {a % b}\n");

// 2. Exponenciação (Math.Pow)
double baseNum = 2;
double expoente = 3;
Console.WriteLine("2. Exponenciação:");
Console.WriteLine($"2 elevado a 3 é: {Math.Pow(baseNum, expoente)}\n");

// 3. Concatenação vs Soma
Console.WriteLine("3. Concatenação com +:");
Console.WriteLine("Texto " + 1 + 2); // Concatena tudo: Texto 12
Console.WriteLine(1 + 2 + " Texto"); // Soma primeiro, depois concatena: 3 Texto
Console.WriteLine();

// 4. Modificação no local
Console.WriteLine("4. Modificação no Local (+=, *=):");
int valor = 5;
Console.WriteLine($"Valor inicial: {valor}");
valor += 5; // valor = valor + 5
Console.WriteLine($"Após += 5: {valor}");
valor *= 2; // valor = valor * 2
Console.WriteLine($"Após *= 2: {valor}\n");

// 5. Incremento: Prefixo vs Sufixo
Console.WriteLine("5. Incremento (Prefixo vs Sufixo):");

int contador1 = 1;
int resultadoSufixo = contador1++;
Console.WriteLine($"Sufixo (counter++): Resultado recebeu {resultadoSufixo}, e o contador virou {contador1}");

int contador2 = 1;
int resultadoPrefixo = ++contador2;
Console.WriteLine($"Prefixo (++counter): Resultado recebeu {resultadoPrefixo}, e o contador virou {contador2}");

Console.WriteLine("\n=== FIM DO EXEMPLO ===");