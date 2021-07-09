

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

      
        public override void Validade()
        {

            if (ProdutoId == 0)
            {
                AdicionarCritica("Critica: Não foi possivel indetificar a referencia do produto");
            }
            if (Quantidade == 0)
            {
                AdicionarCritica("Critica: Quantidade não informada");
            }
        }
    }
}
