using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Application.Validation.Extension;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Company;

namespace YazilimciPazari.Backend.Application.Validation.Validation.Company
{
    public class UpdateCompanyDTOValidation : UpdateValidation<UpdateCompanyDTO>
    {
        public UpdateCompanyDTOValidation() : base() 
        {
            RuleFor(e => e.Address).UpdateAdressValidation(maxLength:200);
            RuleFor(e => e.Description).UpdateDescriptionValidation(maxLength:10000);
            RuleFor(e => e.Name).UpdateNameValidation(maxLength:150);
            RuleFor(e => e.Website).UpdateWebsiteValidation(maxLength:100);
        }
    }
}
