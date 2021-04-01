using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoOperacoes.Models
{
    public class Identity 
    {

        protected Identity()
        {
            ID = Guid.NewGuid().ToString();
        }

        [Column("id")]

        protected string ID;
    }
}
