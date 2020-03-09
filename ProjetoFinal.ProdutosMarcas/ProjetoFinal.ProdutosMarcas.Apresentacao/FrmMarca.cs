using ProjetoFinal.ProdutosMarcas.Dominio;
using ProjetoFinal.ProdutosMarcas.Repositorio.EF;
using ProjetoFinal.Repositorio.Comum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal.ProdutosMarcas.Apresentacao
{
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Marca novaMarca = new Marca
            {
                Nome = txbNomeMarca.Text.Trim()
            };
            IRepositorioGenerico<Marca> repositorioMarca = new RepositorioMarca();
            repositorioMarca.Inserir(novaMarca);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
