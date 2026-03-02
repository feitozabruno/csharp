# Tipos de Dados no C#

Um valor em programação é sempre de um certo tipo. Por exemplo, uma string ou um número.

Diferente de linguagens que possuem "tipagem dinâmica" (onde as variáveis não são vinculadas a nenhum tipo específico), o **C#** é uma linguagem de **tipagem estática e forte**. Isso significa que existem vários tipos de dados básicos, e quando você declara uma variável, ela fica permanentemente vinculada àquele tipo.

## Números

O C# é rigoroso com números e oferece tipos diferentes para necessidades específicas:

* **`int`**: Para números inteiros (ex: `1`, `-42`, `1000`).
* **`double`** e **`float`**: Para números de ponto flutuante (com casas decimais).
* **`decimal`**: Para valores monetários e cálculos financeiros de alta precisão.

Existem muitas operações para números, ex: multiplicação `*`, divisão `/`, adição `+`, subtração `-`, e assim por diante.

Além dos números regulares, em tipos de ponto flutuante (`double` e `float`) existem os chamados "valores numéricos especiais": `Infinity`, `-Infinity` e `NaN`.
* `Infinity` representa o infinito matemático, que é um valor especial maior que qualquer número.
* `NaN` representa um erro computacional. É o resultado de uma operação matemática incorreta ou indefinida.

## Números Gigantes

Para a maioria dos propósitos, os tamanhos numéricos padrão são suficientes, mas às vezes precisamos de inteiros realmente grandes, ex: para criptografia.

No C#:
* **`long`**: Armazena inteiros de 64 bits (muito maiores que o `int` padrão).
* **`System.Numerics.BigInteger`**: Para números gigantescos que não cabem nem no limite do `long`.

## String e Char

Uma string deve ser cercada por aspas. No C#, usamos especificamente aspas duplas `"..."`.

```csharp
string str = "Olá, C#!";
```

Para incorporar variáveis e expressões em uma string (interpolação), o C# usa o caractere `$` antes da string e as chaves `{}` dentro dela:

```csharp
string name = "John";
Console.WriteLine($"Hello, {name}!"); // Hello, John!
```

**Atenção ao tipo Char!**
Diferente de linguagens que tratam caracteres individuais apenas como strings curtas, o **C# possui o tipo `char`**. Ele representa exatamente um único caractere e deve ser envolvido por **aspas simples** (`' '`):

```csharp
char letra = 'A';
```

## Boolean (tipo lógico)

O tipo booleano tem apenas dois valores: `true` e `false`.

Este tipo é comumente usado para armazenar valores sim/não: `true` significa "sim, correto", e `false` significa "não, incorreto". Valores booleanos também vêm como resultado de comparações.

## O valor "null"

O valor especial `null` representa "nada", "vazio" ou "valor desconhecido".

No C#, `null` significa que uma variável não aponta para nenhum objeto na memória. Por padrão, tipos de valor (como `int` ou `bool`) não podem receber `null`. Se você precisar que eles aceitem "vazio", você deve usar tipos anuláveis (Nullable types), adicionando uma interrogação `?` após o tipo:

```csharp
int? age = null; // a idade é desconhecida no momento
```

## Valores não atribuídos

Em linguagens dinâmicas, existe o significado especial de "valor não atribuído" (frequentemente chamado de `undefined`).

No C#, **não existe o conceito de `undefined`**. O compilador do C# é extremamente rígido e obriga você a atribuir um valor inicial a variáveis locais antes de tentar utilizá-las, evitando uma classe inteira de bugs de execução.

## Descobrindo o tipo

O operador `typeof` retorna o tipo do operando e é útil quando queremos fazer uma verificação rápida.

No C#, lidamos com a verificação de tipos de três maneiras principais:

1.  **`typeof(NomeDoTipo)`**: Retorna informações sobre o tipo em tempo de compilação.
2.  **`.GetType()`**: Um método que você pode chamar em qualquer objeto para descobrir seu tipo exato durante a execução do programa.
3.  **Operador `is`**: Verifica se uma variável é de um determinado tipo, retornando um booleano (`true` ou `false`).