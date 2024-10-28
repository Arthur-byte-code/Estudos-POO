using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    internal class Pessoa
    {
        //atributo
        private string nome = "Melissa";

        //construtor
        public Pessoa(string nome)
        {
            Console.WriteLine(nome);
            Console.WriteLine(this.nome); // this está relacionado ao valor do atributo, não do parâmetro

        }

    }
}
