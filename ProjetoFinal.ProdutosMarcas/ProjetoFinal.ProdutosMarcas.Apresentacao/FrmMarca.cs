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
        private Marca marcaASerAlterada;
        public FrmMarca(Marca marca = null)
        {
            marcaASerAlterada = marca;
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IRepositorioGenerico<Marca> repositorioMarca = new RepositorioMarca();
            if (marcaASerAlterada == null)
            {
                Marca novaMarca = new Marca
                {
                    Nome = txbNomeMarca.Text.Trim()
                };
                repositorioMarca.Inserir(novaMarca);
            }
            else
            {
                marcaASerAlterada.Nome = txbNomeMarca.Text.Trim();
                repositorioMarca.Atualizar(marcaASerAlterada);
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            if(marcaASerAlterada != null)
            {
                txbNomeMarca.Text = marcaASerAlterada.Nome;
            }
            else
            {
                txbNomeMarca.Text = string.Empty;
            }
        }
    }
}
