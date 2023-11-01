using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstruturaRepeticao
{
    class Model
    {
        public double[] notas;// Declaração de um vetor
        public int i;
        public int[] vetor;
        private double soma;



        public Model()
        {
            notas = new double[10];
            vetor = new int[5];// Instanciar = Existir
            vetor = new int[12];
            vetor = new int[15];
            i = 0;
            ConsultarSoma = 0;
            

        }//Fim do Construtor

        public double ConsultarSoma
        {
            get { return soma; }
            set { this.soma = value; }
        }

        //Case 1
        //Guardar 10 notas de 10 alunos diferentes 
        public double MediaNotas()
        {
            for (i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine(i + 1 + "ª Nota: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    if ((notas[i] < 0 || notas[i] > 10)) ;
                    {
                        Console.WriteLine("Difgite uma nota entre 0 e 10");

                    }//Fim validação


                } while ((notas[i] < 0) || (notas[i] > 10));
                ConsultarSoma = ConsultarSoma + notas[i];
                //ou ConsultarSoma += notas [i];

            }//Fim do for
            return ConsultarSoma / i;

        }//Fim método


        // Case 2
        //Ler um vetor de 5 posições e mostrar ela em oredem inversa
        public void PreencherVetor()
        {
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine((i + 1) + "ª Posição: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());//Preencher o vetor

            }//Fim do For 

        }//Fim Método

        public void MostrarVetor()
        {
            Console.WriteLine("Ordem Inversa: ");
            for (i = 4; i >= 0; i--)
            {
                Console.WriteLine(i + 1 + "ª Posição:" + vetor[i]);
            }//Fim For
        }//Fim do Mostrar


        // Case 3

        //Preecher Vetor
        public void VetorPreencher()
        {
            for (i = 0; i < 3; i++)
            {
                Console.Write($"{i + 1}ª Vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());

            }//Fim do For
        }//Fim Metodo


        public void CalcularMedia()
        {
            int soma = 0;
            double media;

            for (i = 0; i < 3; i++)
            {
                soma += vetor[i];
            }
            media = (double)soma / 3;
            Console.WriteLine($"A Média é: {media}");



        }//Fim Método
         //Exercicio 4 Contar os números pares

        public void exercicio4()
        {
            int par = 0;
           

            for (i = 0; i < 3; i++)
            {
                Console.Write(i + 1 + "° Vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
                
                if (vetor[i] % 2 == 0)
                {
                    par++;
                }                
            }//Fim for
            Console.WriteLine("A quantidade de números pares são: " + par);

        }//Fim método

        //Exercicio 5 Mostrar o maior valor
        public void Exercicio5()
        {
            int maior = 0;

            int posicao = 0;

            for (i = 0; i < 25; i ++ )
            {
                Console.WriteLine($"{i} º Vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
                
                if ( i == 0 )   
                {
                    maior = vetor[i];      
                }

                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                    posicao = i;
                }
            }//Fim do For
            Console.WriteLine($"O maior número é: {maior}  E a posição é: {posicao + 1}");

           
        }//Fim metodo

        //Exercicio 6: Mostrar o menor valor
        public void Exercicio6()
        {
            int menor = 0;
            int posicao = 0;
           
            

            for (i = 0; i < 30; i++)
            {
                Console.WriteLine($"{i} º Vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
                
               
                if(i == 0 )
                {
                 
                    menor = vetor[i];

                }

                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    posicao = i ;
                }

            }//Fim do For
            Console.WriteLine($"O menor número é: {menor} E sua Posição é: {posicao}");
        }// Fim método

        //Exercicio 7: Encontrar o segundo maior valor!
        public void Exercicio7()
        {

            int maior = 0;
            int Smaior = 0;
           

            for (i=0; i < 3;  i++)
            {
                Console.WriteLine($"{i} °Vetor: ");
                vetor[i] = Convert.ToInt32(Console.Read());
                
                    if (i == 0)
                    {
                        maior = vetor[i];

                    }

                    if (vetor[i] > maior) ;
                    {
                        maior = vetor[i];
                    }


                    if (Smaior == vetor[i])
                    {
                        Smaior = vetor[i];
                    }

                    if ((Smaior < maior || Smaior > vetor[i]))
                    {
                       Smaior = Smaior;
                    }
            }//Fim For
            
            Console.WriteLine($"O Segundo Número maior é: {Smaior} E o Primeiro é: {maior} ");
        }//Fim método














        //vetor[i] = Convert.ToInt32(Console.ReadLine());   maior = vetor[i]; i < 3; i --)||  i = 0; maior <- num1
        // num1 > maior
        // maior<- num1





    }






}
