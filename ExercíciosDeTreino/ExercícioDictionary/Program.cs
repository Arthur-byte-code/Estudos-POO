using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> dic1 = new Dictionary<int, string>()
        {
            {1, "Banana"},
            {2, "Laranja"},
            {3, "Manga"},
            {4, "Abacate"},
            {5, "Maçã"}
        };

        // Iterar e imprimir cada chave, valor e a quantidade de elementos no dicionário
        foreach (KeyValuePair<int, string> item in dic1)
        {
            Console.WriteLine("chave: {0}, valor: {1} quantidade de elementos chave/valor: {2}", item.Key, item.Value, dic1.Count);
        }

        // Adicionar um novo elemento ao dicionário
        dic1.Add(6, "Maracujá");

        // Imprimir o valor associado à chave 6
        Console.WriteLine("Valor associado à chave 6: " + dic1[6]);

        Console.WriteLine("------------------------------");
        Console.WriteLine("ForEach acontecendo pela segunda vez pra provar que foi adicionada uma sexta chave/valor");
        foreach (KeyValuePair<int, string> item in dic1)
        {
            Console.WriteLine("chave: {0}, valor: {1} quantidade de elementos chave/valor: {2}", item.Key, item.Value, dic1.Count);
        }
        Console.WriteLine("Diga um nome de outra fruta para adiciona-la ao dicionário");
        string OutraFruta = Console.ReadLine();
        dic1.Add(7, OutraFruta);

        Console.WriteLine("------------------------------");
        Console.WriteLine("ForEach acontecendo pela terceira vez pra provar que a fruta escolhida pelo user foi adicionada");
        foreach (KeyValuePair<int, string> item in dic1)
        {
            Console.WriteLine("chave: {0}, valor: {1} quantidade de elementos chave/valor: {2}", item.Key, item.Value, dic1.Count);
        }
    }


}
