using Datamodel.Models;
using InfiniteLocusWorkSample.Model.ApiResponse;

namespace InfiniteLocusWorkSample.Service.Interfaces
{
    public interface IVendorManagementService
    {
        Task<ApiResponse> GetVendors();
        Task<ApiResponse> GetVendor(int id);

        Task<ApiResponse> SaveVendorDetail(VendorDetail vendorDetail);
        Task<ApiResponse> UpdateVendorDetail(VendorDetail vendorDetail);

        Task<ApiResponse> DeleteVendor(int id);

    }
}
