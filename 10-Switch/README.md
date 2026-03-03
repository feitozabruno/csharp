# A instrução "switch"

Uma instrução `switch` pode substituir várias verificações `if`. Ela fornece uma maneira mais descritiva de comparar um valor com várias variantes.


## A sintaxe

O `switch` tem um ou mais blocos `case` e um `default` opcional.

Ele se parece com isso:

```csharp
switch(x) 
{
  case "valor1":
    // código se x for "valor1"
    break;

  case "valor2":
    // código se x for "valor2"
    break;

  default:
    // código se não for nenhum dos anteriores
    break;
}
```

* O valor de `x` é verificado para igualdade com o valor do primeiro `case` (ou seja, `"valor1"`), depois com o segundo (`"valor2"`) e assim por diante.
* Se a igualdade for encontrada, o `switch` começa a executar o código começando do `case` correspondente, até o `break` mais próximo.
* Se nenhum caso for correspondido, o código `default` é executado (se existir).

## A Grande Diferença do C#: Queda Livre (Fall-through) Proibida

Em linguagens dinâmicas, se não houver um `break`, a execução continua com o próximo `case` sem nenhuma verificação. Isso muitas vezes causa bugs terríveis, pois o desenvolvedor simplesmente esqueceu de colocar o `break` e o código executou múltiplas ações indesejadas.

**No C#, isso é ESTRITAMENTE PROIBIDO.**
O compilador do C# obriga você a colocar um `break` (ou um `return`) no final de todo `case` que contenha código. Se você esquecer, o programa não compila.

## Agrupamento de "case"

Várias variantes de `case` que compartilham o mesmo código podem ser agrupadas.

No C#, como a "queda livre" de código é proibida, a **única** forma de fazer um caso "cair" para o próximo é se o caso estiver completamente vazio. 

Por exemplo, se quisermos que o mesmo código seja executado para `case 3` e `case 5`:

```csharp
int a = 3;

switch (a) 
{
  case 4:
    Console.WriteLine("Certo!");
    break;

  case 3: // Caso agrupado (vazio)
  case 5:
    Console.WriteLine("Errado!");
    Console.WriteLine("Por que você não faz uma aula de matemática?");
    break;

  default:
    Console.WriteLine("O resultado é estranho.");
    break;
}
```
Agora ambos `3` e `5` mostram a mesma mensagem.

## O Tipo Importa

Em linguagens dinâmicas, vale ressaltar que a verificação de igualdade é sempre estrita, logo os valores devem ser do mesmo tipo para corresponder. Por exemplo, a string `"3"` não seria igual ao número `3`.

No C#, nós nem precisamos nos preocupar com a diferença entre "igualdade" e "igualdade estrita". O C# é fortemente tipado. Se a variável dentro do `switch(x)` for uma `string`, você é **obrigado** a usar strings nos seus `cases`. Tentar colocar `case 3:` (um número) dentro de um switch de `string` gerará um erro de compilação imediato.

## Bônus do C#: Expressões Switch (Switch Expressions)

A partir do C# 8.0, a linguagem introduziu uma forma ainda mais concisa de usar o switch quando a sua única intenção é **retornar um valor**. Funciona como uma versão limpa e moderna do `switch` clássico:

```csharp
int opcao = 2;

string resultado = opcao switch
{
    1 => "Você escolheu um",
    2 => "Você escolheu dois",
    _ => "Opção desconhecida" // O '_' (underline) atua como o 'default'
};
```