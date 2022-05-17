using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace TI_AED_2018
{
    class Executar
    {
        public void trad(Fila auxFila)
        {
            Processos resp = new Processos();
            Processos resp2 = new Processos();

            resp = auxFila.desenfileirar();
            resp2 = auxFila.desenfileirar();

            GerenciaThread gt = new GerenciaThread(resp, resp2);
            gt.ChamarThread();

            Thread.Sleep(10000);

            if (!(auxFila.filaVazia()))
            {
                trad(auxFila);
            }


        }
    }
}
