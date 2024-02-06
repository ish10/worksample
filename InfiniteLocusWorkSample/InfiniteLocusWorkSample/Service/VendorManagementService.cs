using Datamodel.Models;
using InfiniteLocusWorkSample.Helper.Interface;
using InfiniteLocusWorkSample.Model.ApiResponse;
using InfiniteLocusWorkSample.Repository.Interfaces;
using InfiniteLocusWorkSample.Service.Interfaces;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;


namespace InfiniteLocusWorkSample.Service
{
    public class VendorManagementService : IVendorManagementService
    {
        private readonly IVendorManagementRepository _vendorManagementRepository;
        private readonly ICustomValidator _CustomValidator;
        public VendorManagementService(IVendorManagementRepository vendorManagementRepository, ICustomValidator CustomValidator)
        {
            _vendorManagementRepository = vendorManagementRepository;
            _CustomValidator = CustomValidator;
        }
        public async Task<ApiResponse> DeleteVendor(int id)
        {
            
           
            try
            {
                var validationResult= await _CustomValidator.validateSingle(id);
                if (validationResult.Count > 0) 
                {
                    return new ApiBadRequest(validationResult);
                }
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
                var validationResult = await _CustomValidator.validateSingle(id);
                if (validationResult.Count > 0)
                {
                    return new ApiBadRequest(validationResult);
                }

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
                if (result.Count>0)
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
                var validationResult = await _CustomValidator.validateSingle(vendorDetail.Id);
                if (validationResult.Count > 0)
                {
                    return new ApiBadRequest(validationResult);
                }
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
