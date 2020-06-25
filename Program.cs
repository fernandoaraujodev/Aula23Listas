using System;
using System.Collections.Generic;

namespace Aula23Listas
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Instanciando uma lista
            List<Produto> produto = new List<Produto>();

            Produto produto1 = new Produto("Notebook HP i7", 123, 3499.98f);
            produto.Add(produto1);// Adicionando o produto à lista criada

            produto.Add(new Produto("Fritadeira Wallit", 1, 349.99f));
            produto.Add(new Produto("Ferro de passar Arno", 2, 129.99f));
            produto.Add(new Produto("Liquidificador 3 potências Arno", 3, 89.99f));
            produto.Add(new Produto("Sanduicheira Mabe", 4, 29.99f));

            foreach(Produto item in produto){

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{item.Nome} está no valor R$ {item.Preco}");
                Console.ResetColor();

            }

            //Removendo produto passando objeto como argumento
            produto.Remove(produto1);

            //Removendo produto pelo indice
            produto.RemoveAt(3);

            //Usando expressão lambda para remover registro
            produto.RemoveAll(a => a.Nome == "Ferro de passar Arno");//Esta é a expressão usada

            //Varrendo a lista após a remoção
            foreach(Produto item in produto){

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{item.Nome} está no valor R$ {item.Preco}");
                Console.ResetColor();

            }

            //Encontrando produto especifico utilizando a expressão lambda
            Produto findProduto = produto.Find(x => x.Codigo == 1);

            System.Console.WriteLine($"Este item procurado é {findProduto.Nome} está R${findProduto.Preco}");





        }
    }
}
