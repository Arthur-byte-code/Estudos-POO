class Episodio
{
    // Declaração da classe Episodio.

    private List<string> convidados = new List<string>();
    // Declaração de uma lista privada de strings chamada "convidados" para armazenar os nomes dos convidados do episódio.

    public Episodio(int ordem, string titulo, int duracao)
    {
        // Construtor da classe Episodio com parâmetros.

        Ordem = ordem;
        // Atribui o valor do parâmetro 'ordem' à propriedade 'Ordem'.

        Titulo = titulo;
        // Atribui o valor do parâmetro 'titulo' à propriedade 'Titulo'.

        Duracao = duracao;
        // Atribui o valor do parâmetro 'duracao' à propriedade 'Duracao'.
    }

    public Episodio() { }
    // Construtor da classe Episodio sem parâmetros.

    public int Ordem { get; set; }
    // Propriedade pública 'Ordem' com getter e setter.

    public string Titulo { get; set; }
    // Propriedade pública 'Titulo' com getter e setter.

    public int Duracao { get; set; }
    // Propriedade pública 'Duracao' com getter e setter.

    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";
    // Propriedade pública 'Resumo' que retorna uma string formatada com informações do episódio, incluindo a lista de convidados.

    public void AdiconarConvidados(string convidado)
    {
        // Método público para adicionar convidados à lista.

        convidados.Add(convidado);
        // Adiciona o nome do convidado à lista 'convidados'.
    }
}
