using System;

namespace Abstração
{
    // Classe abstrata
    class PessoaJuridica : Padrao  //PessoaJuridica está herdando da classe Padrao.
    {
        //Metodo obrigatorio
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa de empréstimo para Pessoa Jurídica R$ " + (valor * 0.2));
        }
    }
}
