class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A musica {Nome} pertence a banda: {Artista}";
    public void ExibirFichaTecnica()
    {
        Musica musica1 = new Musica();
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artisa: {Artista}");
        Console.WriteLine($"Duração: {Disponivel}");
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