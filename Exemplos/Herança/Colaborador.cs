using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//LEMBRETE a esquerda herda da direita
namespace Herança
{
    internal class Colaborador : Pessoa //Colaborador pode herdar métodos e atributos da classe pessoa
    {
        // atributos

        private double salario;
        //construtor
        public Colaborador(string nome, int idade, double salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
            menssagemPessoa();
            mensagemColaborador();


        }

        //método

        private void mensagemColaborador()
        {
            Console.WriteLine("Salário: " + salario);
        }

    }
}
