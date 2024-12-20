class Aluno
{
    public string? Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }

    private double Media()
    {
        return (Nota1 + Nota2) / 2;
    }

    private string Situacao(double media)
    {
        return media >= 7 ? "Aprovado" : "Reprovado";
    }

    public void Mensagem()
    {
        double obterMedia = Media();
        string obterSituacao = Situacao(obterMedia);

        Console.WriteLine($"{Nome} está {obterSituacao} com média {obterMedia}");
    }
}