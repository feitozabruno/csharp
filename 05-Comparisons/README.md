# Comparações

Conhecemos muitos operadores de comparação da matemática. No C#, eles são escritos assim:

* Maior/menor que: `a > b`, `a < b`.
* Maior/menor que ou iguais: `a >= b`, `a <= b`.
* Igual: `a == b`. Por favor, note que o sinal de igualdade duplo `==` significa o teste de igualdade, enquanto um único `a = b` significa uma atribuição.
* Diferente: Na matemática a notação é ≠, mas no código é escrito como `a != b`.

Neste artigo, veremos como o C# lida com essas comparações e por que ele é considerado mais seguro que linguagens dinâmicas.


## Booleano é o resultado

Todos os operadores de comparação retornam um valor booleano:

* `true` -- significa "sim", "correto" ou "a verdade".
* `false` -- significa "não", "errado" ou "não é a verdade".

Por exemplo:

```csharp
Console.WriteLine( 2 > 1 );  // True (correto)
Console.WriteLine( 2 == 1 ); // False (errado)
Console.WriteLine( 2 != 1 ); // True (correto)
```

Um resultado de comparação pode ser atribuído a uma variável, assim como qualquer valor:

```csharp
bool result = 5 > 4; // atribui o resultado da comparação
Console.WriteLine( result ); // True
```

## Comparação de Strings

Para ver se uma string é maior que a outra, linguagens dinâmicas usam a ordem "de dicionário" ou "lexicográfica". Em outras palavras, as strings são comparadas letra por letra. 

**No C#, existe uma grande diferença aqui!**
O C# não permite o uso dos operadores matemáticos `>` ou `<` para comparar strings. Se você tentar escrever `"Z" > "A"`, o código simplesmente não vai compilar.

Para comparar quem vem primeiro na ordem alfabética no C#, usamos o método `.CompareTo()`:

```csharp
// Retorna 1 se for maior, -1 se for menor, 0 se for igual
int resultado = "Z".CompareTo("A"); 
```

No entanto, o teste de igualdade (`==` e `!=`) funciona perfeitamente para checar se duas strings contêm exatamente o mesmo texto.

## Comparação de tipos diferentes

Quando comparam valores de tipos diferentes, linguagens dinâmicas convertem os valores para números. 

**No C#, isso é terminantemente proibido.** O compilador protege você de comparar laranjas com maçãs.

```csharp
// EM OUTRAS LINGUAGENS:
// Console.WriteLine( "2" > 1 ); (A string "2" vira o número 2 e retorna true)

// NO C#:
// Console.WriteLine( "2" > 1 ); // ERRO DE COMPILAÇÃO!
```

Para fazer essa comparação no C#, você precisa ser explícito e converter a string para número antes (usando `int.Parse()`, por exemplo).

## Igualdade Estrita vs. Igualdade Comum

Em linguagens dinâmicas, um operador de igualdade estrita `===` verifica a igualdade sem conversão de tipo. 

**O C# não possui o operador `===`!**
Como o C# já possui tipagem forte, o operador comum `==` já age de forma estrita na maioria dos casos. Se você tentar comparar `0 == false` no C#, o código não irá compilar, pois são tipos completamente diferentes (`int` e `bool`).

## Resumo

* Todos os operadores de comparação retornam um valor booleano (`true` ou `false`).
* Strings não podem ser comparadas com `>` ou `<` no C#; usamos `.CompareTo()` para ordem alfabética e `==` para igualdade de texto.
* O C# não faz conversão automática de tipos (coerção) durante comparações numéricas. Você não pode comparar uma `string` com um `int` sem converter explicitamente.
* Por ser fortemente tipado, o C# não precisa do operador de igualdade estrita (`===`). O operador comum (`==`) já garante a integridade e impede a comparação entre tipos incompatíveis, bloqueando bizarrices como comparar `null` com `0`.