using System;

namespace ExercícioMaiorIdade
{
    internal class Pessoa
    {
        public int[] idade = new int[3];
        string[] nomes = new string[3];
        
        int Maior;

        public void ExibirDados()
        {
            Console.WriteLine("A maior idade é " + Maior);
            int indiceDoMaior = Array.IndexOf(idade, Maior);
            Console.WriteLine("O maior valor está no índice: " + indiceDoMaior);
            Console.WriteLine("O nome do mais velho(a) é " + nomes[indiceDoMaior]);
        }

        public Pessoa()
        {

        }

        public Pessoa(int[] idades, string[] TresNomes)
        {
            // Atribui os valores do array idades ao campo idade da classe Pessoa
            idade = idades;

            // Atribui os valores do array TresNomes ao campo nomes da classe Pessoa
            nomes = TresNomes;

            // Encontra a maior idade no array idades
            Maior = idades.Max();

            // Atribui os valores do array TresNomes ao campo TodosNomes da classe Pessoa
            
        }
    }
}