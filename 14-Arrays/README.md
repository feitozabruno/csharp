# Arrays (Vetores)

Objetos permitem que você armazene coleções de valores baseadas em chaves. Mas, com bastante frequência, descobrimos que precisamos de uma *coleção ordenada*, onde temos um 1º, um 2º, um 3º elemento e assim por diante. 

Existe uma estrutura de dados especial chamada `Array` para armazenar coleções ordenadas.


## Declaração e Tipagem Forte

Em linguagens dinâmicas, um array pode armazenar elementos de qualquer tipo, permitindo uma mistura de valores (como strings, objetos e booleanos no mesmo array). 

**No C#, os arrays são fortemente tipados.** Você precisa declarar qual o tipo de dado que aquele array vai guardar, e ele só aceitará aquele tipo. Existem duas sintaxes principais para criar um array no C#:

```csharp
// 1. Criando um array vazio com tamanho fixo de 3 posições
string[] frutas = new string[3];
frutas[0] = "Maçã";
frutas[1] = "Laranja";
frutas[2] = "Ameixa";

// 2. Criando e já inicializando com elementos (mais comum)
string[] frutas = { "Maçã", "Laranja", "Ameixa" };
```

Os elementos do array são numerados, começando com zero. Podemos obter um elemento pelo seu número entre colchetes.

## O Tamanho Fixo e a Propriedade "Length"

A contagem total dos elementos no array é o seu `length` (tamanho). 

Em linguagens dinâmicas, o `length` se ajusta automaticamente e, se o diminuirmos, o array é truncado irreversivelmente. 

**No C#, a propriedade `Length` (com L maiúsculo) é SOMENTE LEITURA.** Uma vez que um array é criado no C#, seu tamanho na memória é fixo e não pode ser alterado. Você não pode adicionar um 4º elemento em um array que foi criado para ter apenas 3 posições.

## Pegando o último elemento (Índices reversos)

Se quisermos o último elemento do array, podemos calcular explicitamente o índice: `frutas[frutas.Length - 1]`.

Mas o C# moderno (versão 8.0+) possui um operador de índice reverso `^`, que funciona de forma muito semelhante ao método `.at(-1)` que recua a partir do final do array.

```csharp
string[] frutas = { "Maçã", "Laranja", "Ameixa" };

// Retorna o primeiro elemento de trás para frente (Ameixa)
Console.WriteLine(frutas[^1]); 
```

## E os métodos Push, Pop, Shift e Unshift?

Em linguagens dinâmicas, arrays podem funcionar como Pilhas (Stack) ou Filas (Queue), permitindo adicionar (`push`, `unshift`) ou remover (`pop`, `shift`) elementos do começo ou do fim.

Como os Arrays no C# têm **tamanho fixo**, eles NÃO possuem esses métodos nativamente. Se você tentar trabalhar com o array como se ele pudesse crescer indefinidamente, as otimizações específicas do compilador não se aplicarão e você receberá erros. 

Quando precisamos de uma coleção ordenada onde o tamanho pode crescer ou diminuir dinamicamente (para usar métodos semelhantes ao `push` e `pop`), o C# utiliza uma estrutura chamada **`List<T>`** (Lista), que estudaremos na sequência.

## Laços de Repetição (Loops)

Uma das maneiras mais antigas de percorrer itens de um array é o laço `for` sobre os índices:

```csharp
string[] arr = { "Maçã", "Laranja", "Pera" };

for (int i = 0; i < arr.Length; i++) 
{
  Console.WriteLine( arr[i] );
}
```

Mas para arrays existe outra forma de laço que itera sobre os elementos do array. Em algumas linguagens isso é feito com o `for..of`. No C#, utilizamos o **`foreach`**:

```csharp
// O foreach não dá acesso ao número do elemento atual, apenas ao seu valor, mas na maioria dos casos isso é suficiente e mais curto
foreach (string fruta in arr) 
{
  Console.WriteLine( fruta );
}
```

## Não compare arrays com ==

Arrays não devem ser comparados com o operador `==`. Este operador não tem tratamento especial para arrays, ele trabalha com eles como com quaisquer objetos (comparando referências na memória).

Portanto, se compararmos dois arrays diferentes com o mesmo conteúdo usando `==`, eles nunca serão os mesmos, pois são objetos tecnicamente diferentes. Em vez disso, você deve compará-los item por item em um loop ou usar métodos específicos do C# (como `SequenceEqual` do LINQ).

## Resumo

* Um array é um objeto especial, adequado para armazenar e gerenciar itens de dados ordenados.
* No C#, arrays são fortemente tipados (só aceitam um tipo de dado) e possuem **tamanho fixo** na memória.
* Podemos obter um elemento pelo seu índice (`arr[0]`) ou usar o operador `^1` para contar do final para o começo.
* A propriedade `Length` retorna a capacidade total do array, mas não pode ser alterada manualmente.
* Para iterar sobre os elementos, o `for` clássico funciona mais rápido, e o `foreach` é a sintaxe moderna para lidar apenas com os itens.