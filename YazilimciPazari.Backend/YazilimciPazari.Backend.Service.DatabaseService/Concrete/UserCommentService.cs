﻿using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.UserComment;
using YazilimciPazari.Backend.Domain.Entities.Concrete;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Abstract.Base;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract;
using YazilimciPazari.Backend.Service.DatabaseService.Base;

namespace YazilimciPazari.Backend.Service.DatabaseService.Concrete
{
    public class UserCommentService : Service<UserComment, GetUserCommentDTO, AddUserCommentDTO, UpdateUserCommentDTO>, IUserCommentService
    {
        public UserCommentService(IRepository<UserComment> repository, IMapper mapper, IConfiguration configuration) : base(repository, mapper, configuration)
        {
        }
    }
}