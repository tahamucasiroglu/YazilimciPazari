using AutoMapper;
using Azure;
using Microsoft.Extensions.Configuration;
using YazilimciPazari.Backend.Application.Mapper.Extension;
using YazilimciPazari.Backend.Domain.DTOs.Abstract;
using YazilimciPazari.Backend.Domain.DTOs.Base;
using YazilimciPazari.Backend.Domain.Entities.Abstract;
using YazilimciPazari.Backend.Domain.Returns.Abstract;
using YazilimciPazari.Backend.Domain.Returns.Concrete;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Abstract.Base;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract.Base;

namespace YazilimciPazari.Backend.Service.DatabaseService.Base
{
    abstract public class Service
    {
        public Service()
        {
            
        }
        virtual public IReturn<TDto> EmptyDataReturn<TDto>(string? message = null) =>
           new SuccessReturn<TDto>("Data is null " + message);
        virtual public IReturn EmptyDataReturn(string? Message = null) => 
            new SuccessReturn("Başarıyla döndürme sağlandı fakat data null <->" + Message);

        virtual public IReturn<TDto> ErrorDataReturn<TDto>(string? message = null, Exception? exception = null) => 
            new ErrorReturn<TDto>(message, exception);
        virtual public IReturn ErrorDataReturn(string? message = null, Exception? exception = null) => 
            new ErrorReturn(message, exception);

        virtual public IReturn<TDto> NotFoundReturn<TDto>(string? message = null, Exception? exception = null) => 
            new ErrorReturn<TDto>(message, exception);

        virtual public IReturn<TDto> ReturnEmptyError<TDto>(string? message = null) => 
            new ErrorReturn<TDto>(message);
        virtual public IReturn<TDto> ConvertToReturn<TEntity, TDto>(IReturn<TEntity> result, IMapper mapper)
            where TEntity : class, IEntity, new()
            where TDto : class, IGetDTO
        {
            if (result.Status)
            {
                return result.Data == null ?
                    EmptyDataReturn<TDto>(result.Message) :
                    new SuccessReturn<TDto>(result.Data.ConvertToDtoCustom<TDto>(mapper));
            }
            else
            {
                return ErrorDataReturn<TDto>(result.Message, result.Exception);
            }
        }

        virtual public IReturn<IEnumerable<TDto>> ConvertToReturn<TEntity, TDto>(IReturn<IEnumerable<TEntity>> result, IMapper mapper)
            where TDto : class, IGetDTO
            where TEntity : class, IEntity, new()
        {
            if (result.Status)
            {
                return (result.Data == null ?
                    EmptyDataReturn<IEnumerable<TDto>>(result.Message) :
                    new SuccessReturn<IEnumerable<TDto>>(result.Data.ConvertToDtoCustom<TDto>(mapper)));
            }
            else
            {
                return ErrorDataReturn<IEnumerable<TDto>>(result.Message, result.Exception);
            }
        }

        virtual public IReturn<TEntity> ConvertToReturn<TEntity>(IReturn<TEntity> result)
            where TEntity : class, IEntity, new()
        {
            if (result.Status)
            {
                return result.Data == null ?
                    EmptyDataReturn<TEntity>(result.Message) :
                    new SuccessReturn<TEntity>(result.Data);
            }
            else
            {
                return ErrorDataReturn<TEntity>(result.Message, result.Exception);
            }
        }

        virtual public IReturn<TEntity> ConvertToReturn<TEntity>(TEntity result)
        {
            return result == null ?
                EmptyDataReturn<TEntity>(null) :
                new SuccessReturn<TEntity>(result);

        }

        virtual public IReturn ConvertToReturn(bool status)
        {
            return status ?
                new SuccessReturn() :
                new ErrorReturn();
        }
    }

    abstract public class Service<TEntity> : Service, IService
        where TEntity : class, IEntity, new()
    {
        internal readonly IRepository<TEntity> repository;
        internal readonly IMapper mapper;
        internal readonly IConfiguration configuration;
        public Service(IRepository<TEntity> repository, IMapper mapper, IConfiguration configuration)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.configuration = configuration;
        }

