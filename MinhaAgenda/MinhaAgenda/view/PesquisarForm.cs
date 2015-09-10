using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaAgenda
{
    public partial class PesquisarForm : Form
    {
        public PesquisarForm()
        {
            InitializeComponent();
        }

        private void pesquisaNomeRdb_CheckedChanged(object sender, EventArgs e)
        {
            pesquisarNomeGbx.Visible = true;
            pesquisarIdGbx.Visible = false;
        }

        private void pesquisaIdRdb_CheckedChanged(object sender, EventArgs e)
        {
            pesquisarNomeGbx.Visible = false;
            pesquisarIdGbx.Visible = true;
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
