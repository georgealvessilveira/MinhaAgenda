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
    public partial class AdicionarContatoForm : Form
    {

        
        public AdicionarContatoForm()
        {
            InitializeComponent();
        }

        private ContatoDao _ContatoDao;

        public ContatoDao ContatoDao
        {
            set { this._ContatoDao = value; }
        }

        private void adicionarBtn_Click(object sender, EventArgs e)
        {
            Contato novoContato = new Contato();

            novoContato.Id = Int32.Parse(idTbx.Text);
            novoContato.Nome = nomeTbx.Text;
            novoContato.Email = emailTbx.Text;
            novoContato.Telefone = telefoneTbx.Text;

            _ContatoDao.adicionarContato(novoContato);
            MessageBox.Show("Contato adicionado com sucesso!");

            idTbx.Text = "";
            nomeTbx.Text = "";
            emailTbx.Text = "";
            telefoneTbx.Text = "";

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
