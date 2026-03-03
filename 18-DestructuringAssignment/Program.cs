Console.WriteLine("=== ESTUDO DE DESESTRUTURAÇÃO (DECONSTRUCTION) EM C# ===\n");

// 1. Desestruturando Tuplas
Console.WriteLine("1. Tuplas:");
var transacao = ("TX-9981", 1500.50m, "Aprovada");

// Extraindo dados para variáveis locais
var (id, valor, status) = transacao;
Console.WriteLine($"Transação {id} com valor {valor:C} está {status}.\n");

// 2. Usando o Discard (_) para ignorar valores
Console.WriteLine("2. Omitindo valores (Discard):");
var (_, valorExtraido, _) = transacao; // Ignoramos o ID e o Status
Console.WriteLine($"Foco apenas no valor: {valorExtraido:C}\n");

// 3. Desestruturando Records (Objetos)
Console.WriteLine("3. Records:");
Usuario user = new Usuario("João Silva", "joao@email.com", 30);

// A desconstrução de Record usa a ordem definida na criação dele
var (nome, email, _) = user; // Ignoramos a idade
Console.WriteLine($"Usuário: {nome} | Contato: {email}\n");

// 4. Desestruturação de Arrays (List Patterns - C# 11+)
Console.WriteLine("4. Arrays e o operador 'Rest' (..):");
string[] logs = { "ERRO", "Falha de conexão", "Detalhe 1", "Detalhe 2" };

// Verifica se o array tem o formato esperado e desestrutura
if (logs is [var nivel, var mensagemPrincipal, .. var detalhesRestantes])
{
    Console.WriteLine($"[{nivel}]: {mensagemPrincipal}");
    Console.WriteLine($"Temos mais {detalhesRestantes.Length} detalhes adicionais ocultos.");
}

Console.WriteLine("\n=== FIM DO EXEMPLO ===");

// Declaração do Record posicional
public record Usuario(string Nome, string Email, int Idade);