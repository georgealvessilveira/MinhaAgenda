using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinhaAgenda.dao;
using MinhaAgenda.model;

namespace MinhaAgenda.view
{
    public partial class VisualizarRfm : Form
    {
        public VisualizarRfm()
        {
            InitializeComponent();
        }

        private ContatoDao _ContatoDao;

        public ContatoDao ContatoDao
        {
            set { this._ContatoDao = value; }
        }

        private void VisualizarRfm_Load(object sender, EventArgs e)
        {
            foreach (Contato contato in _ContatoDao.pegarTodos())
            {
                int index = ContatosDgv.Rows.Add();
                DataGridViewRow linha = ContatosDgv.Rows[index];
                linha.Cells["id"].Value = contato.Id;
                linha.Cells["nome"].Value = contato.Nome;
                linha.Cells["Email"].Value = contato.Email;
                linha.Cells["Telefone"].Value = contato.Telefone;
            }
        }
    }
}
