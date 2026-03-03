# Atribuição via Desestruturação (Deconstruction)

A atribuição via desestruturação é uma sintaxe especial que nos permite "desempacotar" arrays ou objetos em um monte de variáveis, pois às vezes isso é mais conveniente. 


No ecossistema JavaScript, as duas estruturas de dados mais usadas para isso são `Object` e `Array`. No C#, nós alcançamos o mesmo resultado usando **Tuplas**, **Records** e **Padrões de Lista** (List Patterns).

## Desestruturando Tuplas (O "Array" do JS)

Em linguagens dinâmicas, desestruturar um array se parece com isso: `let [firstName, surname] = arr`. 

No C#, o equivalente mais direto para retornar e desempacotar múltiplos valores simples de uma função são as **Tuplas** (usando parênteses em vez de colchetes):

```csharp
// Criando uma tupla
var pessoa = ("John", "Smith");

// Desconstruindo a tupla em duas variáveis
var (firstName, surname) = pessoa;

Console.WriteLine(firstName); // John
```

### Ignorando elementos (O operador Discard `_`)

Elementos indesejados podem ser descartados. Enquanto no JS isso é feito deixando um espaço vazio entre vírgulas (ex: `let [firstName, , title]`), o C# utiliza o caractere de descarte explícito `_` (underscore):

```csharp
var dados = ("Julius", "Caesar", "Consul");

// O segundo elemento não é necessário
var (firstName, _, title) = dados; 
```

## Desestruturando Objetos (Records)

A atribuição de desestruturação também funciona com objetos. No JS, a sintaxe básica usa chaves para mapear as propriedades pelo nome: `let {title, width, height} = options`.

**A grande diferença no C#:** O C# não permite desestruturar classes comuns de forma nativa a menos que você escreva um método especial chamado `Deconstruct`. No entanto, se você usar a estrutura **`record`** posicional (que aprendemos no módulo anterior), a desconstrução já vem pronta e usa parênteses!

```csharp
// Definindo um record posicional
public record MenuOptions(string Title, int Width, int Height);

MenuOptions options = new MenuOptions("Menu", 100, 200);

// Desconstruindo o objeto record (A ordem importa no C#!)
var (titulo, largura, altura) = options;
```

*Nota: Em JS, a ordem não importa na desestruturação de objetos porque é baseada nas chaves*. *No C#, a desconstrução de records posicionais é baseada na **posição** dos argumentos.*

## O padrão Rest (O resto `...`)

Normalmente, se a lista for maior do que as variáveis à esquerda, os itens "extras" são omitidos. Se quisermos reunir tudo o que se segue, linguagens dinâmicas usam três pontos `...rest`.

A partir do C# 11, podemos desestruturar Arrays nativos usando o **List Pattern Matching**, e o operador de resto no C# são dois pontos `..`:

```csharp
int[] numeros = { 1, 2, 3, 4, 5 };

// Usando pattern matching para arrays
if (numeros is [var primeiro, var segundo, .. var resto])
{
    Console.WriteLine(primeiro); // 1
    // resto conterá o array [3, 4, 5]
}
```

## Valores Padrão (Default Values)

Em JS, se quisermos que um valor "padrão" substitua um ausente, podemos fornecê-lo usando `=` (ex: `let [name = "Guest"] = []`). 

O C# é fortemente tipado e o compilador não permite desconstruir algo que não existe (uma tupla de 2 itens não pode ser desconstruída em 3). Portanto, valores padrão durante a desconstrução não existem na sintaxe do C# da mesma forma; você lidaria com verificações de `null` usando o operador `??` que vimos anteriormente.

## Resumo

* A desestruturação (Deconstruction) no C# mapeia estruturas de dados para várias variáveis em uma única linha, assim como no JS.
* Usamos parênteses `()` com **Tuplas** para substituir a desestruturação básica de Arrays do JS.
* Usamos a variável de descarte `_` para ignorar valores que não vamos usar (substituindo o truque da vírgula do JS).
* Objetos podem ser desconstruídos nativamente se forem criados como `record` posicionais.
* Arrays modernos no C# (11+) usam `[var item1, .. var rest]` para extrair itens e pegar "o resto", de forma similar ao `...rest`.