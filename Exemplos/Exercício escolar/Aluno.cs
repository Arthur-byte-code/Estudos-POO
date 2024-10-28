using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_escolar
{
    internal class Aluno
    {
        public string nome;

        public double nota1, nota2;

        //media
        public double media()
        {
            return (nota1 + nota2) / 2;
        }
        //situacao
        public string situacao(double media)
        {
            return media >= 7 ? "aprovado" : "reprovado";
        }

        //mensagem

        public void mensagem()
        {
            //obter a media
            double obterMedia = media();

            // obter a situação

            string obterSituacao = situacao(obterMedia);

            //mensagem
            Console.WriteLine(nome+ "está "+ obterSituacao+" com média de "+obterMedia);
        }



    }
}
