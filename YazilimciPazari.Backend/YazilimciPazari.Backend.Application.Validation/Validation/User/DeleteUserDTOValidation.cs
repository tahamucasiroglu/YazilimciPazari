﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.User;

namespace YazilimciPazari.Backend.Application.Validation.Validation.User
{
    public class DeleteUserDTOValidation : DeleteValidation<DeleteUserDTO>
    {
        public DeleteUserDTOValidation() : base() { }
    }
}
