Episodios ep1 = new(45, 1, "Tecnicas de facilitação");
ep1.AdicionarConvidados("Allan");
ep1.AdicionarConvidados("Felipe");
Console.WriteLine(ep1.Resumo);

Episodios ep2 = new(56, 2, "Tecnicas de aprendizado");
ep2.AdicionarConvidados("Thais");
ep2.AdicionarConvidados("Thomas");

Podcast podcast = new Podcast("Podcast Epecial", "Allan");
podcast.AdicionarEpisodios(ep1);
podcast.AdicionarEpisodios(ep2);
podcast.ExibirDetalhes();