# Operadores Básicos e Matemática

Conhecemos muitos operadores da escola. Eles são coisas como adição `+`, multiplicação `*`, subtração `-`, e assim por diante.

Neste capítulo, vamos focar em como o C# lida com esses operadores na programação.

## Termos: "unário", "binário", "operando"

Antes de prosseguirmos, vamos entender uma terminologia comum.

* **Operando** -- é sobre o que os operadores são aplicados. Por exemplo, na multiplicação de `5 * 2` existem dois operandos: o operando esquerdo é `5` e o direito é `2`.
* Um operador é **unário** se ele tiver um único operando. Por exemplo, a negação unária `-` inverte o sinal de um número.
* Um operador é **binário** se ele tiver dois operandos. O mesmo sinal de menos existe na forma binária para subtrair valores (ex: `y - x`).

## Matemática Básica

As seguintes operações matemáticas são suportadas:
* Adição `+`
* Subtração `-`
* Multiplicação `*`
* Divisão `/`
* Resto (Módulo) `%`

As quatro primeiras são diretas, mas o operador `%` e a exponenciação merecem atenção especial.

### Resto %

O operador de resto `%`, apesar de sua aparência, não está relacionado a porcentagens. O resultado de `a % b` é o resto da divisão inteira de `a` por `b`.

Por exemplo, `5 % 2` resulta em `1`, porque 5 dividido por 2 dá 2, com resto 1.

### Exponenciação

Em linguagens como o JavaScript, o operador de exponenciação `a ** b` eleva `a` à potência de `b`. 

**No C#, o operador `**` NÃO existe!** Para elevar um número a uma potência, utilizamos a classe matemática nativa do C#, chamada `Math`:

```csharp
double resultado = Math.Pow(2, 3); // 2³ = 8
```

## Concatenação de Strings com o + binário

Normalmente, o operador `+` soma números. Mas, se o `+` binário for aplicado a strings, ele as mescla (concatena).

Se qualquer um dos operandos for uma string, o outro será convertido em uma string também.

```csharp
Console.WriteLine("1" + 2); // Resultado será a string "12"
Console.WriteLine(2 + "1"); // Resultado será a string "21"
```

*Nota: Em linguagens dinâmicas, operadores como `-` ou `/` tentam converter strings para números automaticamente. No C#, tentar fazer `"6" / "2"` gerará um erro de compilação, pois o C# não faz conversões matemáticas implícitas com textos.*

## Precedência de Operadores

Se uma expressão tiver mais de um operador, a ordem de execução é definida por sua *precedência*, ou seja, a ordem de prioridade padrão dos operadores.


Assim como na escola, a multiplicação na expressão `1 + 2 * 2` deve ser calculada antes da adição. Os parênteses anulam qualquer precedência, então se não estivermos satisfeitos com a ordem padrão, podemos usá-los para alterá-la (ex: `(1 + 2) * 2`).

## Atribuição e Modificação no Local

A atribuição `=` também é um operador, e possui uma precedência muito baixa. 

Frequentemente precisamos aplicar um operador a uma variável e armazenar o novo resultado nessa mesma variável. Podemos encurtar isso usando os operadores de "modificar e atribuir", como `+=` e `*=`:

```csharp
int n = 2;
n += 5; // agora n = 7 (o mesmo que n = n + 5)
n *= 2; // agora n = 14 (o mesmo que n = n * 2)
```

## Incremento / Decremento

Aumentar ou diminuir um número em um está entre as operações numéricas mais comuns. Por isso, existem operadores especiais para isso:

* **Incremento `++`**: aumenta uma variável em 1.
* **Decremento `--`**: diminui uma variável em 1.

Os operadores `++` e `--` podem ser colocados antes ou depois de uma variável:
* **Forma de sufixo (Postfix):** Quando o operador vai depois da variável (ex: `counter++`).
* **Forma de prefixo (Prefix):** Quando o operador vai antes da variável (ex: `++counter`).

Ambas aumentam a variável em 1, mas há uma diferença crucial no valor que elas *retornam* no momento da execução: a forma de prefixo retorna o novo valor, enquanto a forma de sufixo retorna o valor antigo (antes do incremento).

Exemplo de Prefixo (Prefix):
```csharp
int counter = 1;
int a = ++counter; 
// O C# primeiro soma 1 ao counter, e DEPOIS entrega o valor para 'a'. 
// a = 2, counter = 2
```

Exemplo de Sufixo (Postfix):
```csharp
int counter = 1;
int a = counter++; 
// O C# entrega o valor atual do counter para 'a', e DEPOIS soma 1 ao counter.
// a = 1, counter = 2
```

Para fins de legibilidade, aconselhamos um estilo de "uma linha -- uma ação", evitando colocar incrementos complexos dentro de outras expressões matemáticas.