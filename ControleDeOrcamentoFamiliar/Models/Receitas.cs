using System;
using System.ComponentModel.DataAnnotations;

namespace ControleDeOrcamentoFamiliar
{
    public class Receitas
    {
        [Key]
        public int IdReceita { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        [StringLength(250)]
        public string DescricaoReceita { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        public double ValorReceita { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        public DateTime DataReceita { get; set; }
    }
}
