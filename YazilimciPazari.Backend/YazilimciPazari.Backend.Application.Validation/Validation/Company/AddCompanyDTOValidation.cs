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
    public class AddCompanyDTOValidation : AddValidation<AddCompanyDTO>
    {
        public AddCompanyDTOValidation() : base()
        {
            RuleFor(e => e.Address).AddAdressValidation(maxLength:200);
            RuleFor(e => e.Description).AddDescriptionValidation(maxLength:10000);
            RuleFor(e => e.Name).AddNameValidation(maxLength:150);
            RuleFor(e => e.Password).AddPasswordValidation();
            RuleFor(e => e.TaxNumber).AddTaxNumberValidation();
            RuleFor(e => e.Website).AddWebsiteValidation(maxLength:100);
        }
    }
}
