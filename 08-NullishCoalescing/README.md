# Operador de Coalescência Nula '??'

O operador de coalescência nula é escrito como dois pontos de interrogação `??`.

Como o C# não possui o conceito de `undefined`, focaremos apenas na verificação de valores `null`. Para simplificar, diremos que um valor é "definido" quando não é `null`.

O resultado de `a ?? b` é:
* se `a` é definido, então `a`.
* se `a` não é definido, então `b`.

Em outras palavras, `??` retorna o primeiro argumento se não for nulo. Caso contrário, o segundo. O operador de coalescência nula não é nada completamente novo, é apenas uma sintaxe agradável para obter o primeiro valor "definido" dos dois.


Podemos reescrever `resultado = a ?? b` usando os operadores que já conhecemos:
```csharp
resultado = (a != null) ? a : b;
```

## Onde ele ajuda (Casos de Uso)

O caso de uso comum para `??` é fornecer um valor padrão.

Por exemplo, aqui mostramos o `usuario` se o seu valor não for nulo, caso contrário, mostramos `"Anônimo"`:

```csharp
string usuario = null;
Console.WriteLine(usuario ?? "Anônimo"); // Imprime: Anônimo
```

Podemos também usar uma sequência de `??` para selecionar o primeiro valor de uma lista que não seja nulo. 

Digamos que temos os dados de um usuário em variáveis `primeiroNome`, `ultimoNome` ou `apelido`. Gostaríamos de exibir o nome do usuário usando uma dessas variáveis, ou mostrar `"Anônimo"` se todas elas forem nulas.

```csharp
string primeiroNome = null;
string ultimoNome = null;
string apelido = "SuperCoder";

// mostra o primeiro valor definido:
Console.WriteLine(primeiroNome ?? ultimoNome ?? apelido ?? "Anônimo"); // SuperCoder
```

## Comparação com o operador || (OR)

Em linguagens dinâmicas, o operador OR `||` pode ser usado da mesma forma que `??`. Historicamente, desenvolvedores dessas linguagens usavam `||` para definir valores padrão por muito tempo.

A diferença importante entre eles no ecossistema de linguagens dinâmicas é que o `||` retorna o primeiro valor *truthy* (verdadeiro), enquanto o `??` retorna o primeiro valor *definido*. O `||` não distingue entre `false`, `0`, uma string vazia `""` e nulo. Se algum desses for o primeiro argumento de `||`, então obteremos o segundo argumento como resultado.

**No C#, a história é totalmente diferente e muito mais segura:**
Você **NÃO PODE** usar `||` para retornar strings ou números no C#. O operador `||` só funciona com valores estritamente booleanos (`true`/`false`). Portanto, no C#, o `??` é a *única* maneira de fazer essa atribuição de valor padrão para textos, objetos e tipos anuláveis (`int?`).

```csharp
int? altura = null;
// int resultado = altura || 100; // ERRO DE COMPILAÇÃO NO C#!
int resultado = altura ?? 100;    // CORRETO! Se altura for null, assume 100.
```

## O bônus do C#: Operador de Atribuição de Coalescência Nula (`??=`)

O C# possui uma evolução muito útil desse operador: o `??=`. 
Ele atribui o valor da direita à variável da esquerda **apenas se a variável da esquerda for nula**.

```csharp
string nome = null;
nome ??= "Visitante"; // Como 'nome' é null, ele recebe "Visitante"
nome ??= "João";      // Como 'nome' já não é mais null, ele ignora "João"
```

## Precedência

A precedência do operador `??` é bastante baixa, sendo avaliada depois da maioria das outras operações, como `+` e `*`. 

Portanto, podemos precisar adicionar parênteses em expressões matemáticas para evitar resultados incorretos:

```csharp
int? altura = null;
int? largura = null;

// importante: use parênteses
int area = (altura ?? 100) * (largura ?? 50);

Console.WriteLine(area); // 5000
```

## Resumo

* O operador de coalescência nula `??` fornece uma maneira curta de escolher o primeiro valor "definido" de uma lista.
* É usado para atribuir valores padrão a variáveis.
* O operador `??` tem uma precedência muito baixa, então considere adicionar parênteses ao usá-lo em uma expressão matemática.
* No C#, existe o operador `??=` para atribuir um valor a uma variável apenas se ela estiver nula no momento.