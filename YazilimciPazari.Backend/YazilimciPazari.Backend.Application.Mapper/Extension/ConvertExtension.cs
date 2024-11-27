using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Abstract;
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
using YazilimciPazari.Backend.Domain.Entities.Abstract;
using YazilimciPazari.Backend.Domain.Entities.Concrete;

namespace YazilimciPazari.Backend.Application.Mapper.Extension
{
    static public class ConvertExtension
    {
        #region private generic converter methods
        private static IEnumerable<T> ConvertToEntity<T>(IEnumerable<IDTO> entity, IMapper mapper)
            where T : class, IEntity
            => mapper.Map<IEnumerable<T>>(entity);
        private static T ConvertToEntity<T>(IDTO entity, IMapper mapper)
            where T : class, IEntity
            => mapper.Map<T>(entity);

        private static IEnumerable<T> ConvertToDto<T>(IEnumerable<IEntity> entity, IMapper mapper)
            where T : class, IGetDTO
            => mapper.Map<IEnumerable<T>>(entity);
        private static T ConvertToDto<T>(IEntity entity, IMapper mapper)
            where T : class, IGetDTO
            => mapper.Map<T>(entity);
        #endregion

        #region Guid To entity
        public static IEnumerable<T> ConvertToEntityCustom<T>(this IEnumerable<Guid> entity, IMapper mapper)
            where T : class, IEntity
            => mapper.Map<IEnumerable<T>>(entity);

        public static T ConvertToEntityCustom<T>(this Guid entity, IMapper mapper)
            where T : class, IEntity
            => mapper.Map<T>(entity);
        #endregion

        #region Generic general convert methods
        public static IEnumerable<T> ConvertToEntityCustom<T>(this IEnumerable<IDTO> entity, IMapper mapper)
            where T : class, IEntity =>
            ConvertToEntity<T>(entity, mapper);
        public static T ConvertToEntityCustom<T>(this IDTO entity, IMapper mapper)
            where T : class, IEntity =>
            ConvertToEntity<T>(entity, mapper);

        public static IEnumerable<T> ConvertToDtoCustom<T>(this IEnumerable<IEntity> entity, IMapper mapper)
            where T : class, IGetDTO
            => ConvertToDto<T>(entity, mapper);
        public static T ConvertToDtoCustom<T>(this IEntity entity, IMapper mapper)
            where T : class, IGetDTO
            => ConvertToDto<T>(entity, mapper);

        public static IEnumerable<T> ConvertToEntityCustom<T>(this IEnumerable<int> entity, IMapper mapper)
            where T : class, IEntity
            => mapper.Map<IEnumerable<T>>(entity);

        public static T ConvertToEntityCustom<T>(this int entity, IMapper mapper)
            where T : class, IEntity
            => mapper.Map<T>(entity);
        #endregion

        #region Comment
        public static IEnumerable<Comment> ConvertToEntity(this IEnumerable<AddCommentDTO> entity, IMapper mapper) => ConvertToEntity<Comment>(entity, mapper);
        public static IEnumerable<Comment> ConvertToEntity(this IEnumerable<DeleteCommentDTO> entity, IMapper mapper) => ConvertToEntity<Comment>(entity, mapper);
        public static IEnumerable<Comment> ConvertToEntity(this IEnumerable<UpdateCommentDTO> entity, IMapper mapper) => ConvertToEntity<Comment>(entity, mapper);
        public static IEnumerable<Comment> ConvertToEntity(this IEnumerable<GetCommentDTO> entity, IMapper mapper) => ConvertToEntity<Comment>(entity, mapper);

        public static Comment ConvertToEntity(this AddCommentDTO entity, IMapper mapper) => ConvertToEntity<Comment>(entity, mapper);
        public static Comment ConvertToEntity(this DeleteCommentDTO entity, IMapper mapper) => ConvertToEntity<Comment>(entity, mapper);
        public static Comment ConvertToEntity(this UpdateCommentDTO entity, IMapper mapper) => ConvertToEntity<Comment>(entity, mapper);
        public static Comment ConvertToEntity(this GetCommentDTO entity, IMapper mapper) => ConvertToEntity<Comment>(entity, mapper);

        #endregion

