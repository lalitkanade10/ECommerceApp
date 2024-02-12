using ECommerce.Models.Models.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repository.Repositories.Master.Interface
{
    public interface IDepartmentMasterRepository
    {
        Task<List<DepartmentMasterModels>> GetAllDepartmentAsync();
        Task<DepartmentMasterModels> GetDepartmentByIdAsync(Guid DeptID);
        Task<Guid> AddDepartmentAsync(DepartmentMasterModels departmentMaster);
        Task<bool> UpdateDepartmentAsync(DepartmentMasterModels departmentMaster, Guid DeptID);
        Task<bool> DeleteDepartmentAsync(Guid DeptID);
        Task<List<DepartmentMasterModels>> GetAllDepartmentByNameAsync(string DeptName);
    }
}
