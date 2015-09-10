using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinhaAgenda.view;
using MinhaAgenda.dao;
using MinhaAgenda.model;

namespace MinhaAgenda
{
    public partial class PegarId : Form
    {
        public PegarId()
        {
            InitializeComponent();
            _ContatoDao = ContatoDao.getInstancia();
        }

        private ContatoDao _ContatoDao;

        private void adicionarContatoBtn_Click(object sender, EventArgs e)
        {
            AdicionarContatoForm adicionarContato = new AdicionarContatoForm();
            adicionarContato.ContatoDao = ContatoDao.getInstancia();
            adicionarContato.ShowDialog();
        }

        private void mostrarTodosBtn_Click(object sender, EventArgs e)
        {
            VisualizarRfm visualizar = new VisualizarRfm();
            visualizar.ContatoDao = _ContatoDao;
            visualizar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PegarPorId buscarId = new PegarPorId();
            buscarId.contatoDao = _ContatoDao;
            buscarId.ShowDialog();
        }
    }
}
