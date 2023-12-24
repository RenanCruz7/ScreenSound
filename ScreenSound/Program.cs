Banda leall = new Banda();
leall.Nome = "LEALL";

Album albumDoLeall = new Album();
albumDoLeall.Nome = "Eu Ainda Tenho Coração";

Musica musica1 = new Musica(leall);
musica1.Nome = "Eu ainda Tenho Coração";
musica1.Duracao = 201;

Musica musica2 = new Musica(leall);
musica2.Nome = "Medo de Quase Nada";
musica2.Duracao = 245;

albumDoLeall.AdicionarMusica(musica1);
albumDoLeall.AdicionarMusica(musica2);


leall.AdidicionarAlbum(albumDoLeall);
leall.ExibirDiscografia();