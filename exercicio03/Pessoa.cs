
class Pessoa
{
    // Atributos privados começam com _
    private string? _nome { get; set; }
    private int _idade { get; set; }
    private string? _cidade { get; set; }

    // Construtor
    public Pessoa(string nome, int idade, string cidade)
    {
        _nome = nome;
        _idade = idade;
        _cidade = cidade;

        Mensagem();
    }

    private void Mensagem()
    {
        Console.WriteLine($"{_nome} mora  {_cidade} e tem {_idade} ano(s)");
    }
}