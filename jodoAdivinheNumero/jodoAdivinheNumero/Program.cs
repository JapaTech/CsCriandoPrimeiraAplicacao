// Função que sorteia um número aleatório entre 0 e 100
int SortearNumero()
{
    Random rnd = new Random(); // Cria uma instância do gerador de números aleatórios
    return rnd.Next(101);      // Gera um número aleatório entre 0 (inclusivo) e 101 (exclusivo)
}

// Função principal do jogo
void Jogo()
{
    // Sorteia o número que o jogador deve adivinhar
    int numeroSorteado = SortearNumero();
    int numeroDoJogador; // Variável para armazenar o número que o jogador digitará

    // Loop principal do jogo
    do
    {
        // Solicita ao jogador que digite um número
        Console.Write("Digite um número entre 0 e 100: ");
        numeroDoJogador = int.Parse(Console.ReadLine()!); // Converte a entrada para inteiro

        // Verifica se o número digitado é maior que o número sorteado
        if (numeroDoJogador > numeroSorteado)
        {
            Console.WriteLine("O número que você digitou é MAIOR");
        }
        // Verifica se o número digitado é menor que o número sorteado
        else if (numeroDoJogador < numeroSorteado)
        {
            Console.WriteLine("O número que você digitou é MENOR!");
        }

        Console.WriteLine(); // Adiciona uma linha em branco para melhor formatação
    }
    // Continua o loop enquanto o jogador não acertar o número sorteado
    while (numeroSorteado != numeroDoJogador);

    // Exibe mensagem de vitória quando o jogador acerta o número
    Console.WriteLine("Você venceu! O número escolhido é " + numeroSorteado);
}

// Inicia o jogo
Jogo();
