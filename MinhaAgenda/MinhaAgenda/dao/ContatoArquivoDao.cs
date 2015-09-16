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
        private string caminho = @"C:\Users\A-IKASORUK\Downloads\MinhaAgenda\contato.txt";

        private ContatoArquivoDao()
        {
            _ListaContatos = new List<Contato>();
        }

        public void AdicionarContato(Contato contato)
        {
            stream = File.Open(caminho, FileMode.Create);
            escritor = new StreamWriter(stream);

            escritor.WriteLine(contato.Id);
            escritor.WriteLine(contato.Nome);
            escritor.WriteLine(contato.Email);
            escritor.WriteLine(contato.Telefone);

            stream.Close();
            escritor.Close();
        }

        public void RemoverContato(Contato contato)
        {

        }

        public void AtualizarContato(Contato contato)
        {
            
        }
        
        public IList<Contato> PegarTodos()
        {
            return _ListaContatos;
        }

        public Contato PegarPorID(Contato contato)
        {
            return contato;
        }

        public ContatoArquivoDao GetInstancia()
        {
            if (_ContatoDao == null)
            {
                _ContatoDao = new ContatoArquivoDao();
            }
            return _ContatoDao;
        }
    }
}
