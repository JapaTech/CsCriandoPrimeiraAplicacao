// Define um dicionário contendo perguntas e suas respectivas opções de resposta, onde cada resposta é associada a um valor booleano que indica se é correta (true) ou incorreta (false)
var Perguntas = new Dictionary<string, Dictionary<string, bool>>(StringComparer.OrdinalIgnoreCase)
{
    { "Quanto é 1 + 1 ?",
        new Dictionary<string, bool>(StringComparer.OrdinalIgnoreCase)
        {
            { "2", true },       // Resposta correta
            { "3", false },      // Resposta incorreta
            { "11", false },     // Resposta incorreta
            { "22", false }      // Resposta incorreta
        }
    },
    { "Qual é a capital do Brasil?",
        new Dictionary<string, bool>(StringComparer.OrdinalIgnoreCase)
        {
            { "Nova Iorque", false },  // Resposta incorreta
            { "Brasília", true },      // Resposta correta
            { "Lisboa", false },       // Resposta incorreta
            { "Tóquio", false }        // Resposta incorreta
        }
    },
    { "Qual destas cores está no arco-íris?",
        new Dictionary<string, bool>(StringComparer.OrdinalIgnoreCase)
        {
            { "Preto", false },  // Resposta incorreta
            { "Branco", false }, // Resposta incorreta
            { "Marrom", false }, // Resposta incorreta
            { "Azul", true }     // Resposta correta
        }
    }
};

// Função para sortear uma pergunta aleatória do dicionário
Dictionary<string, bool> SortearPerguta()
{
    Console.Clear(); // Limpa a tela do console

    // Cria uma lista com todas as chaves (perguntas) do dicionário
    var chaves = Perguntas.Keys.ToList();

    // Gera um número aleatório baseado na quantidade de perguntas
    Random rand = new Random();
    int indiceAleatorio = rand.Next(chaves.Count);

    // Obtém a pergunta correspondente ao índice sorteado
    string chaveAleatoria = chaves[indiceAleatorio];

    Console.WriteLine(chaveAleatoria); // Exibe a pergunta sorteada

    // Retorna o dicionário de respostas associado à pergunta sorteada
    return Perguntas[chaveAleatoria];
}

// Função para verificar se a resposta fornecida pelo usuário está correta
void VerificarResposta(Dictionary<string, bool> perguntaAleatoria)
{
    string opcoes = string.Empty; // Variável para armazenar as opções de resposta

    // Monta uma string com todas as opções de resposta
    foreach (var key in perguntaAleatoria)
    {
        opcoes += $"{key.Key}\n"; // Adiciona cada resposta como uma nova linha
    }
    Console.WriteLine($"\nOPÇÕES:\n{opcoes}"); // Exibe as opções

    Console.Write("Digite a opção correta: ");
    string resp = Console.ReadLine()!; // Lê a resposta do usuário (não nula devido ao uso do '!')

    // Verifica se a resposta fornecida está entre as opções
    if (perguntaAleatoria.ContainsKey(resp))
    {
        // Determina se a resposta está correta ou incorreta
        string jogadorAcertou = perguntaAleatoria[resp] == true ? "ACERTOU" : "ERROU";
        Console.WriteLine("\n***************************");
        Console.WriteLine($"Você {jogadorAcertou} a resposta!!!"); // Exibe o resultado
        Console.WriteLine("***************************");
    }
    else
    {
        Console.WriteLine("\nResposta inválida"); // Mensagem para respostas que não estão nas opções
    }

    Console.WriteLine("\nDigite qualquer coisa para continuar");
    Console.ReadKey(); // Aguarda o usuário pressionar qualquer tecla para continuar
}

// Função principal que executa o jogo
void Jogo()
{
    do
    {
        Console.Clear(); // Limpa a tela
        Console.WriteLine("Você quer jogar?");
        Console.WriteLine("----------------");
        Console.Write("Escreva \"Sim\" para jogar ou \"Não\" para sair: ");
        string resp = Console.ReadLine()!; // Lê a resposta do usuário

        if (resp.ToLower() == "sim") // Se o usuário quiser jogar
        {
            Console.WriteLine();
            VerificarResposta(SortearPerguta()); // Sorteia uma pergunta e verifica a resposta
        }
        else if (resp.ToLower() == "não" || resp.ToLower() == "nao") // Se o usuário quiser sair
        {
            break; // Encerra o loop
        }
        else
        {
            Console.WriteLine("Resposta inválida"); // Mensagem para respostas inválidas
            Console.WriteLine("\nDigite qualquer coisa para continuar");
            Console.ReadKey(); // Pausa antes de voltar ao menu
        }

    } while (true); // Continua no loop até que o usuário escolha sair
}

// Inicia o jogo chamando a função principal
Jogo();
