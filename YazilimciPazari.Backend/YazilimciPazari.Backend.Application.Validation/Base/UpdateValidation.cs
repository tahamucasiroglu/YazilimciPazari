using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Extension;
using YazilimciPazari.Backend.Domain.DTOs.Abstract;

namespace YazilimciPazari.Backend.Application.Validation.Base
{
    public class UpdateValidation<T> : AbstractValidator<T>
        where T : class, IUpdateDTO 
    {
        public UpdateValidation() 
        {
            RuleFor(e => e.Id).IdValidation();
        }
    }
}
