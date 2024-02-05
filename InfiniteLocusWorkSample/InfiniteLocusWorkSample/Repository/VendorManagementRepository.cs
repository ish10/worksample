using Datamodel.Models;
using InfiniteLocusWorkSample.DbContext.Interfaces;
using InfiniteLocusWorkSample.Model.ApiResponse;
using InfiniteLocusWorkSample.Repository.Interfaces;

namespace InfiniteLocusWorkSample.Repository
{
    public class VendorManagementRepository : IVendorManagementRepository
    {
        private readonly IVendorManagementDbContext _vendorManagementDbContext;

        public VendorManagementRepository(IVendorManagementDbContext vendorManagementDbContext)
        {
            _vendorManagementDbContext = vendorManagementDbContext;
        }
        public async Task<bool> DeleteVendor(int id)
        {
            try
            {
                var result = await _vendorManagementDbContext.DeleteVendor(id);
                if (result)
                {
                    return result;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<VendorDetail> GetVendor(int id)
        {
            try
            {
                var result = await _vendorManagementDbContext.GetVendor(id);
              
                return result;
                
              

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<VendorDetail>> GetVendors()
        {
            try
            {
                var result = await _vendorManagementDbContext.GetVendors();
                
                return result;
           
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> SaveVendorDetail(VendorDetail vendorDetail)
        {
            try
            {
                var result = await _vendorManagementDbContext.SaveVendorDetail(vendorDetail);
                if (result)
                {
                    return result;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async  Task<bool> UpdateVendorDetail(VendorDetail vendorDetail)
        {
            try
            {
                var result = await _vendorManagementDbContext.UpdateVendorDetail(vendorDetail);
                if (result)
                {
                    return result;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
