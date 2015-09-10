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
    public partial class BuscarPorId : Form
    {
        public BuscarPorId()
        {
            InitializeComponent();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            int idBusca = Int32.Parse(idTbx.Text);
            Contato contato = new Contato()
            {
                Id = idBusca
            };
            contato = 
        }
    }
}
