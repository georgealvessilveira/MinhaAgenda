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
    public partial class AdicionarFrm : Form
    {
        ContatoDao contatoDao;
        public AdicionarFrm()
        {
            InitializeComponent();
            contatoDao = new ContatoDao();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adicionarBtn_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.Id = Int32.Parse(idTbx.Text);
            contato.Nome = nomeTbx.Text;
            contato.Email = emailTbx.Text;
            contato.Telefone = telefoneTbx.Text;

            contatoDao.adicionarContato(contato);

            idTbx.Text = "";
            nomeTbx.Text = "";
            emailTbx.Text = "";
            telefoneTbx.Text = "";

            MessageBox.Show("Contato adicionado com sucesso!!!");
        }
    }
}
