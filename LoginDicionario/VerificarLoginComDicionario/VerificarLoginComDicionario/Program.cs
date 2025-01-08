// Dicionário contendo os logins e senhas. A chave é o nome do usuário e o valor é a senha.
Dictionary<string, string> LoginSenha = new Dictionary<string, string>
{
    { "Jonathan", "AsFd" } // Exemplo de login com senha
};

// Função que verifica o login e senha do usuário
void VerificarLogin()
{
    bool logado = false; // Flag para controlar se o usuário foi autenticado com sucesso

    // Loop que continua até o usuário inserir um login e senha válidos
    do
    {
        Console.Clear(); // Limpa a tela para cada tentativa
        Console.Write("Digite o nome de usuário: ");
        string login = Console.ReadLine()!; // Lê o nome de usuário digitado

        // Verifica se o nome de usuário existe no dicionário
        if (LoginSenha.ContainsKey(login))
        {
            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine()!; // Lê a senha digitada

            // Compara a senha digitada com a senha armazenada no dicionário
            if (LoginSenha[login] != senha)
            {
                Console.WriteLine("\nSenha incorreta"); // Mensagem de erro se a senha estiver errada
                Console.WriteLine("\nPressione uma tecla para continuar");
                Console.ReadKey(); // Aguarda o usuário pressionar uma tecla para tentar novamente
            }
            else
            {
                Console.WriteLine("\nBem-vindo!"); // Mensagem de sucesso se a senha estiver correta
                Console.WriteLine("\nPressione uma tecla para continuar");
                Console.ReadKey(); // Aguarda o usuário pressionar uma tecla antes de prosseguir
                logado = true; // Define a flag como true para sair do loop
            }
        }
        else
        {
            Console.WriteLine("\nLogin incorreto"); // Mensagem de erro se o login não for encontrado
            Console.WriteLine("\nPressione uma tecla para continuar");
            Console.ReadKey(); // Aguarda o usuário pressionar uma tecla para tentar novamente
        }
    } while (!logado); // Repete o loop até que o login seja bem-sucedido
}

// Inicia a função de verificação de login
VerificarLogin();
