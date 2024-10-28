using System;

class Carro : IVeiculo
{
    public void Ligar()
    {
        Console.WriteLine("Carro ligado.");
    }

    public void Desligar()
    {
        Console.WriteLine("Carro desligado.");
    }
}
