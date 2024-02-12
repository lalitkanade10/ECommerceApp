using ECommerce.Models.Models.Masters;
using ECommerce.Repository.Repositories.Master.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly IUnitMasterRepository _repository;

        public UnitController(IUnitMasterRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllUnit()
        {
            var result = await _repository.GetAllUnitAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUnitByID([FromRoute] Guid id)
        {
            var result = await _repository.GetUnitByIdAsync(id);
            if (result==null)
                return NotFound();
            return Ok(result);
        }
              

        [HttpPost("")]
        public async Task<IActionResult> AddUnit([FromBody] UnitMasterModels UnitModels)
        {
            var result = await _repository.AddUnitAsync(UnitModels);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUnit([FromBody] UnitMasterModels UnitModels, [FromRoute] Guid id)
        {
            var result = await _repository.UpdateUnitAsync(UnitModels, id);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUnit([FromRoute] Guid id)
        {
            var result = await _repository.DeleteUnitAsync(id);
            return Ok(result);
        }

        [HttpGet("name/{name}")]
        public async Task<IActionResult> GetUnitByName([FromRoute] string name)
        {
            var departments = await _repository.GetUnitByNameAsync(name);

            if (departments == null)
            {
                return NotFound();
            }

            return Ok(departments);
        }

    }
}
