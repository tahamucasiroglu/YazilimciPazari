using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YazilimciPazari.Backend.Domain.DTOs.Abstract;
using YazilimciPazari.Backend.Domain.Returns.Concrete;
using YazilimciPazari.Backend.Domain.Returns.ConstantReturn;
using YazilimciPazari.Backend.Presentation.API.Attributes;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract.Base;

namespace YazilimciPazari.Backend.Presentation.API.Controllers.Base
{
    abstract public class Controller : ControllerBase
    {
        internal readonly IService service;
        public Controller(IService service)
        {
            this.service = service;
        }
    }
    abstract public class Controller<TGet> : Controller, IController
        where TGet : class, IGetDTO
    {
        internal new readonly IService<TGet> service;
        public Controller(IService<TGet> service) : base(service)
        {
            this.service = service;
        }
        [HttpGet("[action]")]
        [ServiceFilter(typeof(LogConnectionAttribute))]
        public IActionResult GetAll()
        {
            return new OkObjectResult(ModelState.IsValid ? service.GetAll() : new NoValidDataError());
        }
        [HttpGet("[action]Async")]
        [ServiceFilter(typeof(LogConnectionAttribute))]
        public async Task<IActionResult> GetAllAsync()
        {
            return new OkObjectResult(ModelState.IsValid ? await service.GetAllAsync() : new NoValidDataError());
        }
        [HttpGet("[action]")]
        [ServiceFilter(typeof(LogConnectionAttribute))]
        public IActionResult GetById(Guid id)
        {
            return new OkObjectResult(ModelState.IsValid ? service.GetById(id) : new NoValidDataError());
        }
        [HttpGet("[action]Async")]
        [ServiceFilter(typeof(LogConnectionAttribute))]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            return new OkObjectResult(ModelState.IsValid ? await service.GetByIdAsync(id) : new NoValidDataError());
        }
    }
    abstract public class Controller<TGet, TAdd> : Controller<TGet>, IController<TAdd>
        where TGet : class, IGetDTO 
        where TAdd : class, IAddDTO 
    {
        internal new readonly IService<TGet, TAdd> service;
        public Controller(IService<TGet, TAdd> service) : base(service)
        {
            this.service = service;
        }
        [HttpPost("[action]")]
        [ServiceFilter(typeof(LogConnectionAttribute))]
        public IActionResult Add([FromBody] TAdd survey)
        {
            return new OkObjectResult(ModelState.IsValid ? service.Add(survey) : new NoValidDataError());
        }
        [HttpPost("[action]Async")]
        [ServiceFilter(typeof(LogConnectionAttribute))]
        public async Task<IActionResult> AddAsync([FromBody] TAdd survey)
        {
            return new OkObjectResult(ModelState.IsValid ? await service.AddAsync(survey) : new NoValidDataError());
        }
    }
    abstract public class Controller<TGet, TAdd, TUpdate> : Controller<TGet, TAdd>, IController<TAdd, TUpdate>
        where TGet : class, IGetDTO 
        where TAdd : class, IAddDTO 
        where TUpdate : class, IUpdateDTO 
    {
        internal new readonly IService<TGet, TAdd, TUpdate> service;
        public Controller(IService<TGet, TAdd, TUpdate> service) : base(service)
        {
            this.service = service;
        }
        [HttpPut("[action]")]
        [ServiceFilter(typeof(LogConnectionAttribute))]
        public IActionResult Update([FromBody] TUpdate survey)
        {
            return new OkObjectResult(ModelState.IsValid ? service.Update(survey) : new NoValidDataError());
        }

        [HttpPut("[action]Async")]
        [ServiceFilter(typeof(LogConnectionAttribute))]
        public async Task<IActionResult> UpdateAsync([FromBody] TUpdate survey)
        {
            return new OkObjectResult(ModelState.IsValid ? await service.UpdateAsync(survey) : new NoValidDataError());
        }
    }
    abstract public class Controller<TGet, TAdd, TUpdate, TDelete> : Controller<TGet, TAdd, TUpdate>, IController<TAdd, TUpdate, TDelete>
        where TGet : class, IGetDTO 
        where TAdd : class, IAddDTO 
        where TUpdate : class, IUpdateDTO 
        where TDelete : class, IDeleteDTO 
    {
        public Controller(IService<TGet, TAdd, TUpdate> service) : base(service) { }

        [HttpDelete("[action]")]
        [ServiceFilter(typeof(LogConnectionAttribute))]
        public IActionResult Delete([FromBody] TDelete survey)
        {
            return new OkObjectResult(ModelState.IsValid ? service.Delete(survey.Id) : new NoValidDataError());
        }

        [HttpDelete("[action]Async")]
        [ServiceFilter(typeof(LogConnectionAttribute))]
        public async Task<IActionResult> DeleteAsync([FromBody] TDelete survey)
        {
            return new OkObjectResult(ModelState.IsValid ? await service.DeleteAsync(survey.Id) : new NoValidDataError());
        }
    }
}
