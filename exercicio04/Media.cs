class Media
{
    public Media(double nota1, double nota2)
    {
        Console.WriteLine($"A média é {(nota1 + nota2) / 2}");
    }

    public Media(double nota1, double nota2, double nota3)
    {
        Console.WriteLine($"A média é {(nota1 + nota2 + nota3) / 3}");
    }
}