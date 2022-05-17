using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace TI_AED_2018
{
    class GerenciaThread
    {
        public Processos pro;
        public Processos pro2;

        public GerenciaThread()
        {
            this.pro = null;
            this.pro2 = null;
        }

        public GerenciaThread(Processos pro, Processos pro2)
        {
            this.pro = pro;
            this.pro2 = pro2;
        }

        public void ChamarThread()
        {
            ThreadStart ts = new ThreadStart(processo1);
            Thread t = new Thread(ts);
            t.Start();

            ThreadStart ts1 = new ThreadStart(processo2);
            Thread t1 = new Thread(ts1);
            t1.Start();
        }

        public void processo1()
        {
            for (int i = 0; i < pro.Ciclos; i++)
            {
                Console.WriteLine("PID: {0}      Nome: {1}      Uso da CPU: {2}", pro.Pid, pro.Nome, pro.UsoCpu);
                Thread.Sleep(1000);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Processo: {0} Finalizado", pro.Pid);
            Console.ResetColor();
        }

        public void processo2()
        {
            if (pro2 == null)
            {
                return;
            }

            for (int i = 0; i < pro2.Ciclos; i++)
            {
                Console.WriteLine("PID: {0}      Nome: {1}      Uso da CPU: {2}      Prio: {3}", pro2.Pid, pro2.Nome, pro2.UsoCpu, pro2.Prioridade);
                Thread.Sleep(2000);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Processo: {0} Finalizado", pro2.Pid);
            Console.ResetColor();
        }

    }
}
