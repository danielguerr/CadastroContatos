using Site.Data;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Repository
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public List<ContatoModel> BuscarContatos()
        {
            return _bancoContext.Contatos.ToList();
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            //Gravar no Banco de Dados
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }


    }
}
