using Datamodel.Models;

namespace InfiniteLocusWorkSample.Repository.Interfaces
{
    public interface IVendorManagementRepository
    {
        Task<List<VendorDetail>> GetVendors();
        Task<VendorDetail> GetVendor(int id);

        Task<bool> SaveVendorDetail(VendorDetail vendorDetail);
        Task<bool> UpdateVendorDetail(VendorDetail vendorDetail);

        Task<bool> DeleteVendor(int id);
    }
}
