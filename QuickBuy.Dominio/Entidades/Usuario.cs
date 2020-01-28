using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }


        //Usuario pode ter nenhum ou muitos pedidos
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Critica - Email deve estar preenchido");
            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Critica - Senha deve estar preenchido");
        }
    }
}