        #region Company
        public static IEnumerable<Company> ConvertToEntity(this IEnumerable<AddCompanyDTO> entity, IMapper mapper) => ConvertToEntity<Company>(entity, mapper);
        public static IEnumerable<Company> ConvertToEntity(this IEnumerable<DeleteCompanyDTO> entity, IMapper mapper) => ConvertToEntity<Company>(entity, mapper);
        public static IEnumerable<Company> ConvertToEntity(this IEnumerable<UpdateCompanyDTO> entity, IMapper mapper) => ConvertToEntity<Company>(entity, mapper);
        public static IEnumerable<Company> ConvertToEntity(this IEnumerable<GetCompanyDTO> entity, IMapper mapper) => ConvertToEntity<Company>(entity, mapper);

        public static Company ConvertToEntity(this AddCompanyDTO entity, IMapper mapper) => ConvertToEntity<Company>(entity, mapper);
        public static Company ConvertToEntity(this DeleteCompanyDTO entity, IMapper mapper) => ConvertToEntity<Company>(entity, mapper);
        public static Company ConvertToEntity(this UpdateCompanyDTO entity, IMapper mapper) => ConvertToEntity<Company>(entity, mapper);
        public static Company ConvertToEntity(this GetCompanyDTO entity, IMapper mapper) => ConvertToEntity<Company>(entity, mapper);

        #endregion
        
        #region CompanyComment
        public static IEnumerable<CompanyComment> ConvertToEntity(this IEnumerable<AddCompanyCommentDTO> entity, IMapper mapper) => ConvertToEntity<CompanyComment>(entity, mapper);
        public static IEnumerable<CompanyComment> ConvertToEntity(this IEnumerable<DeleteCompanyCommentDTO> entity, IMapper mapper) => ConvertToEntity<CompanyComment>(entity, mapper);
        public static IEnumerable<CompanyComment> ConvertToEntity(this IEnumerable<UpdateCompanyCommentDTO> entity, IMapper mapper) => ConvertToEntity<CompanyComment>(entity, mapper);
        public static IEnumerable<CompanyComment> ConvertToEntity(this IEnumerable<GetCompanyCommentDTO> entity, IMapper mapper) => ConvertToEntity<CompanyComment>(entity, mapper);

        public static CompanyComment ConvertToEntity(this AddCompanyCommentDTO entity, IMapper mapper) => ConvertToEntity<CompanyComment>(entity, mapper);
        public static CompanyComment ConvertToEntity(this DeleteCompanyCommentDTO entity, IMapper mapper) => ConvertToEntity<CompanyComment>(entity, mapper);
        public static CompanyComment ConvertToEntity(this UpdateCompanyCommentDTO entity, IMapper mapper) => ConvertToEntity<CompanyComment>(entity, mapper);
        public static CompanyComment ConvertToEntity(this GetCompanyCommentDTO entity, IMapper mapper) => ConvertToEntity<CompanyComment>(entity, mapper);

        #endregion
        
        #region CompanySkill
        public static IEnumerable<CompanySkill> ConvertToEntity(this IEnumerable<AddCompanySkillDTO> entity, IMapper mapper) => ConvertToEntity<CompanySkill>(entity, mapper);
        public static IEnumerable<CompanySkill> ConvertToEntity(this IEnumerable<DeleteCompanySkillDTO> entity, IMapper mapper) => ConvertToEntity<CompanySkill>(entity, mapper);
        public static IEnumerable<CompanySkill> ConvertToEntity(this IEnumerable<UpdateCompanySkillDTO> entity, IMapper mapper) => ConvertToEntity<CompanySkill>(entity, mapper);
        public static IEnumerable<CompanySkill> ConvertToEntity(this IEnumerable<GetCompanySkillDTO> entity, IMapper mapper) => ConvertToEntity<CompanySkill>(entity, mapper);

        public static CompanySkill ConvertToEntity(this AddCompanySkillDTO entity, IMapper mapper) => ConvertToEntity<CompanySkill>(entity, mapper);
        public static CompanySkill ConvertToEntity(this DeleteCompanySkillDTO entity, IMapper mapper) => ConvertToEntity<CompanySkill>(entity, mapper);
        public static CompanySkill ConvertToEntity(this UpdateCompanySkillDTO entity, IMapper mapper) => ConvertToEntity<CompanySkill>(entity, mapper);
        public static CompanySkill ConvertToEntity(this GetCompanySkillDTO entity, IMapper mapper) => ConvertToEntity<CompanySkill>(entity, mapper);

        #endregion
        
