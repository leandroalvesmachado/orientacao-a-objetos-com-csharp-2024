class Aluno
{
    // 1º Maneira
    private string? _nome;
    public string? Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    // 2º Maneira
    public double Media { get; set; }
}