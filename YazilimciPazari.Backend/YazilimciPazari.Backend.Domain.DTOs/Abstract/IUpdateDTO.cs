﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimciPazari.Backend.Domain.DTOs.Abstract
{
    public interface IUpdateDTO : IDTO
    {
        public Guid Id { get; init; }
    }
}