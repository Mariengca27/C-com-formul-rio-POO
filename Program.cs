//Projeto que simula o registro de alguns dados de um dono de um pet e uma lógica de desconto. A ideia é utilizar a lógica básica de programação, sem POO

//Não esquecer as bibliotecas.

using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Declaração de variáveis e fragmentação de variáveis: 

            //Indicar o que vai começar na tela para o usuário que vai abrir o programa:
            Console.Write("Vamos iniciar seu processo de cadastro do seu PET\n");
            Console.Write("Por favor digite abaixo:\n O nome do animal,\n o registro numérico, o\n preço do animal em reais,\n e o nome do dono.\n");

            //Entrando com os dados para depois fragmentá-los:
            
            string s = Console.ReadLine();
            Console.WriteLine("Você digitou:" + s);  //Mostrando na tela o que foi digitado. 
            string[] vet = s.Split(' ');            //Fragmentando os dados para definir a lógica da aplicação. 

            string nomeAni = vet[0];                   //Separando a string 
            double reg = double.Parse(vet[1]);        //Convertendo o fragmento da String em um tipo double 
            double preco = double.Parse(vet[2]);     //Convertendo o fragmento da String em um outro tipo double. 
            string nomeDono = vet[3];


            //Mostrar na tela para o usuário 
            Console.WriteLine("O nome do seu animal é  {0}", nomeAni);                                                // PlaceHolders
            Console.WriteLine("O registro numérico dele é " + reg.ToString("F3", CultureInfo.InvariantCulture));     // Concatenando 
            Console.WriteLine($"O preço do seu PET é\n{preco} . E o nome do dono é\n{nomeDono}");                       // Interpolação 

            #endregion

            #region Início da lógica do desconto - CHAMADA DA FUNÇÃO dentro do método static
            string oJ1 = "NÃO DIGITE VALORES NEGATIVOS, APENAS POSITIVOS";
            double result_desc = Desconto(preco, oJ1);

            Console.WriteLine("O valor do desconto NO FIM DAS CONTAS É" + result_desc);
            #endregion

        }
        
        #region Função da lógica do desconto 
        static double Desconto(double a, string b)
        {
            double d_co=0;
            

            if (a >= 450)
            {

                d_co = a * 0.15;
            }
            else if (a < 450)
            {

                d_co = a * 0.1;
            }
            else if (a > 450 && a < 1000)
            {
                d_co = a * 0.25;
                
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    d_co = double.Parse(b);

                        
                 }
            }
            return d_co;
        }
            

        #endregion





    }
}
