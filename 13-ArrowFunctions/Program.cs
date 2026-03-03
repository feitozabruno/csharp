Console.WriteLine("=== ESTUDO DE EXPRESSÕES LAMBDA (ARROW FUNCTIONS) EM C# ===\n");

// 1. Lambda Básica com múltiplos parâmetros
Func<int, int, int> somar = (a, b) => a + b;
Console.WriteLine("1. Múltiplos parâmetros:");
Console.WriteLine($"A soma de 10 e 15 é: {somar(10, 15)}\n");

// 2. Lambda com um único parâmetro (sem parênteses)
Func<int, int> dobrar = n => n * 2;
Console.WriteLine("2. Parâmetro único:");
Console.WriteLine($"O dobro de 8 é: {dobrar(8)}\n");

// 3. Lambda sem parâmetros
Action saudar = () => Console.WriteLine("Olá! Esta é uma lambda sem parâmetros.");
Console.WriteLine("3. Nenhum parâmetro:");
saudar();
Console.WriteLine();

// 4. Lambda de múltiplas linhas (Statement Lambda)
Func<double, double, double> calcularHipotenusa = (catetoA, catetoB) =>
{
    double somaDosQuadrados = (catetoA * catetoA) + (catetoB * catetoB);
    return Math.Sqrt(somaDosQuadrados); // Exige o "return" por causa das chaves
};

Console.WriteLine("4. Lambda de múltiplas linhas:");
Console.WriteLine($"A hipotenusa de um triângulo 3 e 4 é: {calcularHipotenusa(3, 4)}\n");

Console.WriteLine("=== FIM DO EXEMPLO ===");