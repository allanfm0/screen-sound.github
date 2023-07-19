Musica musica = new Musica();
musica.Nome = "Do i wanna know?";
musica.Artista = "Artic Monkeys";
musica.Duracao = 273;
musica.Disponivel = true;
Console.WriteLine(musica.DescricaoResumida);

Musica musica2 = new Musica();
musica2.Nome = "bellyache";
musica2.Artista = "bille eilsh";
musica2.Duracao = 367;
musica2.Disponivel = false; 
Console.WriteLine(musica2.DescricaoResumida);

musica.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
