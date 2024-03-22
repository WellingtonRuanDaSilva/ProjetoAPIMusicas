using ProjetoAPIMusicas.Filtros;
using ProjetoAPIMusicas.Modelos;
using System.Text.Json;


using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        //teste Tonalidade
        //musicas[1].ExibirDetalhesDaMusica();

        //teste Filtros
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");

        
        //teste verificar musicas
        //var musicaPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        //musicaPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        //musicaPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
        //musicaPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        //musicaPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
        //musicaPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);
        //musicaPreferidasDoDaniel.ExibirMusicasFavoritas();

        //teste Verificar Musicas e Criar arquivo JSON
        //var musicaPreferidasDoEmilly = new MusicasPreferidas("Emy");
        //musicaPreferidasDoEmilly.AdicionarMusicasFavoritas(musicas[500]);
        //musicaPreferidasDoEmilly.AdicionarMusicasFavoritas(musicas[637]);
        //musicaPreferidasDoEmilly.AdicionarMusicasFavoritas(musicas[428]);
        //musicaPreferidasDoEmilly.AdicionarMusicasFavoritas(musicas[13]);
        //musicaPreferidasDoEmilly.AdicionarMusicasFavoritas(musicas[71]);
        //musicaPreferidasDoEmilly.ExibirMusicasFavoritas();
        //musicaPreferidasDoEmilly.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}