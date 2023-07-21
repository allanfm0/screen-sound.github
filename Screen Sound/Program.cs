Banda queen = new Banda("Queen");
Album albumDoQueen =  new Album("A nigth at the opera");


Musica musica1 = new Musica(queen, "Love of My life")
{
    Duracao = 213,
    Disponivel = true,
};


Musica musica2 = new Musica(queen, "Bohemiam Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionaAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();


queen.AdicionaAlbum(albumDoQueen);
queen.ExibirDiscografia();