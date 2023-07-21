class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A musica {Nome} pertence a banda: {Artista}";

    public void ExibirFichaTecnica()
    {

        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artisa: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if(Disponivel)
        {
            Console.WriteLine($"Disponivel no plano: {Disponivel}");
        }
        else
        {
            Console.WriteLine("Adiquira o plano  PLUS+!");
        }
        Console.WriteLine();
    }
}