# LINQ (Language Integrated Query)

Quando trabalhamos com coleções de dados (como `Array` ou `List<T>`), frequentemente precisamos filtrar itens, transformar os dados ou calcular totais. 

O **LINQ** é uma tecnologia nativa do .NET que estende essas coleções com dezenas de métodos poderosos. Para utilizá-lo, você deve sempre importar o namespace no topo do seu arquivo:

```csharp
using System.Linq;
```



## 1. Filtragem (`Where`)

O método `.Where()` é usado para filtrar uma coleção com base em uma condição. Ele percorre cada item e retorna apenas aqueles que satisfazem a expressão Lambda (onde a condição for `true`).

*Equivalente em linguagens dinâmicas: `filter`.*

```csharp
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };

// Retorna apenas os números pares
var pares = numeros.Where(n => n % 2 == 0);
```

## 2. Transformação (`Select`)

O método `.Select()` é usado para transformar (ou projetar) cada elemento de uma coleção em um novo formato ou valor. O tamanho da coleção resultante será sempre o mesmo da original, mas os dados estarão modificados.

*Equivalente em linguagens dinâmicas: `map`.*

```csharp
List<decimal> valores = new List<decimal> { 100.00m, 200.00m };

// Aplica um rendimento de 5% em cada valor
var valoresComRendimento = valores.Select(v => v * 1.05m);
```

## 3. Buscas e Verificações (`FirstOrDefault` e `Any`)

Quando precisamos encontrar um item específico ou apenas saber se algo existe na coleção, o LINQ nos salva de escrever laços `for` inteiros:

* **`.FirstOrDefault(condicao)`:** Retorna o primeiro item que bater com a condição. Se não encontrar nada, retorna o valor padrão do tipo (ex: `null` para objetos, `0` para números), evitando que o programa quebre.
* **`.Any(condicao)`:** Retorna um booleano (`true` ou `false`) indicando se *pelo menos um* item na lista satisfaz a condição.

```csharp
List<string> usuarios = new List<string> { "Ana", "Carlos", "Beatriz" };

string usuarioComC = usuarios.FirstOrDefault(u => u.StartsWith("C")); // "Carlos"
bool temMaria = usuarios.Any(u => u == "Maria"); // false
```

## 4. Agregações (`Sum`, `Max`, `Min`, `Average`)

O LINQ fornece atalhos matemáticos imediatos para calcular dados em coleções numéricas, substituindo a necessidade de iterar manualmente para somar valores.

*Equivalente em linguagens dinâmicas: `reduce`.*

```csharp
List<decimal> gastos = new List<decimal> { 50.0m, 20.0m, 30.0m };

decimal total = gastos.Sum(); // 100.0
decimal maiorGasto = gastos.Max(); // 50.0
decimal media = gastos.Average(); // 33.333...
```

## O Segredo do LINQ: Execução Adiada (Deferred Execution)

Uma característica crucial do LINQ é que consultas como `Where` e `Select` não são executadas no momento em que você as escreve. Elas só são calculadas quando você *realmente* itera sobre os dados (por exemplo, em um `foreach`) ou quando você força a execução.

Para forçar a execução imediata e guardar o resultado definitivo na memória como uma nova lista, usamos o método **`.ToList()`** ou **`.ToArray()`** no final da consulta:

```csharp
// Calcula imediatamente e guarda na variável como uma List<int>
List<int> maioresDeDez = numeros.Where(n => n > 10).ToList();
```

## Encadeamento (Chaining)

A verdadeira magia do LINQ é que você pode encadear esses métodos de forma fluida para criar pipelines de processamento de dados robustos em uma única linha:

```csharp
decimal resultado = transacoes
    .Where(t => t > 0)          // 1. Filtra apenas as entradas positivas
    .Select(t => t * 0.9m)      // 2. Desconta 10% de imposto
    .Sum();                     // 3. Soma tudo
```