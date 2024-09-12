using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Entities.Abstract;
using YazilimciPazari.Backend.Domain.Returns.Abstract;

namespace YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Abstract.Base
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : class, IEntity
    {
        public IReturn<TEntity> Get(Expression<Func<TEntity, bool>> filter);
        public Task<IReturn<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter);

        public IReturn<IEnumerable<TEntity>> _GetAll<TOrder>(Expression<Func<TEntity, bool>>? filter = null, Expression<Func<TEntity, TOrder>>? order = null, bool Reserve = false, Range? TakeRange = null);
        public IReturn<IEnumerable<TEntity>> GetAll() => _GetAll<TEntity>();
        public IReturn<IEnumerable<TEntity>> GetAll(Range TakeRange) => _GetAll<TEntity>(TakeRange: TakeRange);
        public IReturn<IEnumerable<TEntity>> GetAll(bool Reserve) => _GetAll<TEntity>(Reserve: Reserve);
        public IReturn<IEnumerable<TEntity>> GetAll(bool Reserve, Range TakeRange) => _GetAll<TEntity>(Reserve: Reserve, TakeRange: TakeRange);
        public IReturn<IEnumerable<TEntity>> GetAll<TOrder>(Expression<Func<TEntity, TOrder>> order) => _GetAll<TOrder>(order: order);
        public IReturn<IEnumerable<TEntity>> GetAll<TOrder>(Expression<Func<TEntity, TOrder>> order, Range TakeRange) => _GetAll<TOrder>(order: order, TakeRange: TakeRange);
        public IReturn<IEnumerable<TEntity>> GetAll<TOrder>(Expression<Func<TEntity, TOrder>> order, bool Reserve) => _GetAll<TOrder>(order: order, Reserve: Reserve);
        public IReturn<IEnumerable<TEntity>> GetAll<TOrder>(Expression<Func<TEntity, TOrder>> order, bool Reserve, Range TakeRange) => _GetAll<TOrder>(order: order, Reserve: Reserve, TakeRange: TakeRange);
        public IReturn<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter) => _GetAll<TEntity>(filter: filter);
        public IReturn<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter, Range TakeRange) => _GetAll<TEntity>(filter: filter, TakeRange: TakeRange);
        public IReturn<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter, bool Reserve) => _GetAll<TEntity>(filter: filter, Reserve: Reserve);
        public IReturn<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter, bool Reserve, Range TakeRange) => _GetAll<TEntity>(filter: filter, Reserve: Reserve, TakeRange: TakeRange);
        public IReturn<IEnumerable<TEntity>> GetAll<TOrder>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TOrder>> order) => _GetAll<TOrder>(filter: filter, order: order);
        public IReturn<IEnumerable<TEntity>> GetAll<TOrder>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TOrder>> order, Range TakeRange) => _GetAll<TOrder>(filter: filter, order: order, TakeRange: TakeRange);
        public IReturn<IEnumerable<TEntity>> GetAll<TOrder>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TOrder>> order, bool Reserve) => _GetAll<TOrder>(filter: filter, order: order, Reserve: Reserve);
        public IReturn<IEnumerable<TEntity>> GetAll<TOrder>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TOrder>> order, bool Reserve, Range TakeRange) => _GetAll<TOrder>(filter: filter, order: order, Reserve: Reserve, TakeRange: TakeRange);




        public Task<IReturn<IEnumerable<TEntity>>> _GetAllAsync<TOrder>(Expression<Func<TEntity, bool>>? filter = null, Expression<Func<TEntity, TOrder>>? order = null, bool Reserve = false, Range? TakeRange = null);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllAsync() => await _GetAllAsync<TEntity>();
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllAsync(Range TakeRange) => await _GetAllAsync<TEntity>(TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllAsync(bool Reserve) => await _GetAllAsync<TEntity>(Reserve: Reserve);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllAsync(bool Reserve, Range TakeRange) => await _GetAllAsync<TEntity>(Reserve: Reserve, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllAsync<TOrder>(Expression<Func<TEntity, TOrder>> order) => await _GetAllAsync<TOrder>(order: order);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllAsync<TOrder>(Expression<Func<TEntity, TOrder>> order, Range TakeRange) => await _GetAllAsync<TOrder>(order: order, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllAsync<TOrder>(Expression<Func<TEntity, TOrder>> order, bool Reserve) => await _GetAllAsync<TOrder>(order: order, Reserve: Reserve);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllAsync<TOrder>(Expression<Func<TEntity, TOrder>> order, bool Reserve, Range TakeRange) => await _GetAllAsync<TOrder>(order: order, Reserve: Reserve, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllAsync(Expression<Func<TEntity, bool>> filter) => await _GetAllAsync<TEntity>(filter: filter);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllAsync(Expression<Func<TEntity, bool>> filter, Range TakeRange) => await _GetAllAsync<TEntity>(filter: filter, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllAsync(Expression<Func<TEntity, bool>> filter, bool Reserve) => await _GetAllAsync<TEntity>(filter: filter, Reserve: Reserve);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllAsync(Expression<Func<TEntity, bool>> filter, bool Reserve, Range TakeRange) => await _GetAllAsync<TEntity>(filter: filter, Reserve: Reserve, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllAsync<TOrder>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TOrder>> order) => await _GetAllAsync<TOrder>(filter: filter, order: order);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllAsync<TOrder>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TOrder>> order, Range TakeRange) => await _GetAllAsync<TOrder>(filter: filter, order: order, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllAsync<TOrder>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TOrder>> order, bool Reserve) => await _GetAllAsync<TOrder>(filter: filter, order: order, Reserve: Reserve);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllAsync<TOrder>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TOrder>> order, bool Reserve, Range TakeRange) => await _GetAllAsync<TOrder>(filter: filter, order: order, Reserve: Reserve, TakeRange: TakeRange);

        public IReturn<IEnumerable<TEntity>> _GetAllDeleted<TOrder>(Expression<Func<TEntity, bool>>? filter = null, Expression<Func<TEntity, TOrder>>? order = null, bool Reserve = false, Range? TakeRange = null);
        public IReturn<IEnumerable<TEntity>> GetAllDeleted() => _GetAllDeleted<TEntity>();
        public IReturn<IEnumerable<TEntity>> GetAllDeleted(Range TakeRange) => _GetAllDeleted<TEntity>(TakeRange: TakeRange);
        public IReturn<IEnumerable<TEntity>> GetAllDeleted(bool Reserve) => _GetAllDeleted<TEntity>(Reserve: Reserve);
        public IReturn<IEnumerable<TEntity>> GetAllDeleted(bool Reserve, Range TakeRange) => _GetAllDeleted<TEntity>(Reserve: Reserve, TakeRange: TakeRange);
        public IReturn<IEnumerable<TEntity>> GetAllDeleted<TOrder>(Expression<Func<TEntity, TOrder>> order) => _GetAllDeleted<TOrder>(order: order);
        public IReturn<IEnumerable<TEntity>> GetAllDeleted<TOrder>(Expression<Func<TEntity, TOrder>> order, Range TakeRange) => _GetAllDeleted<TOrder>(order: order, TakeRange: TakeRange);
        public IReturn<IEnumerable<TEntity>> GetAllDeleted<TOrder>(Expression<Func<TEntity, TOrder>> order, bool Reserve) => _GetAllDeleted<TOrder>(order: order, Reserve: Reserve);
        public IReturn<IEnumerable<TEntity>> GetAllDeleted<TOrder>(Expression<Func<TEntity, TOrder>> order, bool Reserve, Range TakeRange) => _GetAllDeleted<TOrder>(order: order, Reserve: Reserve, TakeRange: TakeRange);
        public IReturn<IEnumerable<TEntity>> GetAllDeleted(Expression<Func<TEntity, bool>> filter) => _GetAllDeleted<TEntity>(filter: filter);
        public IReturn<IEnumerable<TEntity>> GetAllDeleted(Expression<Func<TEntity, bool>> filter, Range TakeRange) => _GetAllDeleted<TEntity>(filter: filter, TakeRange: TakeRange);
        public IReturn<IEnumerable<TEntity>> GetAllDeleted(Expression<Func<TEntity, bool>> filter, bool Reserve) => _GetAllDeleted<TEntity>(filter: filter, Reserve: Reserve);
        public IReturn<IEnumerable<TEntity>> GetAllDeleted(Expression<Func<TEntity, bool>> filter, bool Reserve, Range TakeRange) => _GetAllDeleted<TEntity>(filter: filter, Reserve: Reserve, TakeRange: TakeRange);
        public IReturn<IEnumerable<TEntity>> GetAllDeleted<TOrder>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TOrder>> order) => _GetAllDeleted<TOrder>(filter: filter, order: order);
        public IReturn<IEnumerable<TEntity>> GetAllDeleted<TOrder>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TOrder>> order, Range TakeRange) => _GetAllDeleted<TOrder>(filter: filter, order: order, TakeRange: TakeRange);
        public IReturn<IEnumerable<TEntity>> GetAllDeleted<TOrder>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TOrder>> order, bool Reserve) => _GetAllDeleted<TOrder>(filter: filter, order: order, Reserve: Reserve);
        public IReturn<IEnumerable<TEntity>> GetAllDeleted<TOrder>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TOrder>> order, bool Reserve, Range TakeRange) => _GetAllDeleted<TOrder>(filter: filter, order: order, Reserve: Reserve, TakeRange: TakeRange);


        public Task<IReturn<IEnumerable<TEntity>>> _GetAllDeletedAsync<TOrder>(Expression<Func<TEntity, bool>>? filter = null, Expression<Func<TEntity, TOrder>>? order = null, bool Reserve = false, Range? TakeRange = null);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllDeletedAsync() => await _GetAllDeletedAsync<TEntity>();
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllDeletedAsync(Range TakeRange) => await _GetAllDeletedAsync<TEntity>(TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllDeletedAsync(bool Reserve) => await _GetAllDeletedAsync<TEntity>(Reserve: Reserve);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllDeletedAsync(bool Reserve, Range TakeRange) => await _GetAllDeletedAsync<TEntity>(Reserve: Reserve, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllDeletedAsync<TOrder>(Expression<Func<TEntity, TOrder>> order) => await _GetAllDeletedAsync<TOrder>(order: order);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllDeletedAsync<TOrder>(Expression<Func<TEntity, TOrder>> order, Range TakeRange) => await _GetAllDeletedAsync<TOrder>(order: order, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllDeletedAsync<TOrder>(Expression<Func<TEntity, TOrder>> order, bool Reserve) => await _GetAllDeletedAsync<TOrder>(order: order, Reserve: Reserve);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllDeletedAsync<TOrder>(Expression<Func<TEntity, TOrder>> order, bool Reserve, Range TakeRange) => await _GetAllDeletedAsync<TOrder>(order: order, Reserve: Reserve, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllDeletedAsync(Expression<Func<TEntity, bool>> filter) => await _GetAllDeletedAsync<TEntity>(filter: filter);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllDeletedAsync(Expression<Func<TEntity, bool>> filter, Range TakeRange) => await _GetAllDeletedAsync<TEntity>(filter: filter, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllDeletedAsync(Expression<Func<TEntity, bool>> filter, bool Reserve) => await _GetAllDeletedAsync<TEntity>(filter: filter, Reserve: Reserve);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllDeletedAsync(Expression<Func<TEntity, bool>> filter, bool Reserve, Range TakeRange) => await _GetAllDeletedAsync<TEntity>(filter: filter, Reserve: Reserve, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllDeletedAsync<TOrder>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TOrder>> order) => await _GetAllDeletedAsync<TOrder>(filter: filter, order: order);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllDeletedAsync<TOrder>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TOrder>> order, Range TakeRange) => await _GetAllDeletedAsync<TOrder>(filter: filter, order: order, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllDeletedAsync<TOrder>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TOrder>> order, bool Reserve) => await _GetAllDeletedAsync<TOrder>(filter: filter, order: order, Reserve: Reserve);
        public async Task<IReturn<IEnumerable<TEntity>>> GetAllDeletedAsync<TOrder>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TOrder>> order, bool Reserve, Range TakeRange) => await _GetAllDeletedAsync<TOrder>(filter: filter, order: order, Reserve: Reserve, TakeRange: TakeRange);

        public IReturn<TEntity> GetDeleted(Expression<Func<TEntity, bool>> filter);
        public Task<IReturn<TEntity>> GetDeletedAsync(Expression<Func<TEntity, bool>> filter);

        public IReturn<int> Count(Expression<Func<TEntity, bool>>? filter = null);
        public Task<IReturn<int>> CountAsync(Expression<Func<TEntity, bool>>? filter = null);

        public IReturn<bool> IsExist(Expression<Func<TEntity, bool>> filter);
        public Task<IReturn<bool>> IsExistAsync(Expression<Func<TEntity, bool>> filter);

        public IReturn<TEntity> Add(TEntity entity);
        public IReturn<IEnumerable<TEntity>> Add(IEnumerable<TEntity> entity);
        public Task<IReturn<TEntity>> AddAsync(TEntity entity);
        public Task<IReturn<IEnumerable<TEntity>>> AddAsync(IEnumerable<TEntity> entity);

        public IReturn<TEntity> Update(TEntity entity);
        public IReturn<IEnumerable<TEntity>> Update(IEnumerable<TEntity> entity);
        public Task<IReturn<TEntity>> UpdateAsync(TEntity entity);
        public Task<IReturn<IEnumerable<TEntity>>> UpdateAsync(IEnumerable<TEntity> entity);

        public IReturn<TEntity> Delete(TEntity entity);
        public IReturn<IEnumerable<TEntity>> Delete(IEnumerable<TEntity> entity);
        public Task<IReturn<TEntity>> DeleteAsync(TEntity entity);
        public Task<IReturn<IEnumerable<TEntity>>> DeleteAsync(IEnumerable<TEntity> entity);

        public IReturn<TEntity> Save(TEntity entity);
        public IReturn<IEnumerable<TEntity>> Save(IEnumerable<TEntity> entity);
        public Task<IReturn<TEntity>> SaveAsync(TEntity entity);
        public Task<IReturn<IEnumerable<TEntity>>> SaveAsync(IEnumerable<TEntity> entity);

        public IReturn<TNull> CheckIsNull<TNull>(TNull? result);
    }
}
