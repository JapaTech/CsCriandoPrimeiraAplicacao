// Define um dicionário chamado Estoque que armazena produtos como chave (string) e sua quantidade no estoque como valor (int)
Dictionary<string, int> Estoque = new Dictionary<string, int> {
    { "TV", 20 },                 // Adiciona "TV" com quantidade 20
    { "Radio", 5 },               // Adiciona "Radio" com quantidade 5
    { "Notebook", 10 },           // Adiciona "Notebook" com quantidade 10
    { "PC", 10 },                 // Adiciona "PC" com quantidade 10
    { "Fone de Ouvido", 10 }      // Adiciona "Fone de Ouvido" com quantidade 10
};

// Método para verificar a quantidade de produtos no estoque
void VerificarQuantidade()
{
    string nome = string.Empty;  // Variável para armazenar o nome do produto a ser pesquisado

    do
    {
        Console.Clear();         // Limpa a tela do console
        Console.WriteLine("CONSULTA DOS PRODUTOS NO ESTOQUE\n");
        Console.WriteLine("LISTA DOS PRODUTOS");
        Console.WriteLine("------------------");

        // Exibe a lista de produtos no estoque
        foreach (var item in Estoque)
        {
            Console.WriteLine(item.Key);  // Exibe o nome de cada produto
        }

        // Solicita ao usuário o nome do produto ou a opção de sair
        Console.Write("\nDigite o nome do produto ou escreva -1 para sair: ");
        nome = Console.ReadLine()!;       // Lê o input do usuário (não nulo devido ao uso do '!')

        if (nome == "-1")                // Se o usuário digitar "-1", encerra o loop
            break;

        // Procura o produto no estoque (ignora diferença entre maiúsculas e minúsculas)
        var produto = Estoque.Keys.FirstOrDefault(key => string.Equals(key, nome, StringComparison.OrdinalIgnoreCase));

        if (produto != null) // Se o produto foi encontrado
        {
            Console.WriteLine("\n-----------------------------------------------------------------");
            Console.WriteLine($"O produto {produto} tem {Estoque[produto]} unidade(s) no estoque");  // Exibe a quantidade no estoque
            Console.WriteLine("-----------------------------------------------------------------");
        }
        else // Se o produto não foi encontrado
        {
            Console.WriteLine("Produto não encontrado");  // Exibe mensagem de erro
        }

        Console.WriteLine("\nDigite qualquer tecla para continuar"); // Pausa antes de voltar ao menu
        Console.ReadKey();          // Aguarda o usuário pressionar qualquer tecla
    }
    while (true);                   // Continua no loop até que o usuário digite "-1"
}

// Chama o método para executar a consulta
VerificarQuantidade();