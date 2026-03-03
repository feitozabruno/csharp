Console.WriteLine("=== ESTUDO DE EXPRESSÕES DE FUNÇÃO E LAMBDAS EM C# ===\n");

// 1. Armazenando funções em variáveis (Action e Func)
Console.WriteLine("1. Action e Func:");

// Action não retorna nada (void)
Action exibirBoasVindas = () => Console.WriteLine("Seja bem-vindo ao sistema de lambdas!");
exibirBoasVindas();

// Func recebe dois 'int' e retorna um 'int' (o último tipo na lista é sempre o retorno)
Func<int, int, int> multiplicar = (a, b) => a * b;
int resultadoMultiplicacao = multiplicar(4, 5);
Console.WriteLine($"Resultado da multiplicação via Func: {resultadoMultiplicacao}\n");

// 2. Callbacks (Passando funções como argumentos)
Console.WriteLine("2. Funções de Callback:");

void ProcessarPagamento(double valor, Action sucesso, Action<string> falha)
{
    Console.WriteLine($"Iniciando processamento de {valor:C}...");
    if (valor > 0)
    {
        sucesso(); // Chama a função de sucesso
    }
    else
    {
        falha("O valor do pagamento não pode ser zero ou negativo."); // Chama a função de falha passando um argumento
    }
}

// Chamando o método e passando as funções diretamente via lambda expressions
ProcessarPagamento(
    150.00,
    () => Console.WriteLine("Pagamento aprovado com sucesso!"),
    (erro) => Console.WriteLine($"Erro no pagamento: {erro}")
);

// 3. Funções Locais vs Expressões
Console.WriteLine("\n3. Funções Locais vs Lambdas:");

void TestarEscopo()
{
    // A função local pode ser chamada antes de ser declarada
    MinhaFuncaoLocal();

    void MinhaFuncaoLocal()
    {
        Console.WriteLine("Fui chamada via Função Local (Function Declaration).");
    }

    // A lambda só existe a partir desta linha
    Action minhaLambda = () => Console.WriteLine("Fui chamada via Lambda (Function Expression).");
    minhaLambda();
}

TestarEscopo();

Console.WriteLine("\n=== FIM DO EXEMPLO ===");