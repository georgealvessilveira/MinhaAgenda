using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaAgenda.model;

namespace MinhaAgenda.dao
{
    public class ContatoDao : IContatoDao
    {
        private IList<Contato> _ListaContatos;
        private static ContatoDao _ContatoDao;

        private ContatoDao()
        {
            _ListaContatos = new List<Contato>();
        }

        public void AdicionarContato(Contato contato)
        {
            _ListaContatos.Add(contato);
        }
        public void RemoverContato(Contato contato)
        {
            _ListaContatos.Remove(contato);
        }

        public void AtualizarContato(Contato contato)
        {
            Contato contatoAntigo = this.PegarPorID(contato);
            contatoAntigo.Nome = contato.Nome;
            contatoAntigo.Email = contato.Email;
            contatoAntigo.Telefone = contato.Telefone;
        }

        public IList<Contato> PegarTodos()
        {
            return _ListaContatos;
        }

        public Contato PegarPorID(Contato contato)
        {
            Contato retorno = new Contato();
            foreach (Contato c in this.PegarTodos())
            {
                if (c.Id == contato.Id)
                {
                    retorno = c;
                }
            }
            return retorno;
        }

        public static ContatoDao GetInstancia()
        {
            if(_ContatoDao == null)
            {
                _ContatoDao = new ContatoDao();
            }
            return _ContatoDao;
        }
    }
}
