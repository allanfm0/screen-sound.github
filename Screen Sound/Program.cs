Album albumDoQueen =  new Album();
albumDoQueen.Nome = "A nigth at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of My life";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.Nome = "Bohemiam Rhapsody";
musica2.Duracao = 345;

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicasDoAlbum();