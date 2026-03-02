Console.WriteLine("=== ESTUDO DE CONVERSÃO DE TIPOS EM C# ===\n");

// 1. Conversão Implícita e Explícita (Casting)
Console.WriteLine("1. Casting Numérico:");
int numeroInt = 150;
double numeroDouble = numeroInt; // Implícita (int cabe perfeitamente em um double)
Console.WriteLine($"Conversão Implícita (int para double): {numeroDouble}");

double outroDouble = 9.99;
int outroInt = (int)outroDouble; // Explícita (forçando a perda das casas decimais)
Console.WriteLine($"Conversão Explícita (double para int): {outroInt} (perdeu o .99)\n");

// 2. Conversão para String (.ToString)
Console.WriteLine("2. Conversão para String:");
bool estaEstudando = true;
string textoEstudo = estaEstudando.ToString();
Console.WriteLine($"De booleano para string: \"{textoEstudo}\"\n");

// 3. Conversão de String para Número (Parse e TryParse)
Console.WriteLine("3. Conversão de String para Número:");
string textoNumero = "2026";
int ano = int.Parse(textoNumero);
Console.WriteLine($"Parse bem-sucedido: O ano é {ano}");

// Exemplo de TryParse (Seguro contra erros)
string textoInvalido = "C# é muito legal";
Console.WriteLine($"\nTentando converter o texto \"{textoInvalido}\" para número...");

bool conseguiuConverter = int.TryParse(textoInvalido, out int numeroConvertido);

if (conseguiuConverter)
{
    Console.WriteLine($"Sucesso! Número: {numeroConvertido}");
}
else
{
    Console.WriteLine("Falha na conversão. O C# evitou que o programa quebrasse!");
    Console.WriteLine($"Valor padrão retornado na variável 'out': {numeroConvertido}\n");
}

Console.WriteLine("=== FIM DO EXEMPLO ===");