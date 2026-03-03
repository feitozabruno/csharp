# Funções de Seta (Expressões Lambda)

Existe uma sintaxe muito simples e concisa para criar funções, que geralmente é melhor do que as Expressões de Função tradicionais. Em JavaScript elas são chamadas de "arrow functions" (funções de seta). 

No C#, essa mesma estrutura é conhecida como **Expressão Lambda**. A sintaxe utiliza o operador `=>` (lido como "vai para" ou "goes to"):

```csharp
Func<Tipo1, Tipo2, TipoRetorno> func = (arg1, arg2) => expressao;
```

Isso cria uma função que aceita os argumentos definidos, avalia a expressão no lado direito e retorna seu resultado. Em outras palavras, é uma versão mais curta de um método completo.


## Sintaxe Básica

Vamos ver um exemplo concreto de uma função que soma dois números:

```csharp
Func<int, int, int> somar = (a, b) => a + b;

Console.WriteLine( somar(1, 2) ); // 3
```

Como você pode ver, `(a, b) => a + b` significa uma função que aceita dois argumentos chamados `a` e `b`. Durante a execução, ela avalia a expressão `a + b` e retorna o resultado.

Existem algumas variações interessantes dependendo da quantidade de parâmetros:

* **Um único argumento:** Se tivermos apenas um argumento, os parênteses ao redor dos parâmetros podem ser omitidos, tornando isso ainda mais curto.
    ```csharp
    Func<int, int> dobrar = n => n * 2;
    Console.WriteLine( dobrar(3) ); // 6
    ```

* **Nenhum argumento:** Se não houver argumentos, os parênteses ficam vazios, mas devem estar presentes.
    ```csharp
    Action dizerOla = () => Console.WriteLine("Hello!");
    dizerOla();
    ```

As funções de seta (lambdas) são muito convenientes para ações simples de uma linha, quando estamos com preguiça de escrever muitas palavras.

## Funções Lambda de Múltiplas Linhas

As funções que vimos até agora eram muito simples: elas pegavam os argumentos da esquerda do `=>`, avaliavam e retornavam a expressão do lado direito.

Às vezes, precisamos de uma função mais complexa, com várias expressões e instruções. Nesse caso, podemos fechá-las entre chaves. 

A principal diferença é que as chaves exigem um `return` explícito dentro delas para retornar um valor (assim como uma função regular faz).

```csharp
Func<int, int, int> somarComplexo = (a, b) => 
{  
    // a chave abre uma função multilinha
    int resultado = a + b;
    return resultado; // se usarmos chaves, precisamos de um "return" explícito
};

Console.WriteLine( somarComplexo(1, 2) ); // 3
```

## Resumo

As funções de seta (lambdas) são úteis para ações simples, especialmente para *one-liners* (funções de uma linha). Elas vêm em dois sabores:

1. **Sem chaves:** `(...args) => expressao`. O lado direito é uma expressão: a função a avalia e retorna o resultado. Os parênteses podem ser omitidos se houver apenas um único argumento (ex: `n => n * 2`).
2. **Com chaves:** `(...args) => { corpo }`. Os colchetes (chaves) nos permitem escrever várias instruções dentro da função, mas precisamos de um `return` explícito para retornar algo.