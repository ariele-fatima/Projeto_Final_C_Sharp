using ProjetoFinal.ProdutosMarcas.Dominio;
using ProjetoFinal.ProdutosMarcas.Persistencia.EF.Context;
using ProjetoFinal.Repositorio.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.ProdutosMarcas.Repositorio.EF
{
    public class RepositorioMarca : IRepositorioGenerico<Marca>
    {
        public void Atualizar(Marca entidade)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                contexto.Marcas.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Excluir(Marca entidade)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                contexto.Marcas.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();    
            }
        }

        public void Inserir(Marca entidade)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                contexto.Marcas.Add(entidade);
                contexto.SaveChanges();
            }
        }

        public Marca SelecionarPorId(int id)
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                return contexto.Marcas.Find(id);
            }
        }

        public List<Marca> SelecionarTodos()
        {
            using (ProdutosMarcasDbContext contexto = new ProdutosMarcasDbContext())
            {
                return contexto.Marcas.ToList();
            }
        }
    }
}
