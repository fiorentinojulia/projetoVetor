using System;
using System.Collections.Generic;
using System.Linq;
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
            for (i=0; i < 5; i ++)
            {
                Console.WriteLine((i+1)+ "ª Posição: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());//Preencher o vetor

            }//Fim do For 

        }//Fim Método

        public void MostrarVetor ()
        {
            Console.WriteLine("Ordem Inversa: ");
            for (i=4; i >= 0; i --)
            {
                Console.WriteLine(i + 1 + "ª Posição:" + vetor[i]);
            }//Fim For
        }//Fim do Mostrar


        // Case 3

        //Preecher Vetor
        public void VetorPreencher()
        {
            for (i = 0; i < 12; i++)
            {
                Console.WriteLine(i  + "ª Posição do Vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
                int v = Convert.ToInt32(Console.ReadLine());
                vetor[i] = v;

            }//Fim do For

        }//Fim Metodo


        public void MostrarVetorXY(int Y, int X)
        {
            Console.WriteLine("Vetores escolhidos: ");
            for (i = Y; i >= X;)
            {
                Console.WriteLine("Os Vetores escolhidos são: " + (i = Y, i >= X));
            }//Fim For
        }//Fim Método

    }//Fim da classe
}
