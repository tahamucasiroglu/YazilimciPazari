using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Abstract;
using YazilimciPazari.Backend.Domain.Entities.Abstract;

namespace YazilimciPazari.Backend.Application.Mapper.Extension
{
    static public class ConfigExtension
    {
        static public IMappingExpression<TDest, TSrc> DefaultAddMapConfig<TDest, TSrc>(this IMappingExpression<TDest, TSrc> mapper)
            where TDest : IAddDTO
            where TSrc : IEntity
            => mapper.ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => false));

        static public IMappingExpression<TDest, TSrc> DefaultUpdateMapConfig<TDest, TSrc>(this IMappingExpression<TDest, TSrc> mapper)
            where TDest : IUpdateDTO
            where TSrc : IEntity
            => mapper.ForMember(dest => dest.UpdateDate, src => src.MapFrom(src => DateTime.UtcNow));

        static public IMappingExpression<TDest, TSrc> DefaultDeleteMapConfig<TDest, TSrc>(this IMappingExpression<TDest, TSrc> mapper)
            where TDest : IDeleteDTO
            where TSrc : IEntity
            => mapper.ForMember(dest => dest.DeleteDate, src => src.MapFrom(src => DateTime.UtcNow))
            .ForMember(dest => dest.IsDeleted, src => src.MapFrom(src => true));
    }
}
