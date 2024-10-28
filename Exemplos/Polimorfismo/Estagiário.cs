using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Estagiário : Imposto
    {

        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine("Testando sobreEscrita, o argumento que vai aparecer deve ser mil ->" +salario);
        }

    }
}
