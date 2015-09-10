using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinhaAgenda.model;
using MinhaAgenda.dao;

namespace MinhaAgenda.view
{
    public partial class PegarPorId : Form
    {
        private ContatoDao _contatoDao;
        private Contato contato;

        public ContatoDao contatoDao
        {
            set { this._contatoDao = value; }
        }
        public PegarPorId()
        { 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idBusca = Int32.Parse(idTbx.Text);
            contato = new Contato()
            {
                Id = idBusca
            };
            contato = _contatoDao.pegarPorID(contato);
            if(contato.Id == 0)
            {
                MessageBox.Show("Contato não encontrado");
            }
            else
            {
                nomeTbx.Text = contato.Nome;
                nomeTbx.Enabled = true;
                emailTbx.Text = contato.Email;
                emailTbx.Enabled = true;
                telefoneTbx.Text = contato.Telefone;
                telefoneTbx.Enabled = true;
                removerBtn.Enabled = true;
                atualizarBtn.Enabled = true;
            }
        }

        private void removerBtn_Click(object sender, EventArgs e)
        {
            _contatoDao.removerContato(contato);
            MessageBox.Show("Contato removido com sucesso!");
            idTbx.Text = "";
            nomeTbx.Text = "";
            emailTbx.Text = "";
            telefoneTbx.Text = "";
            removerBtn.Enabled = false;
            atualizarBtn.Enabled = false;
        }

        private void atualizarBtn_Click(object sender, EventArgs e)
        {
            contato.Nome = nomeTbx.Text;
            contato.Email = emailTbx.Text;
            contato.Telefone = telefoneTbx.Text;
            _contatoDao.atualizarContato(contato);
            MessageBox.Show("Contato Atualizado com sucesso!!");
            idTbx.Text = "";
            nomeTbx.Text = "";
            emailTbx.Text = "";
            telefoneTbx.Text = "";
            removerBtn.Enabled = false;
            atualizarBtn.Enabled = false;
        }
    }
}
