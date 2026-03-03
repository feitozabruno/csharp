# Estruturas de Repetição: while e for

Frequentemente precisamos repetir ações. Por exemplo, imprimir mercadorias de uma lista uma após a outra ou apenas executar o mesmo código para cada número de 1 a 10. 

*Loops* (laços) são uma maneira de repetir o mesmo código várias vezes.


## O laço "while"

O laço `while` tem a seguinte sintaxe:

```csharp
while (condicao) 
{
  // código
  // o chamado "corpo do laço"
}
```

Enquanto a `condicao` for verdadeira, o código do corpo do laço é executado. Uma única execução do corpo do laço é chamada de *iteração*.

**Atenção no C#:** Em linguagens dinâmicas, qualquer expressão ou variável pode ser uma condição de laço, não apenas comparações (ex: `while (i)` para rodar enquanto `i` não for zero). No C#, isso não é permitido. A condição **deve** ser uma expressão que retorne um booleano (`bool`):

```csharp
int i = 3;
while (i > 0) // No C#, a verificação precisa ser explícita
{
  Console.WriteLine(i);
  i--;
}
```

## O laço "do..while"

A verificação da condição pode ser movida para *abaixo* do corpo do laço usando a sintaxe `do..while`:

```csharp
do 
{
  // corpo do laço
} while (condicao);
```

O laço primeiro executará o corpo, depois verificará a condição e, enquanto for verdadeira, a executará repetidamente. Esta forma de sintaxe deve ser usada apenas quando você deseja que o corpo do laço seja executado **pelo menos uma vez**, independentemente da condição ser verdadeira.

## O laço "for"

O laço `for` é mais complexo, mas também é o laço mais comumente usado.

Ele se parece com isso:

```csharp
for (int i = 0; i < 3; i++) 
{
  Console.WriteLine(i);
}
```

Vamos examinar a instrução `for` parte por parte usando um exemplo que conta de 0 até 2:

* **Início (`int i = 0`):** Executa uma vez ao entrar no laço. A variável `i` declarada aqui é visível apenas dentro do laço.
* **Condição (`i < 3`):** Verificada antes de cada iteração do laço. Se falso, o laço para.
* **Corpo (`Console.WriteLine(i)`):** Executa repetidamente enquanto a condição for verdadeira.
* **Passo (`i++`):** Executa após o corpo em cada iteração.

## Quebrando o laço (break)

Normalmente, um laço sai quando sua condição se torna falsa. Mas podemos forçar a saída a qualquer momento usando a diretiva especial `break`.

A combinação "laço infinito + `break` conforme necessário" é ótima para situações em que a condição de um laço deve ser verificada não no início ou no fim, mas no meio ou até mesmo em vários lugares do seu corpo. Para criar um laço infinito, geralmente a construção `while (true)` é usada.

## Indo para a próxima iteração (continue)

A diretiva `continue` é uma "versão mais leve" do `break`. Ela não para o laço inteiro. Em vez disso, ela interrompe a iteração atual e força o laço a iniciar uma nova, caso a condição permita.

Podemos usá-la se terminarmos com a iteração atual e quisermos passar para a próxima. Isso ajuda a diminuir o aninhamento do código, evitando colocar grandes blocos dentro de instruções `if`.

## Rótulos (Labels) no C#

Às vezes, precisamos sair de vários laços aninhados de uma só vez. Algumas linguagens permitem o uso de *Labels* (rótulos) acoplados ao `break` (ex: `break outer`) para pular direto para fora de estruturas complexas.

**No C#, as regras são diferentes:** O uso de `break nomedorotulo` não existe. Para sair de múltiplos laços aninhados no C#, as melhores práticas recomendam:
1. Extrair os laços aninhados para um método separado e usar a palavra-chave `return`.
2. Usar uma variável booleana (flag) para sinalizar que os laços devem parar.
3. Usar a instrução `goto` (embora exista, seu uso é desencorajado por dificultar a leitura do fluxo do código).