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
            }
            dgvProdutos.Invoke((MethodInvoker)delegate
            {
                dgvProdutos.DataSource = produtoViewModels;
                dgvProdutos.Refresh();
            });
        }

        private void btnCadastrarMarca_Click(object sender, EventArgs e)
        {
            FrmMarca frmMarca = new FrmMarca();
            frmMarca.ShowDialog();
            PreencherDataGridViewMarcarAsync();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();
            PreencherDataGridViewProdutosAsync();
        }

        private void btnAlterarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.SelectedRows.Count > 0)
            {
                int idMarcaSelecionada = Convert.ToInt32(dgvMarcas.SelectedRows[0].Cells[0].Value);
                IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
                Marca marcaASerAlterada = repositorioMarcas.SelecionarPorId(idMarcaSelecionada);
                FrmMarca frmMarca = new FrmMarca(marcaASerAlterada);
                frmMarca.ShowDialog();
                PreencherDataGridViewMarcarAsync();
                PreencherDataGridViewProdutosAsync();
            }
            else
            {
                MessageBox.Show("Selecione uma marca antes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                int idProdutoSelecionado = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells[0].Value);
                IRepositorioGenerico<Produto> repositorioProdutos = new RepositorioProduto();
                Produto produtoASerAlterado = repositorioProdutos.SelecionarPorId(idProdutoSelecionado);
                FrmProduto frmProduto = new FrmProduto(produtoASerAlterado);
                frmProduto.ShowDialog();
                PreencherDataGridViewProdutosAsync();
            }
            else
            {
                MessageBox.Show("Selecione um produto antes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnExcluirMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.SelectedRows.Count > 0)
            {
                int idMarcaSelecionada = Convert.ToInt32(dgvMarcas.SelectedRows[0].Cells[0].Value);
                IRepositorioGenerico<Produto> repositorioProdutos = new RepositorioProduto();
                List<Produto> produtos = await repositorioProdutos.SelecionarTodos();
                if (produtos.Where(p => p.MarcaId == idMarcaSelecionada).Count() > 0)
                {
                    MessageBox.Show("Não é possível excluir uma marca associado a um produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
                    Marca marcaASerExcluida = repositorioMarcas.SelecionarPorId(idMarcaSelecionada);
                    repositorioMarcas.Excluir(marcaASerExcluida);
                    PreencherDataGridViewMarcarAsync();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma marca antes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                int idProdutoSelecionado = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells[0].Value);
                IRepositorioGenerico<Produto> repositorioProdutos = new RepositorioProduto();
                Produto produtoASerExcluido = repositorioProdutos.SelecionarPorId(idProdutoSelecionado);
                repositorioProdutos.Excluir(produtoASerExcluido);
                PreencherDataGridViewProdutosAsync();
            }
            else
            {
                MessageBox.Show("Selecione um produto antes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
