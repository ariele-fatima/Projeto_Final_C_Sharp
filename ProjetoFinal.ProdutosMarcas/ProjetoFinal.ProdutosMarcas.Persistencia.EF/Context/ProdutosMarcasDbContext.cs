using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFinal.ProdutosMarcas.Dominio;

namespace ProjetoFinal.ProdutosMarcas.Persistencia.EF.Context
{
    public class ProdutosMarcasDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Marca> Marcas { get; set; }

        public ProdutosMarcasDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .ToTable("PRODUTOS") //Especificando o nome da tabela
                .HasRequired(p => p.Marca) //precisa ter uma marca
                .WithMany(p => p.Produtos) //uma marca tem vários produtos
                .HasForeignKey(fk => fk.MarcaId) //MarcaId que liga o produto a marca
                .WillCascadeOnDelete(false); //Não deletar a marca relacionada quando o produto for

            modelBuilder.Entity<Marca>()
                .ToTable("MARCAS"); //Especificando o nome da tabela
        }
    }
}
