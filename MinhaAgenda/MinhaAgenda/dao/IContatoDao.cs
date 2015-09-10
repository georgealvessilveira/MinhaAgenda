using MinhaAgenda.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaAgenda.dao
{
    interface IContatoDao
    {
        void AdicionarContato(Contato contato);
        void RemoverContato(Contato contato);
        void AtualizarContato(Contato contato);
        IList<Contato> PegarTodos();
        Contato PegarPorID(Contato contato);
    }
}
