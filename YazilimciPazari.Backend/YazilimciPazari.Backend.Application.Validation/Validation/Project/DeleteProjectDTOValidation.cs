using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Project;

namespace YazilimciPazari.Backend.Application.Validation.Validation.Project
{
    public class DeleteProjectDTOValidation : DeleteValidation<DeleteProjectDTO>
    {
        public DeleteProjectDTOValidation() : base() { }
    }
}
