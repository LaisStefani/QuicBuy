using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        [NotMapped]
        public List<string> _mensagesValidacao { get; set; }
        [NotMapped]
        private List<string> MensagemValidacao 
        {
            get { return _mensagesValidacao ?? (_mensagesValidacao = new List<string>()); }
        }
        protected void LimparMensagensValidacao() 
        {
            MensagemValidacao.Clear();
        }
        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

        //forças as outras classes a validar
        public abstract void Validade();
        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }

        }

    }
}
