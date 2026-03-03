Console.WriteLine("=== ESTUDO DO OPERADOR DE COALESCÊNCIA NULA (??) EM C# ===\n");

// 1. Fornecendo um valor padrão para Strings
Console.WriteLine("1. Strings (Tipos de Referência):");
string nomeDoBancoDeDados = null;
string nomeExibicao = nomeDoBancoDeDados ?? "Usuário Desconhecido";
Console.WriteLine($"Nome a exibir: {nomeExibicao}\n");

// 2. Trabalhando com Tipos de Valor Anuláveis (Nullable Types)
Console.WriteLine("2. Números Anuláveis (int?):");
int? quantidadeEmEstoque = null;
// Se o estoque for null, assumimos que é 0 para o cálculo
int quantidadeParaCalculo = quantidadeEmEstoque ?? 0;
Console.WriteLine($"Quantidade em estoque para cálculo: {quantidadeParaCalculo}\n");

// 3. Encadeamento de múltiplos ??
Console.WriteLine("3. Encadeamento:");
string configuracaoUsuario = null;
string configuracaoSistema = null;
string configuracaoPadrao = "Tema Escuro";

string temaEscolhido = configuracaoUsuario ?? configuracaoSistema ?? configuracaoPadrao;
Console.WriteLine($"O tema aplicado será: {temaEscolhido}\n");

// 4. Atribuição de Coalescência Nula (??=)
Console.WriteLine("4. Atribuição de Coalescência Nula (??=):");
string mensagem = null;

mensagem ??= "Mensagem gerada pelo sistema."; // Atribui, pois é null
Console.WriteLine(mensagem);

mensagem ??= "Tentando sobrescrever..."; // Ignora, pois já não é mais null
Console.WriteLine(mensagem);

Console.WriteLine("\n=== FIM DO EXEMPLO ===");