using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Company;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract.Base;

namespace YazilimciPazari.Backend.Service.DatabaseService.Abstract
{
    public interface ICompanyService : IService<GetCompanyDTO, AddCompanyDTO, UpdateCompanyDTO>
    {
    }
}
