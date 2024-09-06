using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Application.Validation.Extension;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.User;

namespace YazilimciPazari.Backend.Application.Validation.Validation.User
{
    public class UpdateUserDTOValidation : UpdateValidation<UpdateUserDTO>
    {
        public UpdateUserDTOValidation() : base() 
        {
            RuleFor(e => e.Name).AddNameValidation(maxLength: 50);
            RuleFor(e => e.Address).AddAdressValidation(maxLength: 150);
            RuleFor(e => e.Description).AddDescriptionValidation(maxLength: 500);
            RuleFor(e => e.Website).AddWebsiteValidation(maxLength: 150);
        }
    }
}
