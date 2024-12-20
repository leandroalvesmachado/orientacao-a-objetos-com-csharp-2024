// Herança
class Colaborador : Pessoa
{
    // Atributos privados
    // Utilizar o _
    private string? _cargo;
    private double _salario;

    // Construtor
    // base(nome, idade) esta enviando para a classe base (Pessoa) esses dois parâmetros
    public Colaborador(string nome, int idade, string cargo, double salario) : base(nome, idade)
    {
        _cargo = cargo;
        _salario = salario;

        ApresentarPessoa();
        ApresentarColaborador();
    }

    // Método para apresentar os dados
    private void ApresentarColaborador()
    {
        Console.WriteLine($"Cargo: {_cargo}");
        Console.WriteLine($"Salário: {_salario}");
    }
}