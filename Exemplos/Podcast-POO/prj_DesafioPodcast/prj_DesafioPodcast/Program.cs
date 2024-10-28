/*Episodio ep1 = new(1, "aula DS1 ", 50);
ep1.AdiconarConvidados("Nica");
ep1.AdiconarConvidados("Kaio");

Episodio ep2 = new(2, "DB2", 35);
ep2.AdiconarConvidados("Lazaro");
ep2.AdiconarConvidados("Leandro"); 



Podcast podcast1 = new("ETEC Itapevi", "Hélio Silva");

podcast1.AdicionarEpisodios(ep1);
podcast1.AdicionarEpisodios(ep2);
podcast1.ExibirDetalhes();



Console.ReadKey();  */

using System;

void menu()
{
    Console.Clear();
    int op = 0;

    Console.WriteLine("1 - Criar Podcast");
    Console.WriteLine("2 - Adicionar Episodio em um Podcast");
    Console.WriteLine("3 - Ver lista de Podcast");
    Console.WriteLine("4 - Sair\n");

    Console.Write("Digite a o Numero da Opção desejada: ");

    op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {

        case 1:
            criarpodcast();
           
            break;
        case 2:
           adicionarEpisodio();
            
            break;
        case 3:
           listar();
            
            break; 
        case 4:
            Console.Write("Encerrando programa... ");
            Thread.Sleep(2000);
            break;

    }

}

Podcast podcast1 = new Podcast();//ocorre uma criação de objeto a partir da classe podcast

void criarpodcast()

{
    Console.Write("Digite o Nome do Podcast: ");
    podcast1.Nome = Console.ReadLine();
    Console.Write("Digite o Nome do Apresentador: ");
    podcast1.Host = Console.ReadLine();
    Console.WriteLine("Podcast Adicionado com Sucesso! ");

 

    Console.WriteLine($"Podcast | {podcast1.Nome} | \n Apresentado por: {podcast1.Host}\n");

    menu();

}
void listar() {
    podcast1.ExibirDetalhes();
    Thread.Sleep(3000);
    menu();
}

void adicionarEpisodio()
{
    Episodio ep1 = new Episodio();

    Console.WriteLine("Digite o título do episódio: ");
    ep1.Titulo = Console.ReadLine();

    Console.WriteLine("Digite a ordem do episódio: ");
    ep1.Ordem = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite a duração do episódio: ");
    ep1.Duracao = Convert.ToInt32(Console.ReadLine());
    podcast1.AdicionarEpisodios(ep1);

    Console.WriteLine("\nepisódio adicionado com sucesso ");
    Thread.Sleep(3000);
    menu();


}

menu();