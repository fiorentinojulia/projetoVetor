using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstruturaRepeticao
{
    class Control
    {
        Model modelo;
        private int opcao;

        public Control()
        {
            this.modelo = new Model();// Criando uma chave
            ConsultarOpcao = -1;
        }//Fim do Construtor

        public int ConsultarOpcao

        {
            get { return this.opcao; }
            set { this.opcao = value; }
        }//fim método

        public void Menu()
        {
            Console.WriteLine("Escolha uma das opções abaixo:  \n\n" +
                              "0. Sair\n" +
                               "1. Média de notas 10 alunos\n" +
                                "2. Vetor Inverso\n" +
                                 "3. Mostrar Vetor\n");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Fim menu

        public void Operacao()
        {
            do
            {
                Menu();//Mostrar o menu na tela
                switch (ConsultarOpcao)
                {

                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;

                    case 1:
                        Console.WriteLine(this.modelo.MediaNotas());
                        break;

                    case 2:
                        this.modelo.PreencherVetor();
                        this.modelo.MostrarVetor();
                        break;

                    case 3:
                        int Y;
                        int X;
                    
                        this.modelo.VetorPreencher();

                        //Recolher Dados
                        do
                        {
                            Console.WriteLine("Escolha uma opção: ");
                            Y = Convert.ToInt32(Console.ReadLine());
                            if ((Y < 0 || Y < 12))
                            {
                                Console.WriteLine("Escolha uma Opção entre 1 e 10!");
                            }//Fim Validação
                        } while ((Y < 0 || Y < 12));

                        break;

                    default:
                        Console.WriteLine("Erro, escolha uma das opção valida!");
                        break;
                }//Fim Switch
            } while (ConsultarOpcao != 0);

        }//Fim 
    }
}
