using Dev.Io.Ui.Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev.Io.Ui.Site.Data
{
    public class PeidoRepository : IPeidoRepository
    {
        public Pedido ObterPedido()
        {
            return new Pedido();
        }
    }
}

public interface IPeidoRepository
{
    Pedido ObterPedido();
}
