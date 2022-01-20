using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ControleDeOrcamentoFamiliar.Models
{
    public class Despesas
    {

        [key]
        public int Id { get; set; }

        [JsonPropertyName("Descrição")]
        [Required]
        [StringLength(250)]
        public string DescricaoDespesa { get; set; } = default!;

        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        public double ValorDespesa { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        public DateTime DataDespesa { get; set; }

    }
}
