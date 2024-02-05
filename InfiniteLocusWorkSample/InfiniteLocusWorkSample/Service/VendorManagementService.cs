using Datamodel.Models;
using InfiniteLocusWorkSample.Model.ApiResponse;
using InfiniteLocusWorkSample.Repository.Interfaces;
using InfiniteLocusWorkSample.Service.Interfaces;

namespace InfiniteLocusWorkSample.Service
{
    public class VendorManagementService : IVendorManagementService
    {
        private readonly IVendorManagementRepository _vendorManagementRepository;

        public VendorManagementService(IVendorManagementRepository vendorManagementRepository)
        {
            _vendorManagementRepository = vendorManagementRepository;
        }
        public async Task<ApiResponse> DeleteVendor(int id)
        {
            try
            {
                var result=await _vendorManagementRepository.DeleteVendor(id);
                if (result)
                {
                    return new ApiOkResponse(result);
                }
                else {
                    return new ApiNotFoundResponse();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<ApiResponse> GetVendor(int id)
        {
             try
            {
                var result = await _vendorManagementRepository.GetVendor(id);
                if (result!=null)
                {
                    return new ApiOkResponse(result);
                }
                else
                {
                    return new ApiNotFoundResponse();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<ApiResponse> GetVendors()
        {
            try
            {
                var result = await _vendorManagementRepository.GetVendors();
                if (result != null)
                {
                    return new ApiOkResponse(result);
                }
                else
                {
                    return new ApiNotFoundResponse();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<ApiResponse> SaveVendorDetail(VendorDetail vendorDetail)
        {
            Dictionary<int,string> dic= new Dictionary<int, string>();
            dic.Add(1, "validation error");
            try
            {
                var result = await _vendorManagementRepository.SaveVendorDetail(vendorDetail);
                if (result)
                {
                    return new ApiOkResponse(result);
                }
                else
                {

                    return new ApiBadRequest(dic);
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<ApiResponse> UpdateVendorDetail(VendorDetail vendorDetail)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "validation error");
            try
            {
                var result = await _vendorManagementRepository.UpdateVendorDetail(vendorDetail);
                if (result)
                {
                    return new ApiOkResponse(result);
                }
                else
                {

                    return new ApiBadRequest(dic);
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
