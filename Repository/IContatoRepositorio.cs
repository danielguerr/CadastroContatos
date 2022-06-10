using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Repository
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarContatos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
