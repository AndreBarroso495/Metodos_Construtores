using System;
using Metodos_Construtores.Classes;

namespace Metodos_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
           
           //Utilizando o construtor vazio
           Produto produto1 = new Produto();
           produto1.Codigo = 1;
           produto1.Nome = "Coca-Cola";
           produto1.Descricao = "Refrigerante de cola";
           produto1.Estoque = 30;

           Console.WriteLine($"Produto 1 código {produto1.Codigo}, nome {produto1.Nome}, descricão {produto1.Descricao}, estoque {produto1.Estoque}");
        }
    }
}
