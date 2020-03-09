using ProjetoFinal.ProdutosMarcas.Apresentacao.ViewModels;
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
    public partial class FrmProduto : Form
    {
        private Produto produtoASerAlterado;
        public FrmProduto(Produto produto = null)
        {
            produtoASerAlterado = produto;
            InitializeComponent();
        }

        private async void FrmProduto_Load(object sender, EventArgs e)
        {
            IRepositorioGenerico<Marca> repositorioMarca = new RepositorioMarca();
            List<Marca> marcas = await repositorioMarca.SelecionarTodos();
            List<MarcaViewModel> marcaViewModels = new List<MarcaViewModel>();
            foreach(Marca marca in marcas)
            {
                MarcaViewModel viewModel = new MarcaViewModel
                {
                    Id = marca.Id,
                    Nome = marca.Nome
                };
                marcaViewModels.Add(viewModel);
            }
            cmbMarcas.DataSource = marcaViewModels;
            cmbMarcas.DisplayMember = "Nome";
            cmbMarcas.ValueMember = "Id";
            cmbMarcas.Refresh();
            if (produtoASerAlterado != null)
            {
                txbNomeProduto.Text = produtoASerAlterado.Nome;
                cmbMarcas.SelectedValue = produtoASerAlterado.MarcaId;
            }
            else
            {
                txbNomeProduto.Text = string.Empty;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IRepositorioGenerico<Produto> repositorioProduto = new RepositorioProduto();
            if (produtoASerAlterado == null)
            {
                Produto novoProduto = new Produto
                {
                    Nome = txbNomeProduto.Text.Trim(),
                    MarcaId = Convert.ToInt32(cmbMarcas.SelectedValue)
                };
                repositorioProduto.Inserir(novoProduto);
            }
            else
            {
                produtoASerAlterado.Nome = txbNomeProduto.Text.Trim();
                produtoASerAlterado.MarcaId = Convert.ToInt32(cmbMarcas.SelectedValue);
                repositorioProduto.Atualizar(produtoASerAlterado);
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
