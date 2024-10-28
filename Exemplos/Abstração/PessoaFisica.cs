using System;

namespace Abstração
{
    // Classe abstrata
     class PessoaFisica : Padrao //PessoaFisica está herdando da classe Padrao.
    {
        //Metodo obrigatorio
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa de empréstimo para Pessoa Física R$ "+(valor*0.1));
        }
    }
}
