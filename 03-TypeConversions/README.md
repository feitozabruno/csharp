# Conversão de Tipos (Type Conversions)

Na maioria das vezes, operadores e funções lidam com os tipos de dados que fornecemos, mas existem casos em que precisamos converter explicitamente um valor para o tipo esperado. 

Diferente de linguagens dinâmicas que convertem valores automaticamente (e muitas vezes silenciosamente) durante operações matemáticas, o **C# é fortemente tipado**. Ele possui regras estritas para conversões, divididas principalmente em três categorias: Implícitas, Explícitas (Casting) e utilizando classes utilitárias (Parsing).

## 1. Conversões Implícitas e Explícitas (Casting Numérico)

Como o C# tem vários tipos numéricos diferentes, converter entre eles é uma operação comum.

* **Conversão Implícita:** Ocorre automaticamente quando convertemos um tipo menor para um tipo maior, sem risco de perda de dados.
    ```csharp
    int numeroPequeno = 100;
    double numeroGrande = numeroPequeno; // Implícito, o C# faz sozinho
    ```
* **Conversão Explícita (Casting):** Ocorre quando convertemos um tipo maior para um menor. Como há risco de perda de dados (ex: perder casas decimais), o C# obriga você a declarar a conversão usando parênteses `(tipo)`.
    ```csharp
    double valorDecimal = 9.99;
    int valorInteiro = (int)valorDecimal; // Explícito. Resultado: 9 (as casas decimais são cortadas)
    ```

## 2. Conversão para String (String Conversion)

A conversão para string acontece quando precisamos da forma de texto de um valor. 

No C#, em vez de usar uma função global como o `String(value)` do JavaScript, quase todos os tipos possuem o método nativo `.ToString()`.

```csharp
int idade = 25;
bool ativo = true;

string idadeTexto = idade.ToString(); // "25"
string ativoTexto = ativo.ToString(); // "True"
```

## 3. Conversão Numérica (Parsing)

A conversão explícita é geralmente necessária quando lemos um valor de uma fonte baseada em texto, como um formulário, mas esperamos que um número seja inserido.

Em linguagens dinâmicas, se a string não for um número válido, o resultado dessa conversão é frequentemente `NaN`. **No C#, tentar converter um texto inválido resultará na quebra do programa (uma *Exception*).**

Para converter strings em números, usamos o método `.Parse()` ou a classe `Convert`:

```csharp
string textoValido = "123";
int numero = int.Parse(textoValido); // Torna-se o número 123
```

**Segurança em primeiro lugar (`TryParse`):**
Para evitar que o programa quebre ao tentar converter uma string como `"abc"`, o C# oferece o padrão `.TryParse()`. Ele tenta fazer a conversão e retorna um booleano dizendo se conseguiu ou não, em vez de gerar um erro.

```csharp
string entradaUsuario = "texto invalido";
bool sucesso = int.TryParse(entradaUsuario, out int resultado);
// sucesso será 'false' e 'resultado' será 0. O programa não quebra.
```

## 4. Conversão Booleana (Boolean Conversion)

A conversão booleana acontece em operações lógicas. 

Em linguagens baseadas em ECMAScript, valores que são intuitivamente "vazios", como `0`, uma string vazia, `null` e `undefined`, se tornam `false`, e outros valores se tornam `true`.

**No C#, o conceito de "Truthy" e "Falsy" NÃO existe!**
O C# não avalia números ou strings como booleanos em estruturas de condição. Uma instrução matemática nunca será tratada como um valor lógico.

```csharp
// EM OUTRAS LINGUAGENS ISSO É VÁLIDO:
// if (1) { ... } 
// if ("hello") { ... }

// NO C#, ISSO NÃO COMPILA. DEVE SER UMA AVALIAÇÃO EXPLICITAMENTE BOOLEANA:
int valor = 1;
if (valor == 1) { /* Correto */ } 
```

Se você precisar converter uma string explícita para booleano, deve usar `bool.Parse()`, que aceitará apenas `"True"` ou `"False"`.

## Resumo

As três conversões de tipo mais amplamente usadas são para string, para número e para booleano. No C#, lidamos com elas de forma robusta e segura:

* **Para String:** Usamos o método `.ToString()` disponível nos objetos.
* **Para Número:** Usamos cast `(int)valor` para numéricos, ou `int.Parse()` / `int.TryParse()` para textos.
* **Para Booleano:** O C# exige verificações estritas (como `variavel != null` ou `numero > 0`). Não existem conversões automáticas de inteiros ou strings para booleanos em fluxos de controle.