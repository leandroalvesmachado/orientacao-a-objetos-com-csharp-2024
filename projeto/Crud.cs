class Crud : Padrao
{
    public override void Alterar()
    {
        // Listar o índice e o nome das pessoas
        Console.WriteLine("Informe o código da pessoa que deseja alterar os dados");
        for (int indice = 0; indice < Armazenamento.Pessoas.Count; indice++)
        {
            Console.WriteLine($"{indice+1}) {Armazenamento.Pessoas[indice].Nome}");
        }

        int codigo = Convert.ToInt16(Console.ReadLine());

        // Criar objeto Pessoa
        Pessoa p = new();

        // Obter o nome, cidade e idade
        Console.WriteLine("Informe o nome");
        p.Nome = Console.ReadLine();

        Console.WriteLine("Informe a cidade");
        p.Cidade = Console.ReadLine();

        Console.WriteLine("Informe a idade");
        p.Idade = Convert.ToInt16(Console.ReadLine());

        // Alterar lista
        Armazenamento.Pessoas[codigo-1] = p;

    }

    public override void Cadastrar()
    {
        // Criar objeto Pessoa
        Pessoa p = new();

        // Obter o nome, cidade e idade
        Console.WriteLine("Informe o nome");
        p.Nome = Console.ReadLine();

        Console.WriteLine("Informe a cidade");
        p.Cidade = Console.ReadLine();

        Console.WriteLine("Informe a idade");
        p.Idade = Convert.ToInt16(Console.ReadLine());

        // Cadastrar o objeto Pessoa na lista
        Armazenamento.Pessoas.Add(p);
    }

    public override void Remover()
    { 
        // Listar o índice e o nome das pessoas
        Console.WriteLine("Informe o código da pessoa que deseja remover os dados");
        for (int indice = 0; indice < Armazenamento.Pessoas.Count; indice++)
        {
            Console.WriteLine($"{indice+1}) {Armazenamento.Pessoas[indice].Nome}");
        }
        
        int codigo = Convert.ToInt16(Console.ReadLine());

        // Remover objeto Pessoa da lista
        Armazenamento.Pessoas.RemoveAt(codigo-1);
    }

    public override void Selecionar()
    {
        // Laço de repetição
        for (int indice = 0; indice < Armazenamento.Pessoas.Count; indice++)
        {
            Console.WriteLine($"Nome: {Armazenamento.Pessoas[indice].Nome}");
            Console.WriteLine($"Cidade: {Armazenamento.Pessoas[indice].Cidade}");
            Console.WriteLine($"Idade: {Armazenamento.Pessoas[indice].Idade}");
            Console.WriteLine("");
        }
    }
}