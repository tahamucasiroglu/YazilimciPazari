using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Application.Validation.Extension;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Project;

namespace YazilimciPazari.Backend.Application.Validation.Validation.Project
{
    public class AddProjectDTOValidation : AddValidation<AddProjectDTO>
    {
        public AddProjectDTOValidation() : base() 
        {
            RuleFor(e => e.UserId).IdValidation();
            RuleFor(e => e.Description).AddDescriptionValidation(maxLength: 500);
            RuleFor(e => e.Name).AddNameValidation(maxLength: 50);
        }
    }
}
