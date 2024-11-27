using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Mapper.Extension;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Comment;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Company;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.CompanyComment;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.CompanySkill;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Project;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.ProjectSkill;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Skill;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.User;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.UserComment;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.UserSkill;
using YazilimciPazari.Backend.Domain.Entities.Concrete;

namespace YazilimciPazari.Backend.Application.Mapper.MapProfile
{
    public class MapProfile : Profile
    {
        public MapProfile() 
        {
            #region Comment
            CreateMap<AddCommentDTO, Comment>().DefaultAddMapConfig();
            CreateMap<UpdateCommentDTO, Comment>().DefaultUpdateMapConfig();
            CreateMap<DeleteCommentDTO, Comment>().DefaultDeleteMapConfig();
            CreateMap<Comment, GetCommentDTO>();
            #endregion

            #region Company
            CreateMap<AddCompanyDTO, Company>().DefaultAddMapConfig();
            CreateMap<UpdateCompanyDTO, Company>().DefaultUpdateMapConfig();
            CreateMap<DeleteCompanyDTO, Company>().DefaultDeleteMapConfig();
            CreateMap<Company, GetCompanyDTO>();
            #endregion

            #region CompanyComment
            CreateMap<AddCompanyCommentDTO, CompanyComment>().DefaultAddMapConfig();
            CreateMap<UpdateCompanyCommentDTO, CompanyComment>().DefaultUpdateMapConfig();
            CreateMap<DeleteCompanyCommentDTO, CompanyComment>().DefaultDeleteMapConfig();
            CreateMap<CompanyComment, GetCompanyCommentDTO>();
            #endregion

            #region CompanySkill
            CreateMap<AddCompanySkillDTO, CompanySkill>().DefaultAddMapConfig();
            CreateMap<UpdateCompanySkillDTO, CompanySkill>().DefaultUpdateMapConfig();
            CreateMap<DeleteCompanySkillDTO, CompanySkill>().DefaultDeleteMapConfig();
            CreateMap<CompanySkill, GetCompanySkillDTO>();
            #endregion

            #region Project
            CreateMap<AddProjectDTO, Project>().DefaultAddMapConfig();
            CreateMap<UpdateProjectDTO, Project>().DefaultUpdateMapConfig();
            CreateMap<DeleteProjectDTO, Project>().DefaultDeleteMapConfig();
            CreateMap<Project, GetProjectDTO>();
            #endregion

            #region ProjectSkill
            CreateMap<AddProjectSkillDTO, ProjectSkill>().DefaultAddMapConfig();
            CreateMap<UpdateProjectSkillDTO, ProjectSkill>().DefaultUpdateMapConfig();
            CreateMap<DeleteProjectSkillDTO, ProjectSkill>().DefaultDeleteMapConfig();
            CreateMap<ProjectSkill, GetProjectSkillDTO>();
            #endregion

            #region Skill
            CreateMap<AddSkillDTO, Skill>().DefaultAddMapConfig();
            CreateMap<UpdateSkillDTO, Skill>().DefaultUpdateMapConfig();
            CreateMap<DeleteSkillDTO, Skill>().DefaultDeleteMapConfig();
            CreateMap<Skill, GetSkillDTO>();
            #endregion

            #region User
            CreateMap<AddUserDTO, User>().DefaultAddMapConfig();
            CreateMap<UpdateUserDTO, User>().DefaultUpdateMapConfig();
            CreateMap<DeleteUserDTO, User>().DefaultDeleteMapConfig();
            CreateMap<RegisterUserDTO, User>()
                .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => false));
            CreateMap<User, GetUserDTO>();
            #endregion

            #region UserComment
            CreateMap<AddUserCommentDTO, UserComment>().DefaultAddMapConfig();
            CreateMap<UpdateUserCommentDTO, UserComment>().DefaultUpdateMapConfig();
            CreateMap<DeleteUserCommentDTO, UserComment>().DefaultDeleteMapConfig();
            CreateMap<UserComment, GetUserCommentDTO>();
            #endregion

            #region UserSkill
            CreateMap<AddUserSkillDTO, UserSkill>().DefaultAddMapConfig();
            CreateMap<UpdateUserSkillDTO, UserSkill>().DefaultUpdateMapConfig();
            CreateMap<DeleteUserSkillDTO, UserSkill>().DefaultDeleteMapConfig();
            CreateMap<UserSkill, GetUserSkillDTO>();
            #endregion
        }
    }
}
