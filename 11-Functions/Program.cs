Console.WriteLine("=== ESTUDO DE FUNÇÕES (MÉTODOS) EM C# ===\n");

// 1. Chamando uma função sem retorno (void)
Console.WriteLine("1. Função Básica:");
ShowGreeting();
Console.WriteLine();

// 2. Passando argumentos e usando valores padrão
Console.WriteLine("2. Parâmetros e Valores Padrão:");
ShowMessage("Sistema", "Iniciando processamento...");
ShowMessage("Alerta"); // Usa o valor padrão para 'text'
Console.WriteLine();

// 3. Função que retorna um valor
Console.WriteLine("3. Retornando Valores:");
int num1 = 15;
int num2 = 25;
int soma = CalcSum(num1, num2);
Console.WriteLine($"A soma de {num1} e {num2} é: {soma}\n");

// 4. Função como validação (Check)
Console.WriteLine("4. Validação (Single Responsibility):");
int idade = 20;
if (CheckIsAdult(idade))
{
    Console.WriteLine("Acesso liberado.");
}
else
{
    Console.WriteLine("Acesso negado.");
}

Console.WriteLine("\n=== FIM DO EXEMPLO ===");


// ==========================================
// DECLARAÇÃO DAS FUNÇÕES
// ==========================================

// Função simples que não retorna nada
void ShowGreeting()
{
    Console.WriteLine("Olá! Bem-vindo ao sistema.");
}

// Função com parâmetros obrigatórios e opcionais (valor padrão)
void ShowMessage(string from, string text = "Nenhuma mensagem fornecida")
{
    Console.WriteLine($"[{from}] disse: {text}");
}

// Função que realiza um cálculo e DEVE retornar um 'int'
int CalcSum(int a, int b)
{
    return a + b;
}

// Função com responsabilidade única de checar uma regra
bool CheckIsAdult(int age)
{
    // O operador lógico já retorna true ou false automaticamente
    return age >= 18;
}