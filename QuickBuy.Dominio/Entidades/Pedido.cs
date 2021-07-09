using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public DateTime DtaPrevisaoEntrada { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoComplento { get; set; }
        public int NumeroEdereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um pedido ou muitos pedidos
        /// </summary>
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validade()
        {
            LimparMensagensValidacao();

            if (ItensPedido.Any())
            {
                AdicionarCritica("Critica: Pedido não pode ficar sem item de pedido");
            }

            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarCritica("Critica: CEP deve ser preenchido");
            }

            if (FormaPagamentoId== 0)
            {
                AdicionarCritica("Critica: Não foi informada a forma de pagamento");
            }
        }
    }
}
