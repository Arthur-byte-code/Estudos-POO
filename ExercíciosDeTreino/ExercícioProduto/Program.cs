class Program
{
    static void Main()
    {
        // Criando uma instância da classe Produto
        Produto p = new Produto();
        p.Adicionar();
        p.Exibir();
        

        // Adicionando e removendo itens do estoque
        p.AdicionarEstoque(4);
        p.RemoverEstoque(5);
        p.RemoverEstoque(10);

        // Exibindo novamente para verificar as mudanças no estoque
        p.Exibir();

        Console.WriteLine("Aqui está  a prova de que a classe program só consegue ver as variaves da classe Produto, mas não altera-las "+p.Preco);
       

    }
}