using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using YazilimciPazari.Backend.Domain.Entities.Abstract;
using YazilimciPazari.Backend.Domain.Extensions;
using YazilimciPazari.Backend.Domain.Returns.Abstract;
using YazilimciPazari.Backend.Domain.Returns.Concrete;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Context.Base;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Abstract.Base;

namespace YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Base
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        internal readonly BaseContext context;
        public Repository(BaseContext context)
        {
            this.context = context;
        }

        public IReturn<TEntity> GetDeleted(Expression<Func<TEntity, bool>> filter)
        {
            var result = context.Set<TEntity>().IgnoreQueryFilters().AsNoTracking().FirstOrDefault(filter);
            return CheckIsNull(result);
        }

        public async Task<IReturn<TEntity>> GetDeletedAsync(Expression<Func<TEntity, bool>> filter)
        {
            var result = await context.Set<TEntity>().IgnoreQueryFilters().AsNoTracking().FirstOrDefaultAsync(filter);
            return CheckIsNull(result);
        }

        public IReturn<IEnumerable<TEntity>> _GetAllDeleted<TOrder>(Expression<Func<TEntity, bool>>? filter = null, Expression<Func<TEntity, TOrder>>? order = null, bool Reserve = false, Range? TakeRange = null)
        {
            IQueryable<TEntity> result = context.Set<TEntity>().IgnoreQueryFilters().AsNoTracking();
            if (filter != null) result = result.Where(filter);
            if (order != null) result = result.OrderBy(order);
            if (TakeRange != null) result = result.Take((Range)TakeRange);
            if (Reserve) result = result.Reverse();
            return new SuccessReturn<IEnumerable<TEntity>>(result, "Başarıyla Getirildi");
        }

        public async Task<IReturn<IEnumerable<TEntity>>> _GetAllDeletedAsync<TOrder>(Expression<Func<TEntity, bool>>? filter = null, Expression<Func<TEntity, TOrder>>? order = null, bool Reserve = false, Range? TakeRange = null)
        {
            //zoraki async
            IQueryable<TEntity> result = context.Set<TEntity>().IgnoreQueryFilters().AsNoTracking();
            if (filter != null) result = result.Where(filter);
            if (order != null) result = result.OrderBy(order);
            if (TakeRange != null) result = result.Take((Range)TakeRange);
            if (Reserve) result = result.Reverse();

            return await Task.FromResult(new SuccessReturn<IEnumerable<TEntity>>(result, "Başarıyla Getirildi"));
        }

        
        public IReturn<TEntity> Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            return Save(entity);
        }

        public IReturn<IEnumerable<TEntity>> Add(IEnumerable<TEntity> entity)
        {
            context.Set<TEntity>().AddRange(entity);
            return Save(entity);
        }

        public async Task<IReturn<TEntity>> AddAsync(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
            return await SaveAsync(entity);
        }

        public async Task<IReturn<IEnumerable<TEntity>>> AddAsync(IEnumerable<TEntity> entity)
        {
            await context.Set<TEntity>().AddRangeAsync(entity);
            return await SaveAsync(entity);
        }

        public IReturn<TNull> CheckIsNull<TNull>(TNull? result)
            => (result == null) ? new SuccessReturn<TNull>("Data is null") : new SuccessReturn<TNull>(result, "Data is not null");

        public IReturn<int> Count(Expression<Func<TEntity, bool>>? filter = null)
        {
            try
            {
                return new SuccessReturn<int>(filter == null ? context.Set<TEntity>().AsNoTracking().Count() : context.Set<TEntity>().AsNoTracking().Count(filter));
            }
            catch (Exception e)
            {
                return new ErrorReturn<int>(e);
            }
        }

        public async Task<IReturn<int>> CountAsync(Expression<Func<TEntity, bool>>? filter = null)
        {
            try
            {
                return new SuccessReturn<int>(filter == null ? await context.Set<TEntity>().AsNoTracking().CountAsync() : await context.Set<TEntity>().AsNoTracking().CountAsync(filter));
            }
            catch (Exception e)
            {
                return new ErrorReturn<int>(e);
            }
        }

        public IReturn<TEntity> Delete(TEntity entity)
        {
            try
            {
                entity.IsDeleted = true;
                context.Set<TEntity>().Update(entity);
                return Save(entity);
            }
            catch (Exception e)
            {
                return new ErrorReturn<TEntity>(e);
            }
        }

        public IReturn<IEnumerable<TEntity>> Delete(IEnumerable<TEntity> entity)
        {
            try
            {
                entity.ChangeAll(e => e.IsDeleted = true);
                context.Set<TEntity>().UpdateRange(entity);
                return Save(entity);
            }
            catch (Exception e)
            {
                return new ErrorReturn<IEnumerable<TEntity>>(e);
            }
        }

        public async Task<IReturn<TEntity>> DeleteAsync(TEntity entity)
        {
            try
            {
                entity.IsDeleted = true;
                context.Set<TEntity>().Update(entity);
                return await SaveAsync(entity);
            }
            catch (Exception e)
            {
                return new ErrorReturn<TEntity>(e);
            }
        }

        public async Task<IReturn<IEnumerable<TEntity>>> DeleteAsync(IEnumerable<TEntity> entity)
        {
            try
            {
                entity.ChangeAll(e => e.IsDeleted = true);
                context.Set<TEntity>().UpdateRange(entity);
                return await SaveAsync(entity);
            }
            catch (Exception e)
            {
                return new ErrorReturn<IEnumerable<TEntity>>(e);
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IReturn<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            var result = context.Set<TEntity>().AsNoTracking().FirstOrDefault(filter);
            return CheckIsNull(result);
        }

        public async Task<IReturn<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            var result = await context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(filter);
            return CheckIsNull(result);
        }

        public IReturn<bool> IsExist(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                return new SuccessReturn<bool>(context.Set<TEntity>().AsNoTracking().Any(filter));
            }
            catch (Exception e)
            {
                return new ErrorReturn<bool>(e);
            }
        }

        public async Task<IReturn<bool>> IsExistAsync(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                return new SuccessReturn<bool>(await context.Set<TEntity>().AsNoTracking().AnyAsync(filter));
            }
            catch (Exception e)
            {
                return new ErrorReturn<bool>(e);
            }
        }

        public IReturn<TEntity> Save(TEntity entity)
        {
            try
            {
                if (context.SaveChanges() > 0)
                {
                    return new SuccessReturn<TEntity>(entity);
                }
                return new ErrorReturn<TEntity>(entity);
            }
            catch (Exception e)
            {
                return new ErrorReturn<TEntity>(entity, e);
            }
        }

        public IReturn<IEnumerable<TEntity>> Save(IEnumerable<TEntity> entity)
        {
            try
            {
                if (context.SaveChanges() > 0)
                {
                    return new SuccessReturn<IEnumerable<TEntity>>(entity);
                }
                return new ErrorReturn<IEnumerable<TEntity>>(entity);
            }
            catch (Exception e)
            {
                return new ErrorReturn<IEnumerable<TEntity>>(entity, e);
            }
        }

        public async Task<IReturn<TEntity>> SaveAsync(TEntity entity)
        {
            try
            {
                if (await context.SaveChangesAsync() > 0)
                {
                    return new SuccessReturn<TEntity>(entity);
                }
                return new ErrorReturn<TEntity>(entity);
            }
            catch (Exception e)
            {
                return new ErrorReturn<TEntity>(entity, e);
            }
        }

        public async Task<IReturn<IEnumerable<TEntity>>> SaveAsync(IEnumerable<TEntity> entity)
        {
            try
            {
                if (await context.SaveChangesAsync() > 0)
                {
                    return new SuccessReturn<IEnumerable<TEntity>>(entity);
                }
                return new ErrorReturn<IEnumerable<TEntity>>(entity);
            }
            catch (Exception e)
            {
                return new ErrorReturn<IEnumerable<TEntity>>(entity, e);
            }
        }

        public IReturn<TEntity> Update(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
            return Save(entity);
        }

        public IReturn<IEnumerable<TEntity>> Update(IEnumerable<TEntity> entity)
        {
            context.Set<TEntity>().UpdateRange(entity);
            return Save(entity);
        }

        public async Task<IReturn<TEntity>> UpdateAsync(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
            return await SaveAsync(entity);
        }

        public async Task<IReturn<IEnumerable<TEntity>>> UpdateAsync(IEnumerable<TEntity> entity)
        {
            context.Set<TEntity>().UpdateRange(entity);
            return await SaveAsync(entity);
        }

        public IReturn<IEnumerable<TEntity>> _GetAll<TOrder>(Expression<Func<TEntity, bool>>? filter = null, Expression<Func<TEntity, TOrder>>? order = null, bool Reserve = false, Range? TakeRange = null)
        {
            // burada bir sorun var take ile çalışmada sorun var birde range de eklemede sorun var
            IQueryable<TEntity> result = context.Set<TEntity>().AsNoTracking();

            if (filter != null) result = result.Where(filter);
            if (order != null) result = result.OrderBy(order);
            if (Reserve) result = result.Reverse();
            if (TakeRange != null)
            {
                return new SuccessReturn<IEnumerable<TEntity>>(result.ToList().Take(TakeRange.Value), "Başarıyla Getirildi");
            }

            return new SuccessReturn<IEnumerable<TEntity>>(result.ToList(), "Başarıyla Getirildi");
        }

        public async Task<IReturn<IEnumerable<TEntity>>> _GetAllAsync<TOrder>(Expression<Func<TEntity, bool>>? filter = null, Expression<Func<TEntity, TOrder>>? order = null, bool Reserve = false, Range? TakeRange = null)
        {
            //zoraki async
            IQueryable<TEntity> result = context.Set<TEntity>().AsNoTracking();

            if (filter != null) result = result.Where(filter);
            if (order != null) result = result.OrderBy(order);
            if (Reserve) result = result.Reverse();
            if (TakeRange != null)
            {
                return new SuccessReturn<IEnumerable<TEntity>>(result.ToList().Take(TakeRange.Value), "Başarıyla Getirildi");
            }

            return new SuccessReturn<IEnumerable<TEntity>>(await result.ToListAsync(), "Başarıyla Getirildi");
        }


    }
}
