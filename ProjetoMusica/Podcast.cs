class Podcast
{

    private List<Episodio> episodios = new();
    public Podcast(string nome, string host, int totalDeEpisódios)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalDeEpisódios => episodios.Count;

    public void adicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"PodCast: {Nome} apresentado por {Host}\n");
        foreach (var ep in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(ep.Resumo);
        }
        Console.WriteLine($"\nEsse podcast possui {TotalDeEpisódios} episódios.");
    }
}