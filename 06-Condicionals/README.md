# Ramificações Condicionais: if, else e o operador '?'

Às vezes, precisamos executar ações diferentes com base em condições diferentes. Para fazer isso, podemos usar a instrução `if` e o operador condicional `?`, que também é chamado de operador de "ponto de interrogação".

## A instrução "if"

A instrução `if(...)` avalia uma condição entre parênteses e, se o resultado for `true`, executa um bloco de código.


Por exemplo:

```csharp
int ano = 2015;

if (ano == 2015) 
{
    Console.WriteLine("Você está certo!");
}
```

Se quisermos executar mais de uma instrução, temos que envolver nosso bloco de código entre chaves. Recomendamos envolver seu bloco de código com chaves `{}` toda vez que você usar uma instrução `if`, mesmo que haja apenas uma instrução a ser executada. Fazer isso melhora a legibilidade.

## A ausência de conversão Booleana (Truthy/Falsy)

Em linguagens dinâmicas, a instrução `if (…)` avalia a expressão em seus parênteses e converte o resultado para um booleano. Nelas, valores como `0`, strings vazias ou `null` se tornam `false` ("falsy"), e outros valores se tornam `true` ("truthy").

**No C#, isso NÃO existe.** O C# exige que a expressão dentro do `if` seja **estritamente** um valor booleano (`bool`). 

```csharp
// EM OUTRAS LINGUAGENS (Válido):
// if (1) { ... }
// if ("texto") { ... }

// NO C# (ERRO DE COMPILAÇÃO):
// if (1) { ... } // O compilador avisa: Não é possível converter implicitamente o tipo 'int' em 'bool'

// NO C# (O jeito certo):
int numero = 1;
if (numero == 1) { ... } 
```

## As cláusulas "else" e "else if"

A instrução `if` pode conter um bloco `else` opcional. Ele é executado quando a condição é falsa.

Às vezes, gostaríamos de testar várias variantes de uma condição. A cláusula `else if` nos permite fazer isso.

```csharp
int ano = 2026;

if (ano < 2015) 
{
    Console.WriteLine("Muito cedo...");
} 
else if (ano > 2015) 
{
    Console.WriteLine("Muito tarde");
} 
else 
{
    Console.WriteLine("Exatamente!");
}
```

## O operador condicional '?' (Ternário)

O operador é representado por um ponto de interrogação `?`. Às vezes é chamado de "ternário", porque o operador tem três operandos.

A sintaxe é:
```csharp
var resultado = condicao ? valor1 : valor2;
```

A `condicao` é avaliada: se for verdadeira, `valor1` é retornado, caso contrário -- `valor2`.

```csharp
int idade = 20;
bool acessoPermitido = (idade > 18) ? true : false;
// Ou de forma mais limpa: string mensagem = (idade > 18) ? "Entrada liberada" : "Bloqueado";
```

### Uso restrito do '?' no C#

Em algumas linguagens, o ponto de interrogação `?` é usado como um substituto para `if` apenas para executar ações visuais ou chamadas de métodos que não retornam nada. 

**No C#, o operador ternário OBRIGATORIAMENTE deve retornar um valor.** Você não pode usá-lo puramente para executar métodos `void` (como um `Console.WriteLine` solto). 

O objetivo do operador de ponto de interrogação `?` é retornar um valor ou outro dependendo de sua condição. Por favor, use-o exatamente para isso. Use `if` quando precisar executar ramificações diferentes de código.