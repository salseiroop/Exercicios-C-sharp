// 1. Criando a Banda
Banda juiceWorld = new("Juice WRLD");

// 2. Criando o Álbum e a Música
Album album1 = new("Goodbye & Good Riddance");

Musica lucidDreams = new(juiceWorld, "Lucid Dreams")
{
    Duracao = 240,
    Disponivel = true
};

// 3. Relacionando os objetos (Adicionando música ao álbum e álbum à banda)
album1.AdicionarMusica(lucidDreams);
juiceWorld.AdicionarAlbum(album1);

// 4. Imprimindo de forma organizada na tela
Console.WriteLine("========================================");
Console.WriteLine(lucidDreams.DescricaoResumida);
Console.WriteLine("========================================");

// Exibindo a ficha técnica da música
lucidDreams.ExibirFichaTecnica();

Console.WriteLine("========================================");

// Exibindo a discografia da banda
juiceWorld.ExibirDiscografia();

// Exibindo as músicas detalhadas do álbum
Console.WriteLine();
album1.ExibirMusicas();
Console.WriteLine("========================================");