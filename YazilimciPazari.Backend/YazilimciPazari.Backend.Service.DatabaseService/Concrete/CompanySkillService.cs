using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Company;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.CompanySkill;
using YazilimciPazari.Backend.Domain.Entities.Concrete;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Abstract.Base;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract;
using YazilimciPazari.Backend.Service.DatabaseService.Base;

namespace YazilimciPazari.Backend.Service.DatabaseService.Concrete
{
    public class CompanySkillService : Service<Company, GetCompanySkillDTO, AddCompanySkillDTO, UpdateCompanySkillDTO>, ICompanySkillService
    {
        public CompanySkillService(IRepository<Company> repository, IMapper mapper, IConfiguration configuration) : base(repository, mapper, configuration)
        {
        }
    }
}
