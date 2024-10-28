class Podcast
{
    private List<Episodio> episodios = new(); // Declara uma lista privada de episódios.

    public Podcast(string nome, string host)
    {
        Nome = nome; // Define o valor da propriedade Nome com o valor passado como parâmetro.
        Host = host; // Define o valor da propriedade Host com o valor passado como parâmetro.
    }

    public Podcast() { } // Construtor vazio, não faz nada.

    public string Host { get; set; } // Declara uma propriedade Host com getter e setter.
    public string Nome { get; set; } // Declara uma propriedade Nome com getter e setter.
    public int TotalEpisodios => episodios.Count; // Declara uma propriedade somente leitura TotalEpisodios que retorna a contagem de episódios na lista.

    public void AdicionarEpisodios(Episodio episodio)
    {
        episodios.Add(episodio); // Adiciona um episódio à lista.
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast | {Nome} | \n Apresentado por: {Host}\n"); // Exibe o nome do podcast e o apresentador.

        foreach (Episodio ep in episodios)
        {
            Console.WriteLine(ep.Resumo); // Exibe o resumo de cada episódio na lista.
        }

        Console.WriteLine($"\n\n Total de Episodios: {TotalEpisodios}.\n\n"); // Exibe o total de episódios na lista.
    }
}
