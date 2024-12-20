abstract class Acao
{
    // Métodos obrigatórios para as classes que vão herdar
    public abstract void Falar();
    public abstract void Andar();

    // Métodos opcionais para as classes que vão herdar
    public void Pular()
    {
        Console.WriteLine("Estou pulando...");
    }
}