using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Abstract;

namespace YazilimciPazari.Backend.Application.Validation.Base
{
    public class AddValidation<T> : AbstractValidator<T>
        where T : class, IAddDTO
    {
        public AddValidation() 
        {
        }
    }
}
