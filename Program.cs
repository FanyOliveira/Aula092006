using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_20._06
{
    class Program
    {
        static void Main(string[] args)
        {

            //Tratamento de dados - Corrigir as informações que chegam no sistema, para que não tenha erro ou fraude no sistema.

            // ==>> Lista se chama "Produtos"
            // ==>> (if ou while) Comando - Contains - Para verificar se o itém existe na lista, -senão- o programa pode adicionar
          
            //produtos.Add( produto );

            // [0] => pepsi
            // [1] => fanta
            // [2] => texto

            List<string> produtos = new List<string> { "Pepsi", "Fanta" };

            Console.WriteLine("Bem-vindo ao Conradito Store!");

            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar ou 2 para listar:");
                string resposta = Console.ReadLine();
                // int resposta = int.Parse(Console.ReadLine());

                if ( resposta == "1")
                {
                    Console.WriteLine("Digite o nome do produto:");
                    string produto = Console.ReadLine();
                    produto = produto.ToLower();

                    // ToLawer(); => substituindo por ele mesmo em tudo mínusculo
                    // Memso que digitado um produto já cadatrado só que de forma diferente, o programa não aceita 
                   

                    if ( produtos.Contains( produto) )
                    {
                        Console.WriteLine("Esse item já existe na lista...");
                    }
                    else
                    {
                        produtos.Add(produto);
                        Console.WriteLine("Produto adicionado com sucesso!");
                    }

                }
                else
                {
                    string texto = "";
                    int contador = 0;
                    while ( contador < produtos.Count )
                    {
                        string palavra = produtos[contador];

                        string primeira_letra = palavra.Substring(0, 1);
                        primeira_letra = primeira_letra.ToUpper();

                        string segunda_parte = palavra.Substring(1, palavra.Length-1);

                        string palavra_completa = primeira_letra + segunda_parte;

                        texto += palavra_completa + ", ";

                        //texto += produtos[contador] + ", ";
                        contador++;
                    }

                    // Substring recorta uma parte do texto
                    // Length => valor total do que foi digitado
                    // Para cortar a vírgula do final da frase tire o espaço e vírgula usando o (0, texto.Length - 2)

                  
                    texto = texto.Substring(0, texto.Length - 2);

                    Console.WriteLine(texto);
                    
                }


            }
       
            
            Console.ReadKey();
        }
    }
}
