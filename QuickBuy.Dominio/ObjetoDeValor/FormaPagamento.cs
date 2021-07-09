using QuickBuy.Dominio.Enumerador;


namespace QuickBuy.Dominio.ObjetoDeValor
{
   public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool EhBoleto 
        {
            get { return Id == (int)TipoFormaPagametoEnum.Boleto;}
        }
        public bool EhCartao
        {
            get { return Id == (int)TipoFormaPagametoEnum.CartaoCredito; }
        }
        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagametoEnum.Deposito; }
        }
        public bool NaofoiDefinido
        {
            get { return Id == (int)TipoFormaPagametoEnum.NaoDefidpo; }
        }
    }
}
