using System;

namespace Metodos_Construtores.Classes
{
    

    public class Produto 
    {
        public int Codigo{get;set;}
        public string Nome{get;set;}
        public string Descricao{get;set;}
        public int Estoque{get;set;}

        public Produto(){
            

        }
        //Método Construtor
        public Produto(int valor){
            Codigo = valor;
        }
        public Produto(int codigo, string nome, string descricao, int estoque){
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Estoque = estoque;


            //Construtor inserindo apenas o código
            Produto produto2 = new Produto(10);
            produto2.Nome = "Pepsi";

            Console.WriteLine($"Codigo inserido {produto2.Codigo}, nome {produto2.Nome}");

            //Construtor inserindo todos os valores
            Produto produto3 = new Produto(1,"Traquinas", "Bolacha de chocolate", 1000);
            Console.WriteLine($"código {produto3.Codigo}, nome {produto3.Nome}, Descrição {produto3.Descricao}, estoque {produto3.Estoque}");

        }
    
    }
}