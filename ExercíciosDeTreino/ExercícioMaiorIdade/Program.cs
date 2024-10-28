using ExercícioMaiorIdade;

// Criando um array de inteiros com 3 valores
int[] idades = new int[] { 80, 100, 90 };
string[] TresNomes = new string[] { "Arthur", "Samuel", "Samanta" };

// Criando uma nova instância da classe Pessoa
Pessoa p = new Pessoa(idades, TresNomes);

p.ExibirDados();