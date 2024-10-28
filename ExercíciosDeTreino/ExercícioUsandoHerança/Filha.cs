using System;


namespace ExercícioUsandoHerança
{
     class Filha: Pai // A classe filha está herdando informações da classe pai. Essas informações são as variavéis 'olhos' e 'cabelo' 
    {
        public void CaracterísticaHerdada()
        {
            Console.WriteLine("Eu sou  a classe filha e herdei do meu pai: "+olhos);
            Console.WriteLine("Eu sou  a classe filha e herdei do meu pai: "+cabelo);

        }
    }
}