        public void Dispose()
        {
            repository.Dispose();
        }
    }
    abstract public class Service<TEntity, TResponse> : Service<TEntity>, IService<TResponse>
        where TEntity : class, IEntity, new()
        where TResponse : class, IGetDTO
    {
        public Service(IRepository<TEntity> repository, IMapper mapper, IConfiguration configuration) : base(repository, mapper, configuration) { }
        public virtual IReturn<IEnumerable<TResponse>> GetAll()
        {
            return ConvertToReturn<TEntity, TResponse>(repository.GetAll(), mapper);
        }

        public virtual async Task<IReturn<IEnumerable<TResponse>>> GetAllAsync()
        {
            return ConvertToReturn<TEntity, TResponse>(await repository.GetAllAsync(), mapper);
        }
    }
    abstract public class Service<TEntity, TResponse, AddRequest> : Service<TEntity, TResponse>, IService<TResponse, AddRequest>
        where TEntity : class, IEntity, new()
        where TResponse : class, IGetDTO
        where AddRequest : class, IAddDTO
    {
        public Service(IRepository<TEntity> repository, IMapper mapper, IConfiguration configuration) : base(repository, mapper, configuration) { }

        public virtual IReturn Add(AddRequest entity)
        {
            return ConvertToReturn(repository.Add(entity.ConvertToEntityCustom<TEntity>(mapper)).Status);
        }

        public virtual IReturn Add(IEnumerable<AddRequest> entity)
        {
            return ConvertToReturn(repository.Add(entity.ConvertToEntityCustom<TEntity>(mapper)).Status);
        }

        public virtual async Task<IReturn> AddAsync(AddRequest entity)
        {
            return ConvertToReturn((await repository.AddAsync(entity.ConvertToEntityCustom<TEntity>(mapper))).Status);
        }

        public virtual async Task<IReturn> AddAsync(IEnumerable<AddRequest> entity)
        {
            return ConvertToReturn((await repository.AddAsync(entity.ConvertToEntityCustom<TEntity>(mapper))).Status);
        }

        public virtual IReturn Delete(Guid entity)
        {
            return ConvertToReturn(repository.Delete(mapper.Map<TEntity>(entity)).Status);
        }

        public virtual IReturn Delete(IEnumerable<Guid> entity)
        {
            return ConvertToReturn(repository.Delete(mapper.Map<IEnumerable<TEntity>>(entity)).Status);
        }

        public virtual async Task<IReturn> DeleteAsync(Guid entity)
        {
            return ConvertToReturn((await repository.DeleteAsync(mapper.Map<TEntity>(entity))).Status);
        }

        public virtual async Task<IReturn> DeleteAsync(IEnumerable<Guid> entity)
        {
            return ConvertToReturn((await repository.DeleteAsync(mapper.Map<IEnumerable<TEntity>>(entity))).Status);
        }
    }

    abstract public class Service<TEntity, TResponse, AddRequest, UpdateRequest> : Service<TEntity, TResponse, AddRequest>, IService<TResponse, AddRequest, UpdateRequest>
        where TEntity : class, IEntity, new()
        where TResponse : class, IGetDTO
        where AddRequest : class, IAddDTO
        where UpdateRequest : class, IUpdateDTO
    {
        public Service(IRepository<TEntity> repository, IMapper mapper, IConfiguration configuration) : base(repository, mapper, configuration) { }

        public virtual IReturn<TResponse> Update(UpdateRequest entity)
        {
            return ConvertToReturn<TEntity, TResponse>(repository.Update(entity.ConvertToEntityCustom<TEntity>(mapper)), mapper);
        }

        public virtual IReturn<IEnumerable<TResponse>> Update(IEnumerable<UpdateRequest> entity)
        {
            return ConvertToReturn<TEntity, TResponse>(repository.Update(entity.ConvertToEntityCustom<TEntity>(mapper)), mapper);
        }

        public virtual async Task<IReturn<TResponse>> UpdateAsync(UpdateRequest entity)
        {
            return ConvertToReturn<TEntity, TResponse>(await repository.UpdateAsync(entity.ConvertToEntityCustom<TEntity>(mapper)), mapper);
        }

        public virtual async Task<IReturn<IEnumerable<TResponse>>> UpdateAsync(IEnumerable<UpdateRequest> entity)
        {
            return ConvertToReturn<TEntity, TResponse>(await repository.UpdateAsync(entity.ConvertToEntityCustom<TEntity>(mapper)), mapper);
        }
    }
}
