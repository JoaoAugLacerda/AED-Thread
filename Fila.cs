using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace TI_AED_2018
{
    class Fila
    {
        private Processos frente;
        private Processos tras;

        public Fila()
        {
            Processos pro = new Processos();

            frente = pro;
            tras = pro;
        }

        public Boolean filaVazia()
        {
            if (frente.Prox == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void enfileirar(Processos pro)
        {
            tras.Prox = pro;
            tras = pro;
        }

        public Processos desenfileirar() //Retira Primeiro Processo da fila. Retorna o Processo retirado. 
        {
            // pro aponta para o cliente da fila que será retornado/desenfileirado, ou seja, o primeiro cliente da fila.
            Processos pro = frente.Prox;

            if (!(filaVazia())) //Atualiza os ponteiro.
            {
                frente.Prox = pro.Prox;
                pro.Prox = null;
            }
            return pro;
        }

        public void imprimir()
        {
            Processos aux = this.frente.Prox;
            while (aux != null)
            {
                Console.WriteLine(aux.Nome);
                aux = aux.Prox;
            }
        }

    }
}
