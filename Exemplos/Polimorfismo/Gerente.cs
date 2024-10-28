using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Gerente : Imposto
    {
        //método
        public  override void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto gerente padrão do vale alimentação R$" + (salario * 0.15));

        }
    }
}
