# Funções (Métodos)

Frequentemente precisamos realizar uma ação semelhante em muitos lugares do código. Por exemplo, precisamos mostrar uma mensagem bonita quando um visitante faz login, faz logout e talvez em algum outro lugar.

As funções são os principais "blocos de construção" do programa. Elas permitem que o código seja chamado várias vezes sem repetição.


## Declaração de Função

Em linguagens dinâmicas, usamos a palavra-chave `function` para criar uma função. **No C#, nós declaramos o "Tipo de Retorno" da função em vez da palavra `function`.** Se a função não devolver nenhum valor, usamos a palavra `void` (vazio). O nome da função vem em seguida, seguido por uma lista de parâmetros entre parênteses e o corpo da função entre chaves.

```csharp
void ShowMessage() 
{
  Console.WriteLine("Olá pessoal!");
}

// A chamada executa o código da função
ShowMessage();
ShowMessage();
```

Este exemplo demonstra claramente um dos principais propósitos das funções: evitar a duplicação de código. Se precisarmos mudar a mensagem, basta modificar o código em um lugar.

## Variáveis Locais e Externas

* Uma variável declarada dentro de uma função é visível apenas dentro daquela função.
* Uma função pode acessar uma variável externa também. A função tem acesso total à variável externa e pode modificá-la.
* É uma boa prática minimizar o uso de variáveis globais/externas. O código moderno tem poucas ou nenhuma variável global, pois a maioria das variáveis reside em suas funções.

## Parâmetros e Argumentos

Podemos passar dados arbitrários para as funções usando parâmetros. **No C#, você é obrigado a declarar o tipo de cada parâmetro.**

```csharp
void ShowMessage(string from, string text) 
{
  Console.WriteLine($"{from}: {text}");
}

ShowMessage("Ann", "Hello!");
```

Para deixar os termos claros:
* Um parâmetro é a variável listada dentro dos parênteses na declaração da função.
* Um argumento é o valor que é passado para a função quando ela é chamada.

## Valores Padrão (Default Values)

Em algumas linguagens, se uma função é chamada sem um argumento, o valor correspondente se torna `undefined`. No C#, se um parâmetro não for opcional, o compilador não deixará você chamar a função sem ele, evitando erros de execução.

Podemos especificar um valor "padrão" (para usar se omitido) para um parâmetro na declaração da função usando `=`:

```csharp
void ShowMessage(string from, string text = "sem texto fornecido") 
{
  Console.WriteLine($"{from}: {text}");
}

ShowMessage("Ann"); // Imprime: Ann: sem texto fornecido
```

## Retornando um Valor

Uma função pode retornar um valor de volta para o código chamador como resultado. Para isso, trocamos o `void` pelo tipo de dado que queremos devolver (ex: `int`, `string`, `bool`).

O exemplo mais simples seria uma função que soma dois valores:

```csharp
int Sum(int a, int b) 
{
  return a + b;
}

int result = Sum(1, 2);
Console.WriteLine(result); // 3
```

A diretiva `return` pode estar em qualquer lugar da função. Quando a execução a alcança, a função para e o valor é retornado ao código chamador. É possível usar `return` sem um valor (em funções `void`) para fazer a função sair imediatamente.

## Nomeando uma Função

As funções são ações. Portanto, o nome delas geralmente é um verbo. Ele deve ser breve, o mais preciso possível e descrever o que a função faz. 

**Convenção do C#:** Diferente de outras linguagens que usam `camelCase` para funções, o padrão do C# dita que métodos devem ser nomeados em `PascalCase` (começando com letra maiúscula).

Funções começando com certos prefixos indicam seu comportamento:
* `Get...` -- retornam um valor.
* `Calc...` -- calculam algo.
* `Create...` -- criam algo.
* `Check...` -- verificam algo e retornam um booleano.

Uma função deve fazer exatamente o que é sugerido pelo seu nome, nada mais. Duas ações independentes geralmente merecem duas funções. Uma função separada não é apenas mais fácil de testar e depurar — sua própria existência é um ótimo comentário no código!