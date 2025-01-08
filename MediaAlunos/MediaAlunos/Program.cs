// Define um dicionário para armazenar as notas de alunos em diferentes matérias
var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>>
{
    { "Ana", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 8, 7, 6 } },         // Notas de Ana na matéria C#
        { "Java", new List<int> { 7, 6, 5 } },       // Notas de Ana na matéria Java
        { "Python", new List<int> { 9, 8, 8 } }      // Notas de Ana na matéria Python
    }},
    { "Maria", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 6, 5, 4 } },         // Notas de Maria na matéria C#
        { "Java", new List<int> { 8, 7, 6 } },       // Notas de Maria na matéria Java
        { "Python", new List<int> { 6, 10, 5 } }     // Notas de Maria na matéria Python
    }},
    { "Luiza", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 2, 3, 10 } },        // Notas de Luiza na matéria C#
        { "Java", new List<int> { 8, 8, 8 } },       // Notas de Luiza na matéria Java
        { "Python", new List<int> { 7, 7, 7 } }      // Notas de Luiza na matéria Python
    }}
};

// Itera sobre o dicionário para exibir as informações dos alunos
foreach (var aluno in notasAlunos)
{
    // Exibe o nome do aluno
    Console.WriteLine($"Aluno(a) {aluno.Key}");

    // Itera sobre as matérias e suas respectivas listas de notas
    foreach (var materia in aluno.Value)
    {
        // Calcula a média das notas da matéria e exibe o nome da matéria e a média
        Console.WriteLine($"{materia.Key}: Média = {materia.Value.Average().ToString("F2")}");
        // `Average()` calcula a média dos valores da lista
        // `ToString("F2")` formata o número com duas casas decimais
    }

    Console.WriteLine(); // Linha em branco para separar os alunos
}
