using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Company;

namespace YazilimciPazari.Backend.Application.Validation.Validation.Company
{
    public class DeleteCompanyDTOValidation : DeleteValidation<DeleteCompanyDTO>
    {
        public DeleteCompanyDTOValidation() : base()
        {
            
        }
    }
}
