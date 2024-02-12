using ECommerce.Models.Models.Masters;
using ECommerce.Repository.Repositories.Master.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryMasterRepository _repository;

        public CategoryController(ICategoryMasterRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllCategory()
        {
            var result = await _repository.GetAllCategoryAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryByID([FromRoute] Guid id)
        {
            var result = await _repository.GetCategoryByIdAsync(id);
            if (result==null)
                return NotFound();
            return Ok(result);
        }


        [HttpGet("dept/{id}")]
        public async Task<IActionResult> GetCategoryByDeptID([FromRoute] Guid id)
        {
            var result = await _repository.GetCategoryByDepartmentIdAsync(id);
            if (result.Count == 0)
                return NotFound();
            return Ok(result);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddDepartment([FromBody] CategoryMasterModels CategoryModels)
        {
            var result = await _repository.AddCategoryAsync(CategoryModels);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory([FromBody] CategoryMasterModels CategoryModels, [FromRoute] Guid id)
        {
            var result = await _repository.UpdateCategoryAsync(CategoryModels, id);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment([FromRoute] Guid id)
        {
            var result = await _repository.DeleteCategroyAsync(id);
            return Ok(result);
        }

        [HttpGet("name/{name}")]
        public async Task<IActionResult> GetCategoryByName([FromRoute] string name)
        {
            var departments = await _repository.GetCategoryByNameAsync(name);

            if (departments == null)
            {
                return NotFound();
            }

            return Ok(departments);
        }

    }
}