        #region Project
        public static IEnumerable<Project> ConvertToEntity(this IEnumerable<AddProjectDTO> entity, IMapper mapper) => ConvertToEntity<Project>(entity, mapper);
        public static IEnumerable<Project> ConvertToEntity(this IEnumerable<DeleteProjectDTO> entity, IMapper mapper) => ConvertToEntity<Project>(entity, mapper);
        public static IEnumerable<Project> ConvertToEntity(this IEnumerable<UpdateProjectDTO> entity, IMapper mapper) => ConvertToEntity<Project>(entity, mapper);
        public static IEnumerable<Project> ConvertToEntity(this IEnumerable<GetProjectDTO> entity, IMapper mapper) => ConvertToEntity<Project>(entity, mapper);

        public static Project ConvertToEntity(this AddProjectDTO entity, IMapper mapper) => ConvertToEntity<Project>(entity, mapper);
        public static Project ConvertToEntity(this DeleteProjectDTO entity, IMapper mapper) => ConvertToEntity<Project>(entity, mapper);
        public static Project ConvertToEntity(this UpdateProjectDTO entity, IMapper mapper) => ConvertToEntity<Project>(entity, mapper);
        public static Project ConvertToEntity(this GetProjectDTO entity, IMapper mapper) => ConvertToEntity<Project>(entity, mapper);

        #endregion
        
        #region ProjectSkill
        public static IEnumerable<ProjectSkill> ConvertToEntity(this IEnumerable<AddProjectSkillDTO> entity, IMapper mapper) => ConvertToEntity<ProjectSkill>(entity, mapper);
        public static IEnumerable<ProjectSkill> ConvertToEntity(this IEnumerable<DeleteProjectSkillDTO> entity, IMapper mapper) => ConvertToEntity<ProjectSkill>(entity, mapper);
        public static IEnumerable<ProjectSkill> ConvertToEntity(this IEnumerable<UpdateProjectSkillDTO> entity, IMapper mapper) => ConvertToEntity<ProjectSkill>(entity, mapper);
        public static IEnumerable<ProjectSkill> ConvertToEntity(this IEnumerable<GetProjectSkillDTO> entity, IMapper mapper) => ConvertToEntity<ProjectSkill>(entity, mapper);

        public static ProjectSkill ConvertToEntity(this AddProjectSkillDTO entity, IMapper mapper) => ConvertToEntity<ProjectSkill>(entity, mapper);
        public static ProjectSkill ConvertToEntity(this DeleteProjectSkillDTO entity, IMapper mapper) => ConvertToEntity<ProjectSkill>(entity, mapper);
        public static ProjectSkill ConvertToEntity(this UpdateProjectSkillDTO entity, IMapper mapper) => ConvertToEntity<ProjectSkill>(entity, mapper);
        public static ProjectSkill ConvertToEntity(this GetProjectSkillDTO entity, IMapper mapper) => ConvertToEntity<ProjectSkill>(entity, mapper);

        #endregion
        
        #region Skill
        public static IEnumerable<Skill> ConvertToEntity(this IEnumerable<AddSkillDTO> entity, IMapper mapper) => ConvertToEntity<Skill>(entity, mapper);
        public static IEnumerable<Skill> ConvertToEntity(this IEnumerable<DeleteSkillDTO> entity, IMapper mapper) => ConvertToEntity<Skill>(entity, mapper);
        public static IEnumerable<Skill> ConvertToEntity(this IEnumerable<UpdateSkillDTO> entity, IMapper mapper) => ConvertToEntity<Skill>(entity, mapper);
        public static IEnumerable<Skill> ConvertToEntity(this IEnumerable<GetSkillDTO> entity, IMapper mapper) => ConvertToEntity<Skill>(entity, mapper);

        public static Skill ConvertToEntity(this AddSkillDTO entity, IMapper mapper) => ConvertToEntity<Skill>(entity, mapper);
        public static Skill ConvertToEntity(this DeleteSkillDTO entity, IMapper mapper) => ConvertToEntity<Skill>(entity, mapper);
        public static Skill ConvertToEntity(this UpdateSkillDTO entity, IMapper mapper) => ConvertToEntity<Skill>(entity, mapper);
        public static Skill ConvertToEntity(this GetSkillDTO entity, IMapper mapper) => ConvertToEntity<Skill>(entity, mapper);

        #endregion
        
