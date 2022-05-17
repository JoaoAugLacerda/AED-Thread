using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace TI_AED_2018
{
    class Processos
    {
        private int pid;
        private string nome;
        private int prioridade;
        private double usoCpu;
        private int ciclos;
        Processos prox;

        public Processos() //construtor generico
        {
            this.pid = 0;
            this.nome = "";
            this.prioridade = 0;
            this.usoCpu = 0;
            this.ciclos = 0;
            this.prox = null;
        }

        public Processos(int pid, string nome, int prioridade, double usoCpu, int ciclos)
        {
            this.pid = pid;
            this.nome = nome;
            this.prioridade = prioridade;
            this.usoCpu = usoCpu;
            this.ciclos = ciclos;
        }

        public int Pid
        {
            get { return pid; }
            set { pid = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Prioridade
        {
            get { return prioridade; }
            set { prioridade = value; }
        }

        public double UsoCpu
        {
            get { return usoCpu; }
            set { usoCpu = value; }
        }

        public int Ciclos
        {
            get { return ciclos; }
            set { ciclos = value; }
        }

        public Processos Prox
        {
            get { return prox; }
            set { prox = value; }
        }

    }
}
