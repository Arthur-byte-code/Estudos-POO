using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosImóvies
{
     class CorretoraDeImóveis
    {
        public string Endereco;
        public double Preco;
        public string Tipo;

        public CorretoraDeImóveis()
        {
            



        }

        public void ListarImóveis(string endereco, double preco, string tipo )
        {
            Endereco = endereco;
            Preco = preco;
            Tipo = tipo;
           
            

        }

        public void CalcularMédiaPreços()
        {

        }

       public void Exibir( List<CorretoraDeImóveis> listaDeImóveis)
        {

        }
        public override string ToString()// SobreEscrita do método de uma classe Base chamada Object
        {
            return $"O endereço do imóvel é: {Endereco}, o preço do imóvel é: {Preco}, o tipo do imóvel é: {Tipo}";
        }
    }
}
