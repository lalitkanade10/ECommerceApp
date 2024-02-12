using AutoMapper;
using ECommerce.Data.Entiry;
using ECommerce.Data.Entiry.Masters;
using ECommerce.Models.Models.Masters;
using ECommerce.Repository.Repositories.Master.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repository.Repositories.Master.Repository
{
    public class CategoryMasterRepository:ICategoryMasterRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public CategoryMasterRepository(ApplicationDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
        public async Task<List<CategoryMasterModels>> GetAllCategoryAsync()
        {
            var result = await (from categoryMaster in _context.CategoryMaster
                                  join departmentMaster in _context.DepartmentMaster on categoryMaster.DeptID equals departmentMaster.DeptID
                                  where categoryMaster.DeleteFlag == 0
                                  select new CategoryMasterModels()
                                  {
                                      CategoryID = categoryMaster.CategoryID,
                                      CategoryName = categoryMaster.CategoryName,
                                      DeptID = categoryMaster.DeptID,
                                      DepartmentName=departmentMaster.DepartmentName,

                                      ADate = categoryMaster.ADate,
                                      MDate = categoryMaster.MDate,
                                      DeleteFlag = categoryMaster.DeleteFlag,
                                      UserID = categoryMaster.UserID,
                                      OrgID = categoryMaster.OrgID
                                  }
                                 ).ToListAsync();
            return _mapper.Map<List<CategoryMasterModels>>(result);
        }

        public async Task<CategoryMasterModels> GetCategoryByIdAsync(Guid CategoryID)
        {
            var result = await (from categoryMaster in _context.CategoryMaster
                                join departmentMaster in _context.DepartmentMaster on categoryMaster.DeptID equals departmentMaster.DeptID
                                where categoryMaster.DeleteFlag == 0 && categoryMaster.CategoryID == CategoryID
                                select new CategoryMasterModels()
                                {
                                    CategoryID = categoryMaster.CategoryID,
                                    CategoryName = categoryMaster.CategoryName,
                                    DeptID = categoryMaster.DeptID,
                                    DepartmentName = departmentMaster.DepartmentName,

                                    ADate = categoryMaster.ADate,
                                    MDate = categoryMaster.MDate,
                                    DeleteFlag = categoryMaster.DeleteFlag,
                                    UserID = categoryMaster.UserID,
                                    OrgID = categoryMaster.OrgID
                                }).FirstOrDefaultAsync();
            return _mapper.Map<CategoryMasterModels>(result);
        }

        public async Task<List<CategoryMasterModels>> GetCategoryByDepartmentIdAsync(Guid DeptID)
        {
            var result = await (from categoryMaster in _context.CategoryMaster
                                join departmentMaster in _context.DepartmentMaster on categoryMaster.DeptID equals departmentMaster.DeptID
                                where categoryMaster.DeleteFlag == 0 && departmentMaster.DeptID == DeptID
                                select new CategoryMasterModels()
                                {
                                    CategoryID = categoryMaster.CategoryID,
                                    CategoryName = categoryMaster.CategoryName,
                                    DeptID = categoryMaster.DeptID,
                                    DepartmentName = departmentMaster.DepartmentName,

                                    ADate = categoryMaster.ADate,
                                    MDate = categoryMaster.MDate,
                                    DeleteFlag = categoryMaster.DeleteFlag,
                                    UserID = categoryMaster.UserID,
                                    OrgID = categoryMaster.OrgID
                                }).ToListAsync();
            return _mapper.Map<List<CategoryMasterModels>>(result);
        }

        public async Task<Guid> AddCategoryAsync(CategoryMasterModels categoryMaster)
        {
            var category = new CategoryMaster
            {
                //CategoryID = categoryMaster.CategoryID,
                CategoryName = categoryMaster.CategoryName,
                DeptID=categoryMaster.DeptID,

                ADate = categoryMaster.ADate,
                MDate = categoryMaster.MDate,
                DeleteFlag = categoryMaster.DeleteFlag,
                UserID = categoryMaster.UserID,
                OrgID = categoryMaster.OrgID
            };

            _context.CategoryMaster.Add(category);
            await _context.SaveChangesAsync();

            return category.CategoryID;
        }

        public async Task<bool> UpdateCategoryAsync(CategoryMasterModels categoryMaster, Guid DeptID)
        {
            try
            {
                var category = new CategoryMaster
                {
                    CategoryID = categoryMaster.CategoryID,
                    CategoryName = categoryMaster.CategoryName,
                    DeptID = categoryMaster.DeptID,

                    ADate = categoryMaster.ADate,
                    MDate = categoryMaster.MDate,
                    DeleteFlag = categoryMaster.DeleteFlag,
                    UserID = categoryMaster.UserID,
                    OrgID = categoryMaster.OrgID
                };
                _context.CategoryMaster.Update(category);
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

        public async Task<bool> DeleteCategroyAsync(Guid CategoryID)
        {
            var category = _context.CategoryMaster.Find(CategoryID);
            if (category != null)
            {
                category.DeleteFlag = 1;
                _context.CategoryMaster.Update(category);
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

        public async Task<List<CategoryMasterModels>> GetCategoryByNameAsync(string name)
        {
            var result = await (from categoryMaster in _context.CategoryMaster
                                join departmentMaster in _context.DepartmentMaster on categoryMaster.DeptID equals departmentMaster.DeptID
                                where categoryMaster.DeleteFlag == 0 && categoryMaster.CategoryName.StartsWith(name)
                                select new CategoryMasterModels()
                                {
                                    CategoryID = categoryMaster.CategoryID,
                                    CategoryName = categoryMaster.CategoryName,
                                    DeptID = categoryMaster.DeptID,
                                    DepartmentName = departmentMaster.DepartmentName,

                                    ADate = categoryMaster.ADate,
                                    MDate = categoryMaster.MDate,
                                    DeleteFlag = categoryMaster.DeleteFlag,
                                    UserID = categoryMaster.UserID,
                                    OrgID = categoryMaster.OrgID
                                }).ToListAsync();
            return _mapper.Map<List<CategoryMasterModels>>(result);
        }
    }
}