        #region User
        public static IEnumerable<User> ConvertToEntity(this IEnumerable<AddUserDTO> entity, IMapper mapper) => ConvertToEntity<User>(entity, mapper);
        public static IEnumerable<User> ConvertToEntity(this IEnumerable<DeleteUserDTO> entity, IMapper mapper) => ConvertToEntity<User>(entity, mapper);
        public static IEnumerable<User> ConvertToEntity(this IEnumerable<UpdateUserDTO> entity, IMapper mapper) => ConvertToEntity<User>(entity, mapper);
        public static IEnumerable<User> ConvertToEntity(this IEnumerable<GetUserDTO> entity, IMapper mapper) => ConvertToEntity<User>(entity, mapper);
        public static IEnumerable<User> ConvertToEntity(this IEnumerable<RegisterUserDTO> entity, IMapper mapper) => ConvertToEntity<User>(entity, mapper);

        public static User ConvertToEntity(this AddUserDTO entity, IMapper mapper) => ConvertToEntity<User>(entity, mapper);
        public static User ConvertToEntity(this DeleteUserDTO entity, IMapper mapper) => ConvertToEntity<User>(entity, mapper);
        public static User ConvertToEntity(this UpdateUserDTO entity, IMapper mapper) => ConvertToEntity<User>(entity, mapper);
        public static User ConvertToEntity(this GetUserDTO entity, IMapper mapper) => ConvertToEntity<User>(entity, mapper);
        public static User ConvertToEntity(this RegisterUserDTO entity, IMapper mapper) => ConvertToEntity<User>(entity, mapper);

        #endregion

        #region UserComment
        public static IEnumerable<UserComment> ConvertToEntity(this IEnumerable<AddUserCommentDTO> entity, IMapper mapper) => ConvertToEntity<UserComment>(entity, mapper);
        public static IEnumerable<UserComment> ConvertToEntity(this IEnumerable<DeleteUserCommentDTO> entity, IMapper mapper) => ConvertToEntity<UserComment>(entity, mapper);
        public static IEnumerable<UserComment> ConvertToEntity(this IEnumerable<UpdateUserCommentDTO> entity, IMapper mapper) => ConvertToEntity<UserComment>(entity, mapper);
        public static IEnumerable<UserComment> ConvertToEntity(this IEnumerable<GetUserCommentDTO> entity, IMapper mapper) => ConvertToEntity<UserComment>(entity, mapper);

        public static UserComment ConvertToEntity(this AddUserCommentDTO entity, IMapper mapper) => ConvertToEntity<UserComment>(entity, mapper);
        public static UserComment ConvertToEntity(this DeleteUserCommentDTO entity, IMapper mapper) => ConvertToEntity<UserComment>(entity, mapper);
        public static UserComment ConvertToEntity(this UpdateUserCommentDTO entity, IMapper mapper) => ConvertToEntity<UserComment>(entity, mapper);
        public static UserComment ConvertToEntity(this GetUserCommentDTO entity, IMapper mapper) => ConvertToEntity<UserComment>(entity, mapper);

        #endregion
        
        #region UserSkill
        public static IEnumerable<UserSkill> ConvertToEntity(this IEnumerable<AddUserSkillDTO> entity, IMapper mapper) => ConvertToEntity<UserSkill>(entity, mapper);
        public static IEnumerable<UserSkill> ConvertToEntity(this IEnumerable<DeleteUserSkillDTO> entity, IMapper mapper) => ConvertToEntity<UserSkill>(entity, mapper);
        public static IEnumerable<UserSkill> ConvertToEntity(this IEnumerable<UpdateUserSkillDTO> entity, IMapper mapper) => ConvertToEntity<UserSkill>(entity, mapper);
        public static IEnumerable<UserSkill> ConvertToEntity(this IEnumerable<GetUserSkillDTO> entity, IMapper mapper) => ConvertToEntity<UserSkill>(entity, mapper);

        public static UserSkill ConvertToEntity(this AddUserSkillDTO entity, IMapper mapper) => ConvertToEntity<UserSkill>(entity, mapper);
        public static UserSkill ConvertToEntity(this DeleteUserSkillDTO entity, IMapper mapper) => ConvertToEntity<UserSkill>(entity, mapper);
        public static UserSkill ConvertToEntity(this UpdateUserSkillDTO entity, IMapper mapper) => ConvertToEntity<UserSkill>(entity, mapper);
        public static UserSkill ConvertToEntity(this GetUserSkillDTO entity, IMapper mapper) => ConvertToEntity<UserSkill>(entity, mapper);

        #endregion
    }
}
