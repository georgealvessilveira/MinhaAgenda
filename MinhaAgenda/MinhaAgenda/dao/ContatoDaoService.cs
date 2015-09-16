using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaAgenda.model;

namespace MinhaAgenda.dao
{
    public class ContatoDaoService
    {
        private IContatoDao contatoDao;
        public IContatoDao ContatoDao
        {
            get { return contatoDao; }
        }

        public ContatoDaoService(IContatoDao contatoDao)
        {
            this.contatoDao = contatoDao;
        }

        public void AdicionarContato(Contato contato)
        {
            this.contatoDao.AdicionarContato(contato);
        }

        public void RemoverContato(Contato contato)
        {
            this.contatoDao.RemoverContato(contato);
        }

        public void AtualizarContato(Contato contato)
        {
            this.contatoDao.AtualizarContato(contato);
        }

        public IList<Contato> PegarTodos()
        {
            return this.contatoDao.PegarTodos();
        }

        public Contato PegarPorID(Contato contato)
        {
            return this.contatoDao.PegarPorID(contato);
        }
    }
}
