using AutoMapper;
using ECommerce.Data.Entiry;
using ECommerce.Data.Entiry.Masters;
using ECommerce.Models.Models.Masters;
using ECommerce.Repository.Repositories.Master.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ECommerce.Repository.Repositories.Master.Repository
{
    public class DepartmentMasterRepository: IDepartmentMasterRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public DepartmentMasterRepository(ApplicationDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
        public async Task<List<DepartmentMasterModels>> GetAllDepartmentAsync()
        {
            var department = await _context.DepartmentMaster.
                Where(x => x.DeleteFlag != 1).ToListAsync();
            return _mapper.Map<List<DepartmentMasterModels>>(department);
        }

        public async Task<DepartmentMasterModels> GetDepartmentByIdAsync(Guid DeptID)
        {         

            var result = await _context.DepartmentMaster.Where(x => x.DeleteFlag != 1 && x.DeptID == DeptID).Select(x => new DepartmentMasterModels
            {
                DeptID = x.DeptID,
                DepartmentName = x.DepartmentName,
                ADate = x.ADate,
                MDate = x.MDate,
                DeleteFlag = x.DeleteFlag,
                UserID = x.UserID,
                OrgID = x.OrgID

            }).FirstOrDefaultAsync();


            return result;
        }
        public async Task<Guid> AddDepartmentAsync(DepartmentMasterModels departmentMaster)
        {
            var department = new DepartmentMaster
            {
                //DeptID=departmentMaster.DeptID,
                DepartmentName=departmentMaster.DepartmentName,
                ADate=departmentMaster.ADate,
                MDate= departmentMaster.MDate,
                DeleteFlag = departmentMaster.DeleteFlag,
                UserID = departmentMaster.UserID,
                OrgID = departmentMaster.OrgID
            };

            _context.DepartmentMaster.Add(department);
            await _context.SaveChangesAsync();

            return department.DeptID;
        }

        public async Task<bool> UpdateDepartmentAsync(DepartmentMasterModels departmentMaster, Guid DeptID)
        {
            try
            {
                var department = new DepartmentMaster
                {
                    DeptID = DeptID,
                    DepartmentName = departmentMaster.DepartmentName,
                    ADate = departmentMaster.ADate,
                    MDate = departmentMaster.MDate,
                    DeleteFlag = departmentMaster.DeleteFlag,
                    UserID = departmentMaster.UserID,
                    OrgID = departmentMaster.OrgID
                };
                _context.DepartmentMaster.Update(department);
                if (await _context.SaveChangesAsync() >= 1)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteDepartmentAsync(Guid DeptID)
        {
            var department = _context.DepartmentMaster.Find(DeptID);
            if (department != null)
            {
                department.DeleteFlag = 1;
                _context.DepartmentMaster.Update(department);
                if (await _context.SaveChangesAsync() >= 1)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<DepartmentMasterModels>> GetAllDepartmentByNameAsync(string DeptName)
        {
            var result = await _context.DepartmentMaster.Where(x => x.DepartmentName.StartsWith(DeptName) && x.DeleteFlag != 1).ToListAsync();

            return _mapper.Map<List<DepartmentMasterModels>>(result);
        }
    }
}
