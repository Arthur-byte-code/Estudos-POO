using ExercícioCadastroCliente;
using System.Collections.Generic;
using System;

List<Cliente> listaDeClientes = new List<Cliente>();// Aqui eu crio uma lista 
Console.WriteLine("Digite quantos clientes você vai cadastrar");
int quantidadePraCadastrar = Convert.ToInt32(Console.ReadLine());//Essa variavel é enviada para determinar quantas vezes o loop for ocorrerá


for (int i = 0; i <= quantidadePraCadastrar-1; i++)//  loop com incremento
{


    Console.WriteLine("Digite o Nome");
    string nome = Console.ReadLine();


    Console.WriteLine("Digite a Cidade");
    string cidade = Console.ReadLine();

    Console.WriteLine("Digite o Pedido");
    

    string pedido = Console.ReadLine();

    Cliente cliente  = new Cliente(nome, cidade, pedido);// argumentos que são enviados para o construtor da classe Cliente
    Console.Clear();

    listaDeClientes.Add(cliente);//A função .Add() é utilizada para mandar os objetos para ficarem alocados em uma parte da lista

}





foreach (Cliente cliente in listaDeClientes)//Percorrer todo os indices da lista e exibir na tela
{
    Console.WriteLine(cliente);
}






