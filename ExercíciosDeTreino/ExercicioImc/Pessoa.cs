using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioImc
{
    internal class Pessoa
    {
        public double altura;
        public double peso;


        public double ResultadoImc()
            {
            return peso / (altura * altura);

            }

        public string Conclusao(double ResultadoImc)
        {
            
                if (ResultadoImc < 18.5)
                {
                  return  "Abaixo do peso";
                }
                if (ResultadoImc < 25)
                {
                return "Peso normal";
                }
                if (ResultadoImc < 30)
                {
                return "Acima do peso";
                }
                if (ResultadoImc < 35)
                {
                return "Obeso 1";
                }
                if (ResultadoImc < 40)
                {
                return "Obeso 2";
                }
                else
                {
                return "Obeso 3";
                }
            

        }

        public void mensagem()
        {
            double obterImc = ResultadoImc();
            string obterConclusao = Conclusao(obterImc);

            Console.WriteLine("A pessoa em questão esta com o imc no nível " + obterConclusao + " e o valor do imc é " +obterImc);
        }


    }
}
