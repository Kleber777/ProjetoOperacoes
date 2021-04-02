using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoOperacoes.Models
{
    public class Identity 
    {

        public Identity()
        {
            ID = Guid.NewGuid().ToString();
        }

        [Column("id")]

        public string ID;
    }
}
