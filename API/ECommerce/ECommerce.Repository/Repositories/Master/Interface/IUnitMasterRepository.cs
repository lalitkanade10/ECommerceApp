using ECommerce.Models.Models.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repository.Repositories.Master.Interface
{
    public interface IUnitMasterRepository
    {
        Task<List<UnitMasterModels>> GetAllUnitAsync();
        Task<UnitMasterModels> GetUnitByIdAsync(Guid UnitID);
        Task<Guid> AddUnitAsync(UnitMasterModels unitMaster);
        Task<bool> UpdateUnitAsync(UnitMasterModels unitMaster, Guid UnitID);
        Task<bool> DeleteUnitAsync(Guid UnitID);
        Task<List<UnitMasterModels>> GetUnitByNameAsync(string name);
    }
}
