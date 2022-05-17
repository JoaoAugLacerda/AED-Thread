using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


namespace TI_AED_2018
{
    class Hash
    {
        public Processos[] tabelaProcessos = new Processos[200]; //Verificar numero de processos

        public Processos[] TabelaP
        {
            get { return tabelaProcessos; }
            set { tabelaProcessos = value; }
        }

        public void loadProcesso(string file) //Leitura do arquivo
        {
            StreamReader arq = new StreamReader(@file);
            string linha = "";
            string[] dados;

            while ((linha = arq.ReadLine()) != null)
            {
                dados = linha.Split(';');
                Processos temp = new Processos(int.Parse(dados[0]), dados[1], int.Parse(dados[2]), double.Parse(dados[3]), int.Parse(dados[4]));
                inserirProcesso(temp);
            }

            arq.Close();
        }

        public int funcaoHash(int elemento)
        {
            int pos;

            pos = elemento % 13; 

            return pos;
        }

        public void inserirProcesso(Processos novo)
        {
            int pos = funcaoHash(novo.Pid);

            if (tabelaProcessos[pos] == null)
            {
                tabelaProcessos[pos] = novo;
            }
            else
            {
                verificar(tabelaProcessos[pos], novo);
            }
        }

        public void verificar(Processos aux, Processos novo) //recursivo que faz a verificação se existe proximo processo
        {
            if (aux.Prox == null)
            {
                aux.Prox = novo;
            }
            else
            {
                verificar(aux.Prox, novo);
            }
        }

    }
}
