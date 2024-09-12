using Azure;
using YazilimciPazari.Backend.Domain.DTOs.Abstract;
using YazilimciPazari.Backend.Domain.Returns.Abstract;


namespace YazilimciPazari.Backend.Service.DatabaseService.Abstract.Base
{
    public interface IService<TResponse, TAddRequest, TUpdateRequest> : IService<TResponse, TAddRequest>, _IServiceUpdate<TResponse, TUpdateRequest>, IService
        where TResponse : class, IGetDTO
        where TAddRequest : class, IAddDTO
        where TUpdateRequest : class, IUpdateDTO
    { }

    public interface IService<TResponse> : _IServiceGetAll<TResponse>, IService
        where TResponse : class, IGetDTO
    { }

    public interface IService<TResponse, TAddRequest> : IService<TResponse>, _IServiceAdd<TResponse, TAddRequest>, _IServiceDelete<TResponse>, IService
        where TResponse : class, IGetDTO
        where TAddRequest : class, IAddDTO
    { }

    public interface IService : IDisposable //marker
    { }

    public interface _IServiceGetAll<TResponse> where TResponse : class, IGetDTO
    {
        public IReturn<IEnumerable<TResponse>> GetAll();
        public Task<IReturn<IEnumerable<TResponse>>> GetAllAsync();

        public IReturn<TResponse> GetById(Guid id);
        public Task<IReturn<TResponse>> GetByIdAsync(Guid id);
    }

    public interface _IServiceAdd<TResponse, in TAddRequest>
    {
        public IReturn Add(TAddRequest entity);
        public IReturn Add(IEnumerable<TAddRequest> entity);
        public Task<IReturn> AddAsync(TAddRequest entity);
        public Task<IReturn> AddAsync(IEnumerable<TAddRequest> entity);
    }

    public interface _IServiceUpdate<TResponse, in TUpdateRequest>
    {
        public IReturn<TResponse> Update(TUpdateRequest entity);
        public IReturn<IEnumerable<TResponse>> Update(IEnumerable<TUpdateRequest> entity);
        public Task<IReturn<TResponse>> UpdateAsync(TUpdateRequest entity);
        public Task<IReturn<IEnumerable<TResponse>>> UpdateAsync(IEnumerable<TUpdateRequest> entity);
    }
    public interface _IServiceDelete<TResponse>
    {
        public IReturn Delete(Guid entity);
        public IReturn Delete(IEnumerable<Guid> entity);
        public Task<IReturn> DeleteAsync(Guid entity);
        public Task<IReturn> DeleteAsync(IEnumerable<Guid> entity);
    }
}
