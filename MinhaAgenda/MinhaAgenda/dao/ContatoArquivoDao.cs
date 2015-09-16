using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaAgenda.model;
using System.IO;

namespace MinhaAgenda.dao
{
    public class ContatoArquivoDao : IContatoDao
    {
        private IList<Contato> _ListaContatos;
        private static ContatoArquivoDao _ContatoDao;

        private Stream stream;
        private StreamReader leitor;
        private StreamWriter escritor;
        private string caminho;

        private ContatoArquivoDao()
        {
            _ListaContatos = new List<Contato>();
            this.caminho = @"C:\Users\A-IKASORUK\Downloads\MinhaAgenda\contato.txt";
        }

        public void AdicionarContato(Contato contato)
        {
            this._ListaContatos.Add(contato);
            using (stream = File.Open(caminho, FileMode.OpenOrCreate))
            {
                using (escritor = new StreamWriter(stream))
                {
                    escritor.Write("{0}, {1}, {2}, {3}\n", contato.Id,
                        contato.Nome, contato.Email, contato.Telefone);
                }
            }
        }

        public void RemoverContato(Contato contato)
        {
            throw new NotImplementedException();
        }

        public void AtualizarContato(Contato contato)
        {
            throw new NotImplementedException();
        }
        
        public IList<Contato> PegarTodos()
        {
            return _ListaContatos;
        }

        public Contato PegarPorID(Contato contato)
        {
            throw new NotImplementedException();
        }

        public static ContatoArquivoDao GetInstancia()
        {
            if (_ContatoDao == null)
            {
                _ContatoDao = new ContatoArquivoDao();
            }
            return _ContatoDao;
        }
    }
}
