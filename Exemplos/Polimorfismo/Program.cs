
using Polimorfismo;

//instanciar estagiario
Imposto objetoE = new Estagiário();
objetoE.valeAlimentacao(1000);
objetoE.valeTransporte(1000);

Console.WriteLine("------------------");

//instanciar gerente
Imposto objetoG = new Gerente();
objetoG.valeAlimentacao(5000);
objetoG.valeTransporte(5000);

Console.WriteLine("------------------");

//instanciar atendente

Imposto objetoA = new Atendente();
objetoA.valeAlimentacao(2000);
objetoA.valeTransporte(2000);