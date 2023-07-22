class Podcast 
{
    private List<Episodios> episodios = new();
    public Podcast(string nome, string host)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get;}
    public string Nome { get;}

    public int TotalDeEpisodios => episodios.Count;


    public void AdicionarEpisodios(Episodios episodio)
    {
        episodios.Add(episodio);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast >|{Nome}|< apresentado por [{Host}]\n");

        foreach (Episodios episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nTotal de episódios: {TotalDeEpisodios}.");
    }
}

