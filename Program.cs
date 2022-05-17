using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace TI_AED_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("João Augusto \n\n\n" ); 

            /*Inicializar a Hash, inserir os processos nas filas de acordo com a prioridade*/

            Hash tabelaProcessos = new Hash();

            Fila fila5 = new Fila();
            Fila fila4 = new Fila();
            Fila fila3 = new Fila();
            Fila fila2 = new Fila();
            Fila fila1 = new Fila();

            Processos auxP = new Processos();

            Executar tred = new Executar();

            tabelaProcessos.loadProcesso(@"C:\Users\Admin\Desktop\arquivo.txt"); //caminho do arquivo de dados

            for (int i = 0; i < tabelaProcessos.TabelaP.Length; i++)
            {

                auxP = tabelaProcessos.TabelaP[i];

                if (auxP == null)
                {
                    i += 0;
                }

                else if (auxP.Prox != null)
                {
                    while (auxP != null)
                    {
                        switch (auxP.Prioridade)
                        {
                            case 1:
                                fila1.enfileirar(auxP);
                                break;
                            case 2:
                                fila2.enfileirar(auxP);
                                break;
                            case 3:
                                fila3.enfileirar(auxP);
                                break;
                            case 4:
                                fila4.enfileirar(auxP);
                                break;
                            case 5:
                                fila5.enfileirar(auxP);
                                break;
                        } // Fim switch

                        auxP = auxP.Prox;
                    } // Fim while
                }

                else
                {
                    switch (auxP.Prioridade)
                    {
                        case 1:
                            fila1.enfileirar(auxP);
                            break;
                        case 2:
                            fila2.enfileirar(auxP);
                            break;
                        case 3:
                            fila3.enfileirar(auxP);
                            break;
                        case 4:
                            fila4.enfileirar(auxP);
                            break;
                        case 5:
                            fila5.enfileirar(auxP);
                            break;

                    } // Fim switch
                } // Fim else
            } // Fim for


            tred.trad(fila5);

            Thread.Sleep(5000);

            tred.trad(fila4);

            Thread.Sleep(5000);

            tred.trad(fila3);

            Thread.Sleep(5000);

            tred.trad(fila2);

            Thread.Sleep(5000);

            tred.trad(fila1);

            Console.ReadKey();
        }
    


    }
}
