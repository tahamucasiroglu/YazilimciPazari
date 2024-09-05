﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Base;

namespace YazilimciPazari.Backend.Domain.DTOs.Concrete.CompanyComment
{
    public sealed record AddCompanyCommentDTO : AddDTO
    {
        public Guid CommentId { get; init; }
        public Guid CompanyId { get; init; }
    }
}
