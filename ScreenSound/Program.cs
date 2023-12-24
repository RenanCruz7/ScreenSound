Banda leall = new Banda("LEALL");

Album albumDoLeall = new Album("Eu Ainda Tenho Coração");

Musica musica1 = new Musica(leall, "Eu ainda Tenho Coração")
{
    Duracao = 201,
    Disponivel = true,
};

Musica musica2 = new Musica(leall, "Medo de Quase Nada")
{
    Duracao = 245,
    Disponivel = true,
};

albumDoLeall.AdicionarMusica(musica1);
albumDoLeall.AdicionarMusica(musica2);

leall.AdidicionarAlbum(albumDoLeall);
leall.ExibirDiscografia();