using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    internal class Pessoa
    {
        //atributos
        //apenas a classe onde é criada ou herdada pode acessar um atributo "protected"

        protected string nome;
        protected int idade;


        //método

        protected void menssagemPessoa()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);

        }
    }
}
