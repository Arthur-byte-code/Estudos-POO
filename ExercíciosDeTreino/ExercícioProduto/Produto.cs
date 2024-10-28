using System;

class Produto
{
    //Lembrete sobre o get e set: 
    //Get é para obter o valor em determinada variavel
    //Set é para enviar valor para determinada variavel
    //O private no set significa que a classe program não pode alterar a variavel



    // Atributos da classe Produto
    public string Nome { get; private set; }// A classe program só pode obter o valor de Nome, mas não altera-lo
    public double Preco { get; private set; }// A classe program só pode obter o valor de Preco, mas não altera-lo
    public int Quantidade { get; private set; }// // A classe program só pode obter o valor de Quantidade, mas não altera-lo

    // Construtor padrão
    public Produto()
    {
        Console.WriteLine("Bem vindo ao sistema de produtos");
    }

    // Método para adicionar um produto
    public void Adicionar()
    {
        Console.WriteLine("Diga o nome do produto");
        Nome = Console.ReadLine();

        Console.WriteLine("Diga o preço");
        Preco = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Diga a quantidade");
        Quantidade = Convert.ToInt32(Console.ReadLine());
    }

    // Método para exibir as informações do produto
    public void Exibir()
    {
        Console.WriteLine("-----------------------------------------------------");

        Console.WriteLine($"Nome do produto: {Nome}");
        Console.WriteLine($"Preço do produto: R$ {Preco:F2}");
        Console.WriteLine($"Quantidade do produto: {Quantidade}");
        Console.WriteLine("-----------------------------------------------------");


    }

    // Método para adicionar itens ao estoque
    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            Quantidade += quantidade;
            Console.WriteLine($"{quantidade} unidades adicionadas ao estoque. Estoque atual: {Quantidade}");
        }
        else
        {
            Console.WriteLine("Quantidade inválida para adicionar ao estoque.");
        }
    }

    // Método para remover itens do estoque
    public void RemoverEstoque(int quantidade)
    {
        if (quantidade > 0 && quantidade <= Quantidade)
        {
            Quantidade -= quantidade; //A quantidade em estoque é diminuída pelo valor de quantidade
            Console.WriteLine($"{quantidade} unidades removidas do estoque. Estoque atual: {Quantidade}");
        }
        else if (quantidade > Quantidade)
        {
            Console.WriteLine("Quantidade insuficiente em estoque para remover.");
        }
        else
        {
            Console.WriteLine("Quantidade inválida para remover do estoque.");
        }
    }
}