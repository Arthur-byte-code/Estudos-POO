using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExercícioCadastroCliente
{
     class Cliente
    {
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Pedido {get;set;}

        public  Cliente(string nome, string cidade, string pedido)// construtor que recebe argumentos dos objetos instanciados dentro do loop
        {
             Nome    =   nome;
             Cidade  =   cidade;
             Pedido  =   pedido;

            
        }
       public override string ToString()// SobreEscrita do método de uma classe Base chamada Object
        {
            return $"{Nome}, {Cidade}, {Pedido}";
        }
    
    }

}
