using AutoMapper;
using ControleDeOrcamentoFamiliar.Data;
using ControleDeOrcamentoFamiliar.Models;

namespace ControleDeOrcamentoFamiliar.ProFile
{
    public class DespesasProfile : Profile
    {
        public DespesasProfile()
        {
            CreateMap<CreateDespesasDto, Despesas>();
            CreateMap<Despesas, ReadDespesasDto>();
            CreateMap<UpdateDespesasDto, Despesas>();
        }
    }
}
