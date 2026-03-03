using System;

Console.WriteLine("=== ESTUDO DE STRUCT, RECORD E DELEGATE ===\n");

// ==========================================
// 1. TESTANDO STRUCT (Cópia por Valor)
// ==========================================
Console.WriteLine("1. Structs:");
Coordenada pontoA = new Coordenada(10, 20);
Coordenada pontoB = pontoA; // Copia os valores, não a referência!

pontoB.X = 99; // Alterar o pontoB NÃO afeta o pontoA

Console.WriteLine($"Ponto A: X={pontoA.X}, Y={pontoA.Y}");
Console.WriteLine($"Ponto B: X={pontoB.X}, Y={pontoB.Y} (Totalmente independente)\n");

// ==========================================
// 2. TESTANDO RECORD (Imutabilidade e Igualdade)
// ==========================================
Console.WriteLine("2. Records:");
Transacao t1 = new Transacao(1, 150.00m, "Compra Online");
Transacao t2 = new Transacao(1, 150.00m, "Compra Online");

// Em uma Class normal, t1 == t2 seria FALSE. No Record, é TRUE!
Console.WriteLine($"Transação 1 é idêntica à Transação 2? {t1 == t2}");

// Tentativa de alterar t1.Valor diretamente daria erro de compilação (é imutável).
// Em vez disso, criamos uma nova transação baseada na primeira:
Transacao t3 = t1 with { Valor = 200.00m };
Console.WriteLine($"Transação 3 (Cópia alterada): {t3}\n"); // Records já vêm com ToString() formatado!

// ==========================================
// 3. TESTANDO DELEGATE
// ==========================================
Console.WriteLine("3. Delegates:");

// Atribuindo um método a uma variável do tipo do nosso delegate
ProcessadorDeMensagem processador = MostrarMensagemNoConsole;

// Chamando o método através do delegate
processador("Esta mensagem passou por um delegate customizado!");

Console.WriteLine("\n=== FIM DO EXEMPLO ===");

// ==========================================
// DECLARAÇÕES (Geralmente ficam em arquivos separados)
// ==========================================

// Struct
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

// Record (Declaração posicional - Cria construtor, propriedades e métodos de igualdade automaticamente)
public record Transacao(int Id, decimal Valor, string Descricao);

// Delegate
public delegate void ProcessadorDeMensagem(string mensagem);

// Método compatível com o Delegate
void MostrarMensagemNoConsole(string msg)
{
    Console.WriteLine($"[LOG]: {msg}");
}