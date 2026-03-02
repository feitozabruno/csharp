using System;

Console.WriteLine("=== ESTUDO DE VARIÁVEIS EM C# ===\n");

// 1. Declaração básica e atribuição
string message;
message = "Olá, C#! Essa é a minha primeira variável.";
Console.WriteLine("1. Variável básica:");
Console.WriteLine(message);
Console.WriteLine();

// 2. Declaração e atribuição na mesma linha (Múltiplos tipos)
string user = "John";
int age = 25;
Console.WriteLine("2. Múltiplas variáveis:");
Console.WriteLine($"Usuário: {user}"); // Usando interpolação com o símbolo $
Console.WriteLine($"Idade: {age}");
Console.WriteLine();

// 3. A palavra-chave 'var' (Inferência de tipo)
var favoriteLanguage = "C#"; // O compilador entende que é uma string
var year = 2026;             // O compilador entende que é um int
Console.WriteLine("3. Usando 'var':");
Console.WriteLine($"Linguagem favorita: {favoriteLanguage}, Ano: {year}");
Console.WriteLine();

// 4. Reatribuindo valores (A analogia da caixa)
Console.WriteLine("4. Reatribuindo valores:");
string greeting = "Bom dia!";
Console.WriteLine($"Antes: {greeting}");

greeting = "Boa noite!"; // O valor antigo "Bom dia!" é descartado
Console.WriteLine($"Depois: {greeting}");
Console.WriteLine();

// 5. Constantes
const string MyBirthday = "18.04.1982";
Console.WriteLine("5. Constantes:");
Console.WriteLine($"Meu aniversário é imutável: {MyBirthday}");

// Descomente a linha abaixo para ver o erro de compilação acontecer na prática:
// MyBirthday = "01.01.2001";

Console.WriteLine("\n=== FIM DO EXEMPLO ===");