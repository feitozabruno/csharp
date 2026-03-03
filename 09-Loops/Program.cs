Console.WriteLine("=== ESTUDO DE LOOPS EM C# ===\n");

// 1. O laço 'while'
Console.WriteLine("1. Laço 'while':");
int contadorWhile = 3;
while (contadorWhile > 0)
{
    Console.WriteLine($"Contagem regressiva: {contadorWhile}");
    contadorWhile--;
}
Console.WriteLine();

// 2. O laço 'do..while'
Console.WriteLine("2. Laço 'do..while':");
int contadorDo = 0;
do
{
    Console.WriteLine($"Executou pelo menos uma vez! Valor: {contadorDo}");
    contadorDo++;
} while (contadorDo < 0); // A condição é falsa, mas executou antes de checar!
Console.WriteLine();

// 3. O laço 'for'
Console.WriteLine("3. Laço 'for':");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Repetição número {i}");
}
Console.WriteLine();

// 4. Utilizando 'break' e 'continue'
Console.WriteLine("4. Testando 'break' e 'continue':");
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        // Se for par, pula para a próxima iteração ignorando o que tem embaixo
        continue;
    }

    if (i > 7)
    {
        // Se passar de 7, quebra o laço inteiro
        Console.WriteLine("Passou de 7, interrompendo o laço...");
        break;
    }

    Console.WriteLine($"Número ímpar processado: {i}");
}

Console.WriteLine("\n=== FIM DO EXEMPLO ===");