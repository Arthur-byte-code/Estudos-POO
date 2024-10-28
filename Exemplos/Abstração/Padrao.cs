using System;

namespace Abstração
{
    // Classe abstrata
    public abstract class Padrao
    {
        // Método obrigatório
        public abstract void taxaEmprestimo(double valor);

        // Método opcional
        public void calculoPoupanca(double valor, double taxa)
        {
            Console.WriteLine("Ganhos obtidos pela poupança R$"+(valor*taxa));
        }

    }
}
