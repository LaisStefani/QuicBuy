using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamentos { get; set; }
        public QuickBuyContexto(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //classe de mapeamento aqui.. 
            //modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            //modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            //modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            //modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            //modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento() 
                { 
                    Id = 1,
                    Nome = "Boleto",
                    Descricao = "Forma de pagamento em boleto"
                   
                },
                new FormaPagamento()
                {
                    Id = 2,
                    Nome = "Cartão de Crédito",
                    Descricao = "Forma de pagamento em cartão de crédito"
                  
                },
                new FormaPagamento()
                {
                    Id = 3,
                    Nome = "Depósito",
                    Descricao = "Forma de pagamento em deposito"
                   
                }
                );

            base.OnModelCreating(modelBuilder);
        }

    }
}
