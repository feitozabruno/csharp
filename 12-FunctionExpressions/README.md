# Expressões de Função e Lambdas

Na programação, uma função não é apenas uma "estrutura mágica da linguagem", mas pode ser tratada como um tipo especial de valor.

A sintaxe que usamos anteriormente (declarando métodos dentro de classes ou no escopo principal) é chamada de *Declaração de Função* (Function Declaration):

```csharp
void DizerOla() 
{
  Console.WriteLine("Olá");
}
```

Existe outra sintaxe para criar uma função que é chamada de *Expressão de Função* (Function Expression). No C#, nós fazemos isso usando **Expressões Lambda** (`=>`).

## A Função é um valor (Action e Func)

Para armazenar uma função em uma variável no C#, você não pode simplesmente usar `var` cegamente, pois o C# é fortemente tipado. Você precisa dizer qual é a "assinatura" dessa função. Para isso, o .NET nos dá dois tipos principais:

1. **`Action`**: Para funções que **não retornam nada** (`void`).
2. **`Func`**: Para funções que **retornam um valor**.


Exemplo usando `Action` (Expressão de Função):

```csharp
// Criamos uma função anônima (lambda) e armazenamos na variável 'dizerOla'
Action dizerOla = () => 
{
    Console.WriteLine("Olá");
};

// Executando a função:
dizerOla(); 
```

Como a criação da função acontece no contexto da expressão de atribuição (do lado direito do `=`), isso é uma Expressão de Função. Note que não há um nome após a declaração; funções criadas dessa maneira são *anônimas*.

Exemplo usando `Func` (que recebe dois inteiros e retorna um inteiro):

```csharp
Func<int, int, int> somar = (a, b) => a + b;

int resultado = somar(5, 3); // 8
```

Podemos copiar uma função para outra variável, pois ela é um valor:

```csharp
Action original = () => Console.WriteLine("Teste");
Action copia = original; // Copiamos a referência da função
copia(); // Imprime: Teste
```

## Funções de Retorno de Chamada (Callbacks)

Podemos passar funções como valores e usá-las como parâmetros para outras funções. 

Vamos escrever uma função `Perguntar(pergunta, sim, nao)` com três parâmetros:
* `pergunta`: O texto da pergunta.
* `sim`: A função (Action) a ser executada se a resposta for "S".
* `nao`: A função (Action) a ser executada se a resposta for "N".

```csharp
void Perguntar(string pergunta, Action sim, Action nao) 
{
    Console.WriteLine($"{pergunta} (S/N)");
    string resposta = Console.ReadLine();
    
    if (resposta.ToUpper() == "S") 
        sim();
    else 
        nao();
}

// Passando funções anônimas (lambdas) diretamente na chamada:
Perguntar(
    "Você concorda?",
    () => Console.WriteLine("Você concordou."),
    () => Console.WriteLine("Você cancelou a execução.")
);
```

Os argumentos `sim` e `nao` da função `Perguntar` são chamados de *funções de retorno de chamada* ou apenas *callbacks*. A ideia é que passamos uma função e esperamos que ela seja "chamada de volta" mais tarde, se necessário.

## Declaração vs Expressão (Funções Locais no C#)

Em linguagens dinâmicas, as Declarações de Função sofrem "hoisting" (elevação) e podem ser chamadas antes de serem definidas no código. Expressões de função, por outro lado, só existem após o fluxo de execução passar por elas.

No C#, métodos normais de classe podem ser chamados em qualquer ordem. No entanto, se você estiver escrevendo funções *dentro* de outras funções (para limitar o escopo), o C# oferece as **Funções Locais**:

```csharp
void MeuMetodo()
{
    // 1. Expressão de Função (Lambda): Só pode ser chamada DEPOIS de declarada
    Action lambda = () => Console.WriteLine("Sou uma lambda");
    lambda(); 

    // 2. Função Local (Declaração): Pode ser chamada ANTES de ser escrita no escopo
    FuncaoLocal(); 
    
    void FuncaoLocal() 
    {
        Console.WriteLine("Sou uma função local");
    }
}
```

## Resumo

* Funções são valores. Elas podem ser atribuídas, copiadas ou declaradas em qualquer lugar do código usando os tipos `Action` (para `void`) ou `Func` (com retorno).
* Se a função for criada como parte de uma expressão usando a sintaxe `() => { ... }`, ela é chamada de *Expressão Lambda* (o equivalente no C# à Function Expression).
* Em grande parte das vezes que precisamos declarar uma função auxiliar dentro de um método, uma Função Local é preferível porque é mais legível e flexível. Usamos lambdas/expressões principalmente quando precisamos passar funções como parâmetros (callbacks) ou trabalhar com manipulação de listas (LINQ).