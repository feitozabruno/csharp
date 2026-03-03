# Tipos de Dados Não Primitivos: Struct, Record e Delegate

No C#, além das tradicionais **Classes** (que são tipos de referência, alocados na memória *Heap*), nós temos outras estruturas poderosas para modelar nossos dados e comportamentos. Escolher a estrutura certa pode melhorar drasticamente a performance e a legibilidade do seu código.



## 1. Structs (Estruturas)

Uma `struct` é semelhante a uma classe, mas com uma diferença fundamental: ela é um **Tipo de Valor** (Value Type), o que significa que ela é alocada diretamente na memória *Stack* (uma área da memória muito mais rápida e de curta duração).

**Quando usar?**
Structs são ideais para pequenas estruturas de dados que contêm principalmente valores numéricos e que não precisam de herança. Exemplos clássicos são coordenadas (`X, Y`), cores em RGB (`R, G, B`) ou dados matemáticos simples.

```csharp
// Definindo uma struct
public struct Coordenada
{
    public int X { get; set; }
    public int Y { get; set; }

    public Coordenada(int x, int y)
    {
        X = x;
        Y = y;
    }
}
```

**O Cuidado com Structs:** Diferente de uma classe (onde duas variáveis podem apontar para o mesmo objeto na memória), quando você copia uma `struct`, o C# cria uma **cópia idêntica e independente** de todos os dados.

## 2. Records (Registros)

Introduzido no C# 9, o `record` é um dos recursos modernos mais amados da linguagem. Ele é, na sua essência, uma classe (tipo de referência), mas construído para **Imutabilidade** e **Igualdade baseada em Valor**.

**O problema que ele resolve:**
Se você criar dois objetos de uma `class` tradicional com os exatos mesmos dados (ex: `Nome = "João"`), o C# dirá que eles são *diferentes*, porque ocupam espaços diferentes na memória. Se você quiser compará-los, dá muito trabalho. O `record` resolve isso nativamente: se os dados internos forem iguais, os records são considerados iguais.

Além disso, eles são perfeitos para criar objetos que não devem ser alterados depois de criados (Imutáveis), sendo muito usados para transferir dados (DTOs - Data Transfer Objects).

```csharp
// Uma declaração completa de Record imutável em apenas uma linha!
public record Usuario(string Nome, string Email);
```

Se você precisar alterar um dado de um record, você usa a palavra-chave `with` para criar um *novo* record copiando o anterior e alterando apenas o necessário (técnica conhecida como *non-destructive mutation*):

```csharp
Usuario user1 = new Usuario("João", "joao@email.com");
Usuario user2 = user1 with { Email = "novo@email.com" }; // Cria uma cópia com email novo
```

## 3. Delegates (Delegados)

Nós já esbarramos nos delegates quando estudamos *Expressões de Função* e *Lambdas* (`Action` e `Func`). 

Um `delegate` é um tipo que representa uma referência a um método. É a forma segura e tipada do C# de "guardar uma função dentro de uma variável" ou passá-la como parâmetro.

Embora hoje em dia a gente use muito os delegates prontos (`Action` para `void` e `Func` para retornos), você pode criar os seus próprios delegates para definir assinaturas de métodos muito específicas (por exemplo, um método que obrigatoriamente recebe um `int`, uma `string` e retorna um `bool`).

```csharp
// Definindo um delegate personalizado
public delegate void ProcessadorDePagamento(decimal valor);

// Pode armazenar qualquer função que respeite essa assinatura (receber decimal e retornar void)
```

## Resumo

* **`struct`**: Use para dados pequenos e de alta performance. É um tipo de valor (copiado inteiramente ao ser atribuído).
* **`record`**: Use para dados imutáveis e quando a igualdade deve ser baseada nos valores contidos, não na referência de memória. Sintaxe extremamente limpa.
* **`delegate`**: O tipo base que permite tratar funções/métodos como variáveis. `Action` e `Func` são apenas delegates pré-fabricados pelo .NET.