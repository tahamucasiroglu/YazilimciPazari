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
    public interface IRepository<T> : IDisposable
        where T : class, IEntity, new()
    {
        public IReturn<T> Get(Expression<Func<T, bool>> filter);
        public Task<IReturn<T>> GetAsync(Expression<Func<T, bool>> filter);

        public IReturn<IEnumerable<T>> _GetAll<TOrder>(Expression<Func<T, bool>>? filter = null, Expression<Func<T, TOrder>>? order = null, bool Reserve = false, Range? TakeRange = null);
        public IReturn<IEnumerable<T>> GetAll() => _GetAll<T>();
        public IReturn<IEnumerable<T>> GetAll(Range TakeRange) => _GetAll<T>(TakeRange: TakeRange);
        public IReturn<IEnumerable<T>> GetAll(bool Reserve) => _GetAll<T>(Reserve: Reserve);
        public IReturn<IEnumerable<T>> GetAll(bool Reserve, Range TakeRange) => _GetAll<T>(Reserve: Reserve, TakeRange: TakeRange);
        public IReturn<IEnumerable<T>> GetAll<TOrder>(Expression<Func<T, TOrder>> order) => _GetAll<TOrder>(order: order);
        public IReturn<IEnumerable<T>> GetAll<TOrder>(Expression<Func<T, TOrder>> order, Range TakeRange) => _GetAll<TOrder>(order: order, TakeRange: TakeRange);
        public IReturn<IEnumerable<T>> GetAll<TOrder>(Expression<Func<T, TOrder>> order, bool Reserve) => _GetAll<TOrder>(order: order, Reserve: Reserve);
        public IReturn<IEnumerable<T>> GetAll<TOrder>(Expression<Func<T, TOrder>> order, bool Reserve, Range TakeRange) => _GetAll<TOrder>(order: order, Reserve: Reserve, TakeRange: TakeRange);
        public IReturn<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter) => _GetAll<T>(filter: filter);
        public IReturn<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter, Range TakeRange) => _GetAll<T>(filter: filter, TakeRange: TakeRange);
        public IReturn<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter, bool Reserve) => _GetAll<T>(filter: filter, Reserve: Reserve);
        public IReturn<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter, bool Reserve, Range TakeRange) => _GetAll<T>(filter: filter, Reserve: Reserve, TakeRange: TakeRange);
        public IReturn<IEnumerable<T>> GetAll<TOrder>(Expression<Func<T, bool>> filter, Expression<Func<T, TOrder>> order) => _GetAll<TOrder>(filter: filter, order: order);
        public IReturn<IEnumerable<T>> GetAll<TOrder>(Expression<Func<T, bool>> filter, Expression<Func<T, TOrder>> order, Range TakeRange) => _GetAll<TOrder>(filter: filter, order: order, TakeRange: TakeRange);
        public IReturn<IEnumerable<T>> GetAll<TOrder>(Expression<Func<T, bool>> filter, Expression<Func<T, TOrder>> order, bool Reserve) => _GetAll<TOrder>(filter: filter, order: order, Reserve: Reserve);
        public IReturn<IEnumerable<T>> GetAll<TOrder>(Expression<Func<T, bool>> filter, Expression<Func<T, TOrder>> order, bool Reserve, Range TakeRange) => _GetAll<TOrder>(filter: filter, order: order, Reserve: Reserve, TakeRange: TakeRange);




        public Task<IReturn<IEnumerable<T>>> _GetAllAsync<TOrder>(Expression<Func<T, bool>>? filter = null, Expression<Func<T, TOrder>>? order = null, bool Reserve = false, Range? TakeRange = null);
        public async Task<IReturn<IEnumerable<T>>> GetAllAsync() => await _GetAllAsync<T>();
        public async Task<IReturn<IEnumerable<T>>> GetAllAsync(Range TakeRange) => await _GetAllAsync<T>(TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<T>>> GetAllAsync(bool Reserve) => await _GetAllAsync<T>(Reserve: Reserve);
        public async Task<IReturn<IEnumerable<T>>> GetAllAsync(bool Reserve, Range TakeRange) => await _GetAllAsync<T>(Reserve: Reserve, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<T>>> GetAllAsync<TOrder>(Expression<Func<T, TOrder>> order) => await _GetAllAsync<TOrder>(order: order);
        public async Task<IReturn<IEnumerable<T>>> GetAllAsync<TOrder>(Expression<Func<T, TOrder>> order, Range TakeRange) => await _GetAllAsync<TOrder>(order: order, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<T>>> GetAllAsync<TOrder>(Expression<Func<T, TOrder>> order, bool Reserve) => await _GetAllAsync<TOrder>(order: order, Reserve: Reserve);
        public async Task<IReturn<IEnumerable<T>>> GetAllAsync<TOrder>(Expression<Func<T, TOrder>> order, bool Reserve, Range TakeRange) => await _GetAllAsync<TOrder>(order: order, Reserve: Reserve, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<T>>> GetAllAsync(Expression<Func<T, bool>> filter) => await _GetAllAsync<T>(filter: filter);
        public async Task<IReturn<IEnumerable<T>>> GetAllAsync(Expression<Func<T, bool>> filter, Range TakeRange) => await _GetAllAsync<T>(filter: filter, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<T>>> GetAllAsync(Expression<Func<T, bool>> filter, bool Reserve) => await _GetAllAsync<T>(filter: filter, Reserve: Reserve);
        public async Task<IReturn<IEnumerable<T>>> GetAllAsync(Expression<Func<T, bool>> filter, bool Reserve, Range TakeRange) => await _GetAllAsync<T>(filter: filter, Reserve: Reserve, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<T>>> GetAllAsync<TOrder>(Expression<Func<T, bool>> filter, Expression<Func<T, TOrder>> order) => await _GetAllAsync<TOrder>(filter: filter, order: order);
        public async Task<IReturn<IEnumerable<T>>> GetAllAsync<TOrder>(Expression<Func<T, bool>> filter, Expression<Func<T, TOrder>> order, Range TakeRange) => await _GetAllAsync<TOrder>(filter: filter, order: order, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<T>>> GetAllAsync<TOrder>(Expression<Func<T, bool>> filter, Expression<Func<T, TOrder>> order, bool Reserve) => await _GetAllAsync<TOrder>(filter: filter, order: order, Reserve: Reserve);
        public async Task<IReturn<IEnumerable<T>>> GetAllAsync<TOrder>(Expression<Func<T, bool>> filter, Expression<Func<T, TOrder>> order, bool Reserve, Range TakeRange) => await _GetAllAsync<TOrder>(filter: filter, order: order, Reserve: Reserve, TakeRange: TakeRange);

        public IReturn<IEnumerable<T>> _GetAllDeleted<TOrder>(Expression<Func<T, bool>>? filter = null, Expression<Func<T, TOrder>>? order = null, bool Reserve = false, Range? TakeRange = null);
        public IReturn<IEnumerable<T>> GetAllDeleted() => _GetAllDeleted<T>();
        public IReturn<IEnumerable<T>> GetAllDeleted(Range TakeRange) => _GetAllDeleted<T>(TakeRange: TakeRange);
        public IReturn<IEnumerable<T>> GetAllDeleted(bool Reserve) => _GetAllDeleted<T>(Reserve: Reserve);
        public IReturn<IEnumerable<T>> GetAllDeleted(bool Reserve, Range TakeRange) => _GetAllDeleted<T>(Reserve: Reserve, TakeRange: TakeRange);
        public IReturn<IEnumerable<T>> GetAllDeleted<TOrder>(Expression<Func<T, TOrder>> order) => _GetAllDeleted<TOrder>(order: order);
        public IReturn<IEnumerable<T>> GetAllDeleted<TOrder>(Expression<Func<T, TOrder>> order, Range TakeRange) => _GetAllDeleted<TOrder>(order: order, TakeRange: TakeRange);
        public IReturn<IEnumerable<T>> GetAllDeleted<TOrder>(Expression<Func<T, TOrder>> order, bool Reserve) => _GetAllDeleted<TOrder>(order: order, Reserve: Reserve);
        public IReturn<IEnumerable<T>> GetAllDeleted<TOrder>(Expression<Func<T, TOrder>> order, bool Reserve, Range TakeRange) => _GetAllDeleted<TOrder>(order: order, Reserve: Reserve, TakeRange: TakeRange);
        public IReturn<IEnumerable<T>> GetAllDeleted(Expression<Func<T, bool>> filter) => _GetAllDeleted<T>(filter: filter);
        public IReturn<IEnumerable<T>> GetAllDeleted(Expression<Func<T, bool>> filter, Range TakeRange) => _GetAllDeleted<T>(filter: filter, TakeRange: TakeRange);
        public IReturn<IEnumerable<T>> GetAllDeleted(Expression<Func<T, bool>> filter, bool Reserve) => _GetAllDeleted<T>(filter: filter, Reserve: Reserve);
        public IReturn<IEnumerable<T>> GetAllDeleted(Expression<Func<T, bool>> filter, bool Reserve, Range TakeRange) => _GetAllDeleted<T>(filter: filter, Reserve: Reserve, TakeRange: TakeRange);
        public IReturn<IEnumerable<T>> GetAllDeleted<TOrder>(Expression<Func<T, bool>> filter, Expression<Func<T, TOrder>> order) => _GetAllDeleted<TOrder>(filter: filter, order: order);
        public IReturn<IEnumerable<T>> GetAllDeleted<TOrder>(Expression<Func<T, bool>> filter, Expression<Func<T, TOrder>> order, Range TakeRange) => _GetAllDeleted<TOrder>(filter: filter, order: order, TakeRange: TakeRange);
        public IReturn<IEnumerable<T>> GetAllDeleted<TOrder>(Expression<Func<T, bool>> filter, Expression<Func<T, TOrder>> order, bool Reserve) => _GetAllDeleted<TOrder>(filter: filter, order: order, Reserve: Reserve);
        public IReturn<IEnumerable<T>> GetAllDeleted<TOrder>(Expression<Func<T, bool>> filter, Expression<Func<T, TOrder>> order, bool Reserve, Range TakeRange) => _GetAllDeleted<TOrder>(filter: filter, order: order, Reserve: Reserve, TakeRange: TakeRange);


        public Task<IReturn<IEnumerable<T>>> _GetAllDeletedAsync<TOrder>(Expression<Func<T, bool>>? filter = null, Expression<Func<T, TOrder>>? order = null, bool Reserve = false, Range? TakeRange = null);
        public async Task<IReturn<IEnumerable<T>>> GetAllDeletedAsync() => await _GetAllDeletedAsync<T>();
        public async Task<IReturn<IEnumerable<T>>> GetAllDeletedAsync(Range TakeRange) => await _GetAllDeletedAsync<T>(TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<T>>> GetAllDeletedAsync(bool Reserve) => await _GetAllDeletedAsync<T>(Reserve: Reserve);
        public async Task<IReturn<IEnumerable<T>>> GetAllDeletedAsync(bool Reserve, Range TakeRange) => await _GetAllDeletedAsync<T>(Reserve: Reserve, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<T>>> GetAllDeletedAsync<TOrder>(Expression<Func<T, TOrder>> order) => await _GetAllDeletedAsync<TOrder>(order: order);
        public async Task<IReturn<IEnumerable<T>>> GetAllDeletedAsync<TOrder>(Expression<Func<T, TOrder>> order, Range TakeRange) => await _GetAllDeletedAsync<TOrder>(order: order, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<T>>> GetAllDeletedAsync<TOrder>(Expression<Func<T, TOrder>> order, bool Reserve) => await _GetAllDeletedAsync<TOrder>(order: order, Reserve: Reserve);
        public async Task<IReturn<IEnumerable<T>>> GetAllDeletedAsync<TOrder>(Expression<Func<T, TOrder>> order, bool Reserve, Range TakeRange) => await _GetAllDeletedAsync<TOrder>(order: order, Reserve: Reserve, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<T>>> GetAllDeletedAsync(Expression<Func<T, bool>> filter) => await _GetAllDeletedAsync<T>(filter: filter);
        public async Task<IReturn<IEnumerable<T>>> GetAllDeletedAsync(Expression<Func<T, bool>> filter, Range TakeRange) => await _GetAllDeletedAsync<T>(filter: filter, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<T>>> GetAllDeletedAsync(Expression<Func<T, bool>> filter, bool Reserve) => await _GetAllDeletedAsync<T>(filter: filter, Reserve: Reserve);
        public async Task<IReturn<IEnumerable<T>>> GetAllDeletedAsync(Expression<Func<T, bool>> filter, bool Reserve, Range TakeRange) => await _GetAllDeletedAsync<T>(filter: filter, Reserve: Reserve, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<T>>> GetAllDeletedAsync<TOrder>(Expression<Func<T, bool>> filter, Expression<Func<T, TOrder>> order) => await _GetAllDeletedAsync<TOrder>(filter: filter, order: order);
        public async Task<IReturn<IEnumerable<T>>> GetAllDeletedAsync<TOrder>(Expression<Func<T, bool>> filter, Expression<Func<T, TOrder>> order, Range TakeRange) => await _GetAllDeletedAsync<TOrder>(filter: filter, order: order, TakeRange: TakeRange);
        public async Task<IReturn<IEnumerable<T>>> GetAllDeletedAsync<TOrder>(Expression<Func<T, bool>> filter, Expression<Func<T, TOrder>> order, bool Reserve) => await _GetAllDeletedAsync<TOrder>(filter: filter, order: order, Reserve: Reserve);
        public async Task<IReturn<IEnumerable<T>>> GetAllDeletedAsync<TOrder>(Expression<Func<T, bool>> filter, Expression<Func<T, TOrder>> order, bool Reserve, Range TakeRange) => await _GetAllDeletedAsync<TOrder>(filter: filter, order: order, Reserve: Reserve, TakeRange: TakeRange);

        public IReturn<T> GetDeleted(Expression<Func<T, bool>> filter);
        public Task<IReturn<T>> GetDeletedAsync(Expression<Func<T, bool>> filter);

        public IReturn<int> Count(Expression<Func<T, bool>>? filter = null);
        public Task<IReturn<int>> CountAsync(Expression<Func<T, bool>>? filter = null);

        public IReturn<bool> IsExist(Expression<Func<T, bool>> filter);
        public Task<IReturn<bool>> IsExistAsync(Expression<Func<T, bool>> filter);

        public IReturn<T> Add(T entity);
        public IReturn<IEnumerable<T>> Add(IEnumerable<T> entity);
        public Task<IReturn<T>> AddAsync(T entity);
        public Task<IReturn<IEnumerable<T>>> AddAsync(IEnumerable<T> entity);

        public IReturn<T> Update(T entity);
        public IReturn<IEnumerable<T>> Update(IEnumerable<T> entity);
        public Task<IReturn<T>> UpdateAsync(T entity);
        public Task<IReturn<IEnumerable<T>>> UpdateAsync(IEnumerable<T> entity);

        public IReturn<T> Delete(T entity);
        public IReturn<IEnumerable<T>> Delete(IEnumerable<T> entity);
        public Task<IReturn<T>> DeleteAsync(T entity);
        public Task<IReturn<IEnumerable<T>>> DeleteAsync(IEnumerable<T> entity);

        public IReturn<T> Save(T entity);
        public IReturn<IEnumerable<T>> Save(IEnumerable<T> entity);
        public Task<IReturn<T>> SaveAsync(T entity);
        public Task<IReturn<IEnumerable<T>>> SaveAsync(IEnumerable<T> entity);

        public IReturn<TNull> CheckIsNull<TNull>(TNull? result);
    }
}
