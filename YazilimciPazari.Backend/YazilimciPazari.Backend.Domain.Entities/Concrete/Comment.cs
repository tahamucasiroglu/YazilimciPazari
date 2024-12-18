﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Entities.Base;

namespace YazilimciPazari.Backend.Domain.Entities.Concrete
{
    public class Comment : Entity
    {
        public string Text { get; set; } = string.Empty;

        virtual public ICollection<CompanyComment> CompanyComments { get; set; } = new HashSet<CompanyComment>();
        virtual public ICollection<UserComment> UserComments { get; set; } = new HashSet<UserComment>();
    }
}
