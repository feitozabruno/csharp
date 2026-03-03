# Listas Dinâmicas e Métodos (`List<T>`)

No C#, a estrutura de `Array` possui um tamanho fixo na memória. No entanto, muitas vezes precisamos de uma coleção de dados que possa crescer ou encolher dinamicamente durante a execução do programa. 

Para cenários onde precisamos adicionar, remover ou pesquisar elementos livremente, o C# fornece a classe **`List<T>`** (Lista Genérica).

## Declaração e Inicialização

Para usar uma Lista, precisamos especificar o tipo de dado que ela irá armazenar entre os sinais de menor e maior `<T>`. O compilador garantirá que apenas dados desse tipo sejam inseridos.

```csharp
// Criando uma lista vazia
List<string> tecnologias = new List<string>();

// Criando e inicializando com valores
List<decimal> valores = new List<decimal> { 150.50m, 200.00m };
```

Diferente do array que usa a propriedade `Length`, o tamanho atual de uma lista é obtido pela propriedade **`Count`**:

```csharp
Console.WriteLine(valores.Count); // 2
```

## Adicionando e Removendo Itens

A `List<T>` fornece métodos altamente otimizados para manipular a coleção:

* **`.Add(item)`:** Adiciona um único elemento ao final da lista.
* **`.AddRange(colecao)`:** Adiciona múltiplos elementos de uma vez ao final da lista.
* **`.Insert(indice, item)`:** Insere um elemento em uma posição específica, empurrando os elementos subsequentes para a frente.
* **`.Remove(valor)`:** Remove a primeira ocorrência do valor especificado.
* **`.RemoveAt(indice)`:** Remove o elemento que está na posição especificada.
* **`.Clear()`:** Esvazia completamente a lista, deixando o `Count` em 0.

Exemplo prático:
```csharp
List<string> nomes = new List<string> { "Ana", "Carlos" };
nomes.Add("João");         // Ana, Carlos, João
nomes.Insert(0, "Maria");  // Maria, Ana, Carlos, João
nomes.RemoveAt(nomes.Count - 1); // Remove o último item (João)
```

## Pesquisando na Lista

Para verificar a existência de dados dentro da coleção, o C# oferece métodos semânticos e diretos:

* **`.Contains(valor)`:** Retorna `true` se o valor existir na lista, e `false` caso contrário. Ideal para checagens rápidas em condicionais (`if`).
* **`.IndexOf(valor)`:** Retorna o índice numérico (posição) da primeira ocorrência do valor. Se o item não existir, ele retorna `-1`.

```csharp
List<int> numeros = new List<int> { 10, 20, 30 };

bool temVinte = numeros.Contains(20); // true
int posicao = numeros.IndexOf(30);    // 2
```

## Ordenação e Inversão

A própria classe `List<T>` possui métodos nativos para reorganizar seus elementos *in-place* (ou seja, ela modifica a si mesma):

* **`.Sort()`:** Ordena a lista usando o comparador padrão do tipo de dado (ordem alfabética para strings, ordem crescente para números).
* **`.Reverse()`:** Inverte completamente a ordem atual dos elementos da lista.

```csharp
List<int> ids = new List<int> { 3, 1, 2 };
ids.Sort();   // 1, 2, 3
ids.Reverse(); // 3, 2, 1
```

## Performance: Por baixo dos panos

Internamente, uma `List<T>` é um "wrapper" em volta de um `Array` comum de tamanho fixo. 

Quando você adiciona itens e o array interno fica cheio, o C# automaticamente cria um novo array com o **dobro** da capacidade, copia os itens antigos para o novo array e adiciona o seu novo item. Isso torna a Lista dinâmica e, ao mesmo tempo, extremamente rápida e eficiente para inserções no final da coleção. Operações que modificam o início ou o meio da lista (como `.Insert` ou `.RemoveAt(0)`) são um pouco mais lentas, pois exigem o deslocamento dos demais elementos na memória.