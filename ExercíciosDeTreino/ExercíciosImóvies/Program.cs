using ExercíciosImóvies;
using System.Collections.Generic;

//CorretoraDeImóveis ExecutarConstrutor = new CorretoraDeImóveis() ;

List<CorretoraDeImóveis> listaDeImóveis = new List<CorretoraDeImóveis>();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@" 
 ________  ________  ________  ________  _______   ________  _________    ___    ___ ________  ________  ________     
|\   __  \|\   __  \|\   __  \|\   __  \|\  ___ \ |\   __  \|\___   ___\ |\  \  /  /|\   __  \|\   __  \|\   __  \    
\ \  \|\  \ \  \|\  \ \  \|\  \ \  \|\  \ \   __/|\ \  \|\  \|___ \  \_| \ \  \/  / | \  \|\  \ \  \|\  \ \  \|\  \   
 \ \   ____\ \   _  _\ \  \\\  \ \   ____\ \  \_|/_\ \   _  _\   \ \  \   \ \    / / \ \   ____\ \   _  _\ \  \\\  \  
  \ \  \___|\ \  \\  \\ \  \\\  \ \  \___|\ \  \_|\ \ \  \\  \|   \ \  \   \/  /  /   \ \  \___|\ \  \\  \\ \  \\\  \ 
   \ \__\    \ \__\\ _\\ \_______\ \__\    \ \_______\ \__\\ _\    \ \__\__/  / /      \ \__\    \ \__\\ _\\ \_______\
    \|__|     \|__|\|__|\|_______|\|__|     \|_______|\|__|\|__|    \|__|\___/ /        \|__|     \|__|\|__|\|_______|
                                                                        \|___|/                                       
                                                                                                                      ");
Console.ResetColor();

Menu();
void Menu() {


    Console.WriteLine("Digite 1: Inserir Imovéis");
        Console.WriteLine("Digite 2: Alterar preço de um Imóvel ");
        Console.WriteLine("Digite 3: Exibir Imóveis ");
        int Escolha = Convert.ToInt32(Console.ReadLine());

        switch (Escolha)
        {
            case 1:
                Console.WriteLine("Quantos imóveis você deseja cadastrar");
                int quantosVaiInserir = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= quantosVaiInserir-1; i++)
                {
                    Console.WriteLine("inserir endereço");
                  string  endereco = Console.ReadLine();
                    Console.WriteLine("inserir preço");
                 double  preco = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("inserir Tipo (Residência ou Loja)");
                  string  tipo = Console.ReadLine();
                CorretoraDeImóveis imóvel = new CorretoraDeImóveis();

                imóvel.ListarImóveis(endereco,  preco, tipo );
                    listaDeImóveis.Add(imóvel);
                

            }
            Menu();

                break;
            case 2:
                Console.WriteLine("Alterar preço ");

                break;
            case 3:
                Console.WriteLine("Imóveis Cadastrados:");
            if(listaDeImóveis.Count == 0)
            {
                Console.WriteLine("Ainda não tem nenhum imóvel cadastrado, retornando ao Menu. Aguarde...");
                Thread.Sleep(5000);
                Console.Clear();

                Menu();
            }

            Console.Clear();
            for (int i = 0; i <= listaDeImóveis.Count; i++)
            {
                Console.WriteLine($"item nº{i + 1} Informações do imóvel {listaDeImóveis[i]}" );
            }
            

            break;
            case 4:
            Console.WriteLine("A média de preços  dos imóvel:");
            

            

            break;    

            default:
                Console.WriteLine("Escolha errada");
                break;

        }
    }

