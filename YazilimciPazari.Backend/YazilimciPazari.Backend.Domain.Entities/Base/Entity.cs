﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Entities.Abstract;

namespace YazilimciPazari.Backend.Domain.Entities.Base
{
    abstract public class Entity : IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
