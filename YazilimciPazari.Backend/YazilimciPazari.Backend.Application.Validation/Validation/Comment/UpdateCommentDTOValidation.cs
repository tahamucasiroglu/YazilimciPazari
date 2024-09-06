﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Application.Validation.Extension;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Comment;

namespace YazilimciPazari.Backend.Application.Validation.Validation.Comment
{
    public class UpdateCommentDTOValidation : UpdateValidation<UpdateCommentDTO>
    {
        public UpdateCommentDTOValidation() : base()
        {
            RuleFor(e => e.Text).UpdateTextValidation(maxLength:500);
        }
    }
}
