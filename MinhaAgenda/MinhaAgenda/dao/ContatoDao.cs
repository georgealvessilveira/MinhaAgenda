using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaAgenda.model;

namespace MinhaAgenda.dao
{
    public class ContatoDao
    {
        private IList<Contato> _ListaContatos;
        private static ContatoDao _ContatoDao;

        private ContatoDao()
        {
            _ListaContatos = new List<Contato>();
        }

        public void adicionarContato(Contato contato)
        {
            _ListaContatos.Add(contato);
        }
        public void removerContato(Contato contato)
        {
            _ListaContatos.Remove(contato);
        }

        public void atualizarContato(Contato contato)
        {
            Contato contatoAntigo = this.pegarPorID(contato);
            contatoAntigo.Nome = contato.Nome;
            contatoAntigo.Email = contato.Email;
            contatoAntigo.Telefone = contato.Telefone;
        }

        public IList<Contato> pegarTodos()
        {
            return _ListaContatos;
        }

        public static ContatoDao getInstancia()
        {
            if(_ContatoDao == null)
            {
                _ContatoDao = new ContatoDao();
            }
            return _ContatoDao;
        }
        public Contato pegarPorID(Contato contato)
        {
            Contato retorno = new Contato();
            foreach(Contato c in this.pegarTodos())
            {
                if(c.Id == contato.Id)
                {
                    retorno = c;
                }
            }
            return retorno;
        }


    }
}
