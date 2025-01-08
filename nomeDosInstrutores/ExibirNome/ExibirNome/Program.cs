// See https://aka.ms/new-console-template for more information

//string curso = "C#: criando sua primeira aplicação";
//string nome = "Guilherme";
//string sobrenome = "Lima";

//Console.WriteLine(curso);

//Console.WriteLine($"{nome} {sobrenome}");

float notaMedia = 5;

List<string> linguagens = new List<string>
{
    "C#",
    "Java",
    "JavaScript"
};

void ExibirNota()
{
    if (notaMedia >= 5)
    {
        Console.WriteLine("Nota suficiente para aprovação");
    }
    else
    {
        Console.WriteLine("Nota insuficiente para aprovação");
    }
}


void ExibirCS()
{
    Console.WriteLine(linguagens[0]);
}

void ExibirQualquerLista()
{
    Console.WriteLine("Digite um número de 1 até " + (linguagens.Count));
    int numero = int.Parse(Console.ReadLine()!);
    numero -= 1;

    if(numero >= linguagens.Count)
    {
        Console.WriteLine("Número inválido");
    }
    else
    {
        Console.WriteLine(linguagens[numero]);
    }
}
Console.WriteLine("A média é: " + notaMedia);
ExibirNota();
Console.WriteLine();
ExibirCS();
Console.WriteLine();
ExibirQualquerLista();