using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MétodosEAtributosEstático
{
    internal class Exemplo
    {

        public static string nome = "Ralf"; //valor compartilhado por todas as instancias da classe Exemplo
        public static void soma(int n1, int n2)
        {

            Console.WriteLine($"Olá, aqui é o método soma! Eu recebi as informações inseridas no program.cs, sem  precisar de instanciação ->{n1+n2}");
        }
    }
}
