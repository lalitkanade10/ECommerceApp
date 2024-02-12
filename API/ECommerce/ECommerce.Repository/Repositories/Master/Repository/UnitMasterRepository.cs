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
    public class UnitMasterRepository:IUnitMasterRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public UnitMasterRepository(ApplicationDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<List<UnitMasterModels>> GetAllUnitAsync()
        {
            var unit = await _context.UnitMaster.
                Where(x => x.DeleteFlag != 1).ToListAsync();
            return _mapper.Map<List<UnitMasterModels>>(unit);
        }

        public async Task<UnitMasterModels> GetUnitByIdAsync(Guid UnitID)
        {
            var unit = await _context.UnitMaster.
                Where(x => x.DeleteFlag != 1 && x.UnitID == UnitID).FirstOrDefaultAsync();
            return _mapper.Map<UnitMasterModels>(unit);
        }
        public async Task<Guid> AddUnitAsync(UnitMasterModels unitMaster)
        {
            var unit = new UnitMaster
            {
               // UnitID = unitMaster.UnitID,
                UnitName = unitMaster.UnitName,
                UnitDescription= unitMaster.UnitDescription,

                ADate = unitMaster.ADate,
                MDate = unitMaster.MDate,
                DeleteFlag = unitMaster.DeleteFlag,
                UserID = unitMaster.UserID,
                OrgID = unitMaster.OrgID
            };

            _context.UnitMaster.Add(unit);
            await _context.SaveChangesAsync();

            return unit.UnitID;
        }

        public async Task<bool> UpdateUnitAsync(UnitMasterModels unitMaster, Guid UnitID)
        {
            try
            {
                var unit = new UnitMaster
                {
                    UnitID = UnitID,
                    UnitName = unitMaster.UnitName,
                    UnitDescription = unitMaster.UnitDescription,

                    ADate = unitMaster.ADate,
                    MDate = unitMaster.MDate,
                    DeleteFlag = unitMaster.DeleteFlag,
                    UserID = unitMaster.UserID,
                    OrgID = unitMaster.OrgID
                };
                _context.UnitMaster.Update(unit);
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

        public async Task<bool> DeleteUnitAsync(Guid UnitID)
        {
            var unit = _context.UnitMaster.Find(UnitID);
            if (unit != null)
            {
                unit.DeleteFlag = 1;
                _context.UnitMaster.Update(unit);
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

        public async Task<List<UnitMasterModels>> GetUnitByNameAsync(string name)
        {
            var unit = await _context.UnitMaster.
                Where(x => x.DeleteFlag != 1 && x.UnitName.StartsWith(name)).ToListAsync();
            return _mapper.Map<List<UnitMasterModels>>(unit);
        }
    }
}
