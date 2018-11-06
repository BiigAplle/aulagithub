using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_m1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Algoritmo Metro 
            21/09/2018
            Nome:               RGM:
            	 Hugo Nicolau	   	11182100376
            	 Valdinei Calixto 	11182100938
	             Matheus Li Lin		11182100826
	        */

                int op;//numeros inteiros 
                double metro, quilometro, decimetro, centimetro, milimetro;//numeros reais

            do//início da estrutura de repetição repita até...que
            {
                inicio://Comando de controle de fluxo
                System.Console.Clear();//limpar a tela 
                Console.Write("\nescolha o comprimento que deseja converter em metro");//enviar uma mensagem ao usuario
                Console.Write("\n\t**Menu de opcoes**");//menu
                Console.Write("\n1-Quilometro\n2-Decimetro\n3-Centimetro\n4-Milimetro\n");//opções para o usuario digitar
                Console.Write("\nDigite uma opcao valida: ");
                op = int.Parse(Console.ReadLine());//comando de entrada de dados 
           


                switch (op)//abertura do switch case
                {
                    case 1://caso do switch
                        System.Console.Clear();
                        Console.Write("\t***Quilometro***");
                        Console.Write("\nDigite o comprimento em metros: ");
                        metro = double.Parse(Console.ReadLine());
                        quilometro = metro / 1000;//processamento
                        Console.Write("{0} : Metros  ", metro);
                        while(metro <0)//validação com while
                        {
                            Console.WriteLine("Valor invalido");
                            Console.WriteLine("Digite o valor novamente");
                            metro = double.Parse(Console.ReadLine());

                        }
                        Console.Write("\nEm quilometro será:  {0} ", quilometro);
                        Console.WriteLine("\nPorfavor pressione uma tecla\n ");
                        Console.ReadKey();
                        goto inicio;

                        break;
                    case 2:
                        System.Console.Clear();
                        Console.Write("\t***Decimetro***");
                        Console.Write("\nDigite o comprimento em metros: ");
                        metro = double.Parse(Console.ReadLine());
                        while (metro < 0)
                        {
                            Console.WriteLine("Valor invalido");
                            Console.WriteLine("Digite o valor novamente");
                            metro = double.Parse(Console.ReadLine());

                        }
                        decimetro = metro * 10;
                        Console.Write("{0} : Metros  ", metro);
                        Console.Write("\nEm decimetro será:  {0} ", decimetro);
                        Console.WriteLine("\nPorfavor pressione uma tecla\n ");
                        Console.ReadKey();
                        goto inicio;//Ir para
                        break;
                    case 3:
                        System.Console.Clear();
                        Console.Write("\t***Centimetro***");
                        Console.Write("\nDigite o comprimento em metros: ");
                        metro = double.Parse(Console.ReadLine());
                        while (metro < 0)
                        {
                            Console.WriteLine("Valor invalido");
                            Console.WriteLine("Digite o valor novamente");
                            metro = double.Parse(Console.ReadLine());

                        }
                        centimetro = metro * 100;
                        Console.Write("{0} : Metros  ", metro);
                        Console.Write("\nEm centimetro será:  {0} ", centimetro);
                        Console.WriteLine("\nPorfavor pressione uma tecla\n ");
                        Console.ReadKey();
                        goto inicio;
                        break;
                    case 4:
                        System.Console.Clear();
                        Console.Write("\t***Milimetro***");
                        Console.Write("\nDigite o comprimento em metros: ");                
                        metro = double.Parse(Console.ReadLine());
                        while (metro < 0)
                        {
                            Console.WriteLine("Valor invalido");
                            Console.WriteLine("Digite o valor novamente");
                            metro = double.Parse(Console.ReadLine());

                        }
                        milimetro = metro * 1000;
                        Console.Write("{0} : Metros  ", metro);
                        Console.Write("\nEm Milimetro será:  {0} ", milimetro);
                        Console.WriteLine("\nPorfavor pressione uma tecla\n ");
                        Console.ReadKey();
                        goto inicio; 
                        break;

                    default://um senão do switch case
                        System.Console.Clear();
                        Console.Write("\n\t Codigo invalido");
                        Console.Write("\n Voce deve escolher uma opcao valida\n");
                        Console.Write("\n\tPrecione qualquer tecla para voltar ao menu\t\n");
                        
                        Console.ReadKey();
                        goto inicio; break;


                }
            }
            while ((op < 0 || op > 4));
            Console.ReadKey();
         
        }
    }
}
