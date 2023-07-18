class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artisa: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if(disponivel)
        {
            Console.WriteLine($"Disponivel no plano: {disponivel}");
        }
        else
        {
            Console.WriteLine("Adiquira o plano  PLUS+!");
        }
        Console.WriteLine();
    }
}