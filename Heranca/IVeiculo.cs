using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public interface IVeiculo
    {
        string Ligar();
        string Desligar();
        string Abastecer();
        string Desabastecer();
        void AdicionaAntigosDonos(Dono dono);
        List<Dono> ListaAntigosDonos();
    }
}
