using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor
{
    internal class Pessoa
    {
        //Construtor (todo construtor é público)
        public Pessoa()
        {
            Console.WriteLine("CONSTRUTOR EXECUTADO");
        }
     
        public Pessoa (string nome)
        {
            Console.WriteLine("Olá "+nome);
        }
    }
}
