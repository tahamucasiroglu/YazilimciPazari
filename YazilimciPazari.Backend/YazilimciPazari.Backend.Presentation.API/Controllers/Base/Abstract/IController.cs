using Microsoft.AspNetCore.Mvc;
using YazilimciPazari.Backend.Domain.DTOs.Abstract;

namespace YazilimciPazari.Backend.Presentation.API.Controllers.Base.Abstract
{
    public interface IController
    {
        public IActionResult GetAll();
        public Task<IActionResult> GetAllAsync();
        public IActionResult GetById(Guid id);
        public Task<IActionResult> GetByIdAsync(Guid id);
    }
    public interface IController<TAdd> : IController
        where TAdd : class, IAddDTO, new()
    {
        public IActionResult Add([FromBody] TAdd survey);
        public Task<IActionResult> AddAsync([FromBody] TAdd survey);
    }
    public interface IController<TAdd, TUpdate> : IController<TAdd>
        where TAdd : class, IAddDTO, new()
        where TUpdate : class, IUpdateDTO, new()
    {
        public IActionResult Update([FromBody] TUpdate survey);
        public Task<IActionResult> UpdateAsync([FromBody] TUpdate survey);
    }
    public interface IController<TAdd, TUpdate, TDelete> : IController<TAdd, TUpdate>
        where TAdd : class, IAddDTO, new()
        where TUpdate : class, IUpdateDTO, new()
        where TDelete : class, IDeleteDTO, new()
    {
        public IActionResult Delete([FromBody] TDelete survey);
        public Task<IActionResult> DeleteAsync([FromBody] TDelete survey);
    }
}
