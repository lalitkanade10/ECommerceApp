using ECommerce.Models.Models.Masters;
using ECommerce.Repository.Repositories.Master.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentMasterRepository _repository;

        public DepartmentController(IDepartmentMasterRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllDepartment()
        {
            var result = await _repository.GetAllDepartmentAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartmentByID([FromRoute] Guid id)
        {
            var result = await _repository.GetDepartmentByIdAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddDepartment([FromBody] DepartmentMasterModels DepartmentModels)
        {
            var result = await _repository.AddDepartmentAsync(DepartmentModels);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDepartment([FromBody] DepartmentMasterModels DepartmentModels, [FromRoute] Guid id)
        {
            var result = await _repository.UpdateDepartmentAsync(DepartmentModels, id);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment([FromRoute] Guid id)
        {
            var result = await _repository.DeleteDepartmentAsync(id);
            return Ok(result);
        }

        [HttpGet("name/{name}")]
        public async Task<IActionResult> GetDepartmnetByName([FromRoute] string name)
        {
            var departments = await _repository.GetAllDepartmentByNameAsync(name);

            if (departments == null)
            {
                return NotFound();
            }

            return Ok(departments);
        }

    }
}
