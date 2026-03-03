# Operadores Lógicos

Existem três operadores lógicos principais clássicos que cobriremos aqui: `||` (OR), `&&` (AND) e `!` (NOT). 

Na programação clássica, e estritamente no C#, os operadores lógicos destinam-se a manipular apenas valores booleanos (`true` ou `false`). 


## || (OR / OU)

O operador "OR" é representado com dois símbolos de linha vertical: `||`.

Se qualquer um de seus argumentos for `true`, ele retorna `true`, caso contrário, retorna `false`. O resultado é sempre `true`, exceto para o caso em que ambos os operandos são `false`.

Existem quatro combinações lógicas possíveis:

```csharp
Console.WriteLine(true || true);   // True
Console.WriteLine(false || true);  // True
Console.WriteLine(true || false);  // True
Console.WriteLine(false || false); // False
```

Na maioria das vezes, o OR `||` é usado em uma instrução `if` para testar se *qualquer* uma das condições fornecidas é verdadeira:

```csharp
int hora = 9;

if (hora < 10 || hora > 18) 
{
    Console.WriteLine("O escritório está fechado.");
}
```

### O mito do "primeiro valor Truthy" no C#

Em algumas linguagens dinâmicas, o operador `||` avalia operandos de diferentes tipos e retorna o primeiro valor verdadeiro (ex: `let nome = null || "Anonimo"`). 

**No C#, isso NÃO é permitido!** Você não pode usar `||` com strings ou números, e ele nunca retornará uma string. Para escolher o primeiro valor não-nulo no C#, usamos um operador diferente chamado *Null Coalescing* (`??`), que veremos no futuro.

### Avaliação de Curto-Circuito (Short-circuit)

Uma característica do operador OR `||` que o C# compartilha com outras linguagens é a avaliação de "curto-circuito".

Isso significa que o `||` processa seus argumentos da esquerda para a direita até que o primeiro valor `true` seja alcançado, e então o valor é retornado imediatamente, sem sequer tocar no outro argumento. A importância desse recurso se torna óbvia se um operando não for apenas um valor, mas uma expressão com um efeito colateral, como uma chamada de função.

## && (AND / E)

O operador AND é representado com dois "e comerciais" `&&`.

Ele retorna `true` se ambos os operandos forem verdadeiros e `false` caso contrário:

```csharp
Console.WriteLine(true && true);   // True
Console.WriteLine(false && true);  // False
Console.WriteLine(true && false);  // False
Console.WriteLine(false && false); // False
```

Exemplo com `if`:

```csharp
int hora = 12;
int minuto = 30;

if (hora == 12 && minuto == 30) 
{
    Console.WriteLine("O horário é 12:30");
}
```

Assim como o OR, o AND também possui avaliação de curto-circuito. Ele avalia os operandos da esquerda para a direita e, se o resultado for `false`, ele para e retorna `false` sem avaliar o restante.

> **A precedência de AND `&&` é maior que a de OR `||`**
> A precedência do operador AND `&&` é maior que a do OR `||`. Portanto, o código `a && b || c && d` é essencialmente o mesmo que se as expressões `&&` estivessem entre parênteses: `(a && b) || (c && d)`.

## ! (NOT / NÃO)

O operador booleano NOT é representado com um sinal de exclamação `!`.

O operador aceita um único argumento e retorna o valor inverso.

```csharp
Console.WriteLine(!true);  // False
Console.WriteLine(!false); // True
```

A precedência do NOT `!` é a mais alta de todos os operadores lógicos, portanto, ele sempre é executado primeiro, antes de `&&` ou `||`.

## Resumo das diferenças para linguagens dinâmicas

* Em C#, você não pode usar `!` em números para checar se são zero (ex: `!0`), nem usar `!!` para converter variáveis para booleanos. O C# exige verificações explícitas como `numero != 0`.
* O uso de `&&` como um "jeito curto de escrever um if" (ex: `(x > 0) && ExecutarAcao()`) não é válido no C#. Use a estrutura `if` tradicional.