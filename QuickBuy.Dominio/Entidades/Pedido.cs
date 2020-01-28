using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public string UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }


        public int FormaPagamentoId { get;  set; } /*ARMAZENA UMA FORMA DE PAGAMENTO*/
        public FormaPagamento FormaPagamento { get; set; }


        //Pedido deve ter pelo menos um item pedido ou muitos pedidos
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();


            if (!ItensPedido.Any())
            
                AdicionarCritica("Critica - Pedido não pode ficar sem item de pedido");
            

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Critica - CEP de estar preenchido");

            if (FormaPagamentoId == 0)
                AdicionarCritica("Critica - Forma de pagamento não selecionada");
        }


    }
}
