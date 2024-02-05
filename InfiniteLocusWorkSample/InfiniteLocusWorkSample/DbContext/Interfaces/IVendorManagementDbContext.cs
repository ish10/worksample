using Datamodel.Models;
using InfiniteLocusWorkSample.Model.ApiResponse;

namespace InfiniteLocusWorkSample.DbContext.Interfaces
{
    public interface IVendorManagementDbContext
    {
        Task <List<VendorDetail>> GetVendors();
        Task<VendorDetail> GetVendor(int id);

        Task<bool> SaveVendorDetail(VendorDetail vendorDetail);
        Task<bool> UpdateVendorDetail(VendorDetail vendorDetail);

        Task<bool> DeleteVendor(int id);
    }
}
