using FluentValidation;
using YazilimciPazari.Backend.Application.Validation.Extension;
using YazilimciPazari.Backend.Domain.DTOs.Abstract;

namespace YazilimciPazari.Backend.Application.Validation.Base
{
    public class DeleteValidation<T> : AbstractValidator<T>
        where T : class, IDeleteDTO 
    {
        public DeleteValidation()
        {
            RuleFor(e => e.Id).IdValidation();
        }
    }
}
