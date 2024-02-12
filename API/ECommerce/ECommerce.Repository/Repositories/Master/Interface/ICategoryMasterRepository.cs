using ECommerce.Models.Models.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repository.Repositories.Master.Interface
{
    public interface ICategoryMasterRepository
    {
        Task<List<CategoryMasterModels>> GetAllCategoryAsync();
        Task<CategoryMasterModels> GetCategoryByIdAsync(Guid CategoryID);
        Task<List<CategoryMasterModels>> GetCategoryByDepartmentIdAsync(Guid DeptID);
        Task<Guid> AddCategoryAsync(CategoryMasterModels categoryMaster);
        Task<bool> UpdateCategoryAsync(CategoryMasterModels categoryMaster, Guid DeptID);
        Task<bool> DeleteCategroyAsync(Guid CategoryID);
        Task<List<CategoryMasterModels>> GetCategoryByNameAsync(string name);
    }
}
