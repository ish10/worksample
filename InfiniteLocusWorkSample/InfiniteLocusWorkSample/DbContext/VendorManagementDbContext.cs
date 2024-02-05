using DataAcess.Data;
using Datamodel.Models;
using InfiniteLocusWorkSample.DbContext.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InfiniteLocusWorkSample.DbContext
{
    public class VendorManagementDbContext : IVendorManagementDbContext
    {
        private readonly ApplicationDbcontext _dbcontext;

        public VendorManagementDbContext(ApplicationDbcontext dbcontext) 
        {
            _dbcontext = dbcontext;
        }
        public async Task<bool> DeleteVendor(int id)
        {
            try 
            {
               var itemToRemove= await _dbcontext.Vendors.FirstOrDefaultAsync(x => x.Id == id);
                if (itemToRemove != null)
                {
                    _dbcontext.Vendors.Remove(itemToRemove);
                    var result = await _dbcontext.SaveChangesAsync();
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else 
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<VendorDetail> GetVendor(int id)
        {
            try
            {
                var item = await _dbcontext.Vendors.FirstOrDefaultAsync(x => x.Id == id);
                return item;


            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<List<VendorDetail>> GetVendors()
        {
            try
            {
                var items = await _dbcontext.Vendors.ToListAsync();
                return items;


            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<bool> SaveVendorDetail(VendorDetail vendorDetail)
        {
            try
            {
                var items = await _dbcontext.AddAsync(vendorDetail);

               var result= await _dbcontext.SaveChangesAsync();
                if (result > 0)
                {
                    return true;

                }
                else
                {
                    return false;
                }


            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<bool> UpdateVendorDetail(VendorDetail vendorDetail)
        {
              try
            {
                var ItemtobeUpdated = await _dbcontext.Vendors.FirstOrDefaultAsync(x => x.Id == vendorDetail.Id);
                if (ItemtobeUpdated != null)
                {

                    ItemtobeUpdated.PrimaryEmailAddress = vendorDetail.PrimaryEmailAddress;
                    ItemtobeUpdated.DisplayName = vendorDetail.DisplayName;
                    ItemtobeUpdated.FamilyName = vendorDetail.FamilyName;
                    var result = await _dbcontext.SaveChangesAsync();
                    if (result > 0)
                    {
                        return true;

                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
              


            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
