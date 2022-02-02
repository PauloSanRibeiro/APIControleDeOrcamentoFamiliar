using AutoMapper;
using ControleDeOrcamentoFamiliar.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ControleDeOrcamentoFamiliar.Data
{
    public class UpdateDespesasDto
    {

        [Required]
        [StringLength(250)]
        public string DescricaoDespesa { get; set; } = default!;

        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        public double ValorDespesa { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        public DateTime DataDespesa { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Categorias Categoria { get; set; }
    }
}
