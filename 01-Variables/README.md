# Variáveis em C#

Na maioria do tempo, um aplicativo precisa trabalhar com informações. Aqui estão dois exemplos:
1. Uma loja online -- a informação pode incluir os produtos sendo vendidos e um carrinho de compras.
2. Um aplicativo de chat -- a informação pode incluir usuários, mensagens e muito mais.

As variáveis são usadas para armazenar essas informações.

## Uma variável

Uma variável é um "armazenamento nomeado" para dados. Podemos usar variáveis para armazenar produtos, visitantes e outros dados.

Diferente de linguagens dinâmicas, o C# é uma linguagem de tipagem forte, o que significa que **você precisa dizer qual o tipo de dado** que a variável vai armazenar.

A instrução abaixo cria (em outras palavras: *declara*) uma variável do tipo texto (`string`) com o nome "message":

```csharp
string message;
```

Agora, podemos colocar algum dado nela usando o operador de atribuição `=`:

```csharp
string message;

// armazena a string 'Hello' na variável chamada message
message = "Hello"; 
```

A string agora está salva na área de memória associada à variável. Podemos acessá-la usando o nome da variável:

```csharp
string message;
message = "Hello!";

// mostra o conteúdo da variável no console
Console.WriteLine(message); 
```

Para sermos concisos, podemos combinar a declaração da variável e a atribuição em uma única linha:

```csharp
// define a variável e atribui o valor
string message = "Hello!"; 

Console.WriteLine(message); // Hello!
```

Podemos também declarar múltiplas variáveis do mesmo tipo em uma linha:

```csharp
string user = "John", age = "25", message = "Hello";
```

Isso pode parecer mais curto, mas não é recomendado. Pelo bem da legibilidade, use uma linha por variável:

```csharp
string user = "John";
int age = 25; // Note que idade no C# costuma ser um número inteiro (int)
string message = "Hello";
```

> **A palavra-chave `var` no C#**
> No C#, você também pode usar a palavra-chave `var`. Ao usá-la, você pede para o compilador do C# descobrir qual é o tipo da variável com base no valor que você está atribuindo a ela:
> ```csharp
> var message = "Hello"; // O C# sabe que isso é uma string
> var age = 25;          // O C# sabe que isso é um int
> ```
> Depois de definida com `var`, o tipo da variável não pode ser alterado!

## Uma analogia da vida real

Podemos facilmente entender o conceito de uma "variável" se a imaginarmos como uma "caixa" para dados, com um adesivo com um nome único nela.

Por exemplo, a variável `message` pode ser imaginada como uma caixa rotulada `"message"` com o valor `"Hello!"` dentro dela.

![Analogia de caixa para variável](variable.svg)

Podemos colocar qualquer valor na caixa. E podemos mudá-lo quantas vezes quisermos:

```csharp
string message;

message = "Hello!";

message = "World!"; // valor alterado

Console.WriteLine(message);
```

Quando o valor é alterado, o dado antigo é removido da variável.

![Caixa com valor alterado](variable-change.svg)

Podemos também declarar duas variáveis e copiar dados de uma para a outra:

```csharp
string hello = "Hello world!";
string message;

// copia 'Hello world' de hello para message
message = hello;

// agora as duas variáveis guardam o mesmo dado
Console.WriteLine(hello);   // Hello world!
Console.WriteLine(message); // Hello world!
```

> **⚠️ Declarar duas vezes gera um erro**
> Uma variável deve ser declarada apenas uma vez.
> Uma declaração repetida da mesma variável é um erro:
>
> ```csharp
> string message = "This";
> 
> // repetir a declaração de tipo gera um erro no C#
> string message = "That"; // Erro de compilação: Uma variável local chamada 'message' já está definida
> ```

## Nomenclatura de Variáveis

Existem regras básicas para nomes de variáveis em C#:
1. O nome deve conter apenas letras, dígitos ou o símbolo `_`.
2. O primeiro caractere não deve ser um dígito.

Exemplos de nomes válidos:

```csharp
string userName;
int test123;
```

Quando o nome contém múltiplas palavras para variáveis locais, o padrão `camelCase` é comumente usado. Ou seja: as palavras vão uma após a outra, com cada palavra, exceto a primeira, começando com uma letra maiúscula: `myVeryLongName`.

Exemplos de nomes incorretos:

```csharp
int 1a; // não pode começar com um dígito

string my-name; // hifens '-' não são permitidos no nome
```

> **Atenção aos Maiúsculos e Minúsculos**
> Variáveis chamadas `apple` e `APPLE` são duas variáveis diferentes.

> **Nomes Reservados**
> Existe uma lista de palavras reservadas, que não podem ser usadas como nomes de variáveis porque são usadas pela própria linguagem. Por exemplo: `class`, `return`, `int` e `string`.
> Se você *realmente* precisar usar um nome reservado (não recomendado), o C# exige que você coloque um `@` na frente: `string @class = "C# Fundamentals";`.

## Constantes

Para declarar uma variável constante (que não muda), use `const` no lugar do tipo (ou junto dele):

```csharp
const string MyBirthday = "18.04.1982";
```

Variáveis declaradas usando `const` são chamadas de "constantes". Elas não podem ser reatribuídas. Uma tentativa de fazer isso causará um erro de compilação:

```csharp
const string MyBirthday = "18.04.1982";

MyBirthday = "01.01.2001"; // erro, não é possível reatribuir uma constante!
```

Quando um programador tem certeza de que uma variável nunca mudará, ele pode declará-la com `const` para garantir e comunicar esse fato a todos.

*Nota de convenção C#: Diferente de outras linguagens que usam TUDO_MAIUSCULO para constantes, o padrão mais adotado no mundo .NET/C# para constantes e propriedades públicas é o `PascalCase` (primeira letra de toda palavra em maiúscula, como `MyBirthday`).*

## Nomeie as coisas corretamente

Falando sobre variáveis, há mais uma coisa extremamente importante.

Um nome de variável deve ter um significado limpo e óbvio, descrevendo o dado que ela armazena. A nomenclatura de variáveis é uma das habilidades mais importantes e complexas na programação.

Por favor, gaste tempo pensando no nome certo para uma variável antes de declará-la. Fazer isso irá recompensá-lo generosamente.

Algumas boas regras para seguir são:
* Use nomes legíveis para humanos como `userName` ou `shoppingCart`.
* Fique longe de abreviações ou nomes curtos como `a`, `b` e `c`, a menos que você saiba o que está fazendo.
* Faça nomes o mais descritivos e concisos possível. Exemplos de nomes ruins são `data` e `value`. Esses nomes não dizem nada.
* Entre em acordo sobre os termos na sua equipe e na sua mente. Se um visitante do site é chamado de "user", então devemos nomear variáveis relacionadas de `currentUser` ou `newUser` em vez de `currentVisitor`.

## Resumo

Podemos declarar variáveis para armazenar dados em C# especificando seu tipo (como `string` ou `int`), usando a inferência de tipo com `var`, ou criando valores imutáveis com `const`.

As variáveis devem ser nomeadas de uma forma que nos permita entender facilmente o que há dentro delas.