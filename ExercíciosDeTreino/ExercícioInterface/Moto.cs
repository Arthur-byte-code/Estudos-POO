using System;

// Definição da classe Moto que implementa IVeiculo
class Moto : IVeiculo
{
    public void Ligar()
    {
        Console.WriteLine("Moto ligada.");
    }

    public void Desligar()
    {
        Console.WriteLine("Moto desligada.");
    }
}