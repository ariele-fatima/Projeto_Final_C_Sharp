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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewMarcarAsync();
            PreencherDataGridViewProdutosAsync();
        }

        private async void PreencherDataGridViewMarcarAsync()
        {
            IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
            List<Marca> marcas = await repositorioMarcas.SelecionarTodos();
            List<MarcaViewModel> marcaViewModels = new List<MarcaViewModel>();
            foreach (Marca marca in marcas)
            {
                MarcaViewModel viewModel = new MarcaViewModel
                {
                    Id = marca.Id,
                    Nome = marca.Nome
                };
                marcaViewModels.Add(viewModel);
            }
            dgvMarcas.Invoke((MethodInvoker)delegate
            {
                dgvMarcas.DataSource = marcaViewModels;
                dgvMarcas.Refresh();
            });
        }

        private async void PreencherDataGridViewProdutosAsync()
        {
            IRepositorioGenerico<Produto> repositorioProdutos = new RepositorioProduto();
            List<Produto> produtos = await repositorioProdutos.SelecionarTodos();
            List<ProdutoViewModel> produtoViewModels = new List<ProdutoViewModel>();
            foreach (Produto produto in produtos)
            {
                ProdutoViewModel viewModel = new ProdutoViewModel
                {
                    Id = produto.Id,
                    Marca = produto.Marca.Nome,
                    MarcaId = produto.MarcaId,
                    Nome = produto.Nome
                };
                produtoViewModels.Add(viewModel);
                dgvProdutos.Invoke((MethodInvoker)delegate
                {
                    dgvProdutos.DataSource = produtoViewModels;
                    dgvProdutos.Refresh();
                });
            }
        }
    }
}
