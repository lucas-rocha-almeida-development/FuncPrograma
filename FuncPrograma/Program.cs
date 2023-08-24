using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FuncPrograma.Entitides;
namespace FuncPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //declarar um delegates
            //função que recebe um product e retornar uma string
           // Func<Product, string> func = NameUpper;

            //Utilizando expressão lambda
           // Func<Product,string> func = p => p.Name.ToUpper();


            //criar um lista em caixa alta (Linq)
            //EXpressão lambda inline
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();//Lista principal . utilizando metodo NameUpper
            //convertendo para capslock
            foreach (string item in result) {
                Console.WriteLine(item);
            
            }
        }
        //provisorio
        //metododo Name Upper criado
      /*  static string NameUpper(Product p)
        {   // p ira receber um nome de string
            return p.Name.ToUpper();//ira retornar o nome em caixa alta
        }*/
    }
}
