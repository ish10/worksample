using DataAcess.Data;
using Datamodel.Models;
using InfiniteLocusWorkSample.Model.ApiResponse;
using InfiniteLocusWorkSample.Service;
using InfiniteLocusWorkSample.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace InfiniteLocusWorkSample.Controllers
{
  
    public class VendorManagementController :BaseController
    {
        private readonly IVendorManagementService _vendorManagementService;
        public VendorManagementController(IVendorManagementService vendorManagementService) {
            _vendorManagementService = vendorManagementService;
        }
        [HttpGet]
        [Route("GetVendorsDetails")]
        public async Task<IActionResult> GetVendorsDetails()
        {
           
            try
            {
                return GetResult(await _vendorManagementService.GetVendors());

             }
           catch (Exception ex) 
            { 
                throw; 
            }
        
        }

        [HttpGet]
        [Route("GetVendorDetails/{vendorId}")]
        public async Task<IActionResult> GetVendorDetails(int vendorId)
        {
            try 
            {
                return GetResult(await _vendorManagementService.GetVendor(vendorId));
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        [HttpPost]
        [Route("SaveVendorDetails")]

        public async Task<IActionResult> SaveVendorDetails([FromBody] VendorDetail vendorDetail )
        {
         
            try
            {

                return GetResult(await _vendorManagementService.SaveVendorDetail(vendorDetail));

            }
            catch (Exception ex)
            {
                throw;
            }
            // var ish = 0;
            // var res =await _dbcontext.AddAsync(vendorDetail);
            //var finalresult= await _dbcontext.SaveChangesAsync();
            // return GetResult(new ApiCreatedResponse());
        }

        [HttpPut]
        [Route("SubmitVendorDetails")]

        public async Task<IActionResult> SubmitVendorDetails([FromBody] VendorDetail vendorDetail)
        {
            try
            {
                return GetResult(await _vendorManagementService.UpdateVendorDetail(vendorDetail));

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpDelete]
        [Route("DeleteVendorDetail/{id}")]
        public async Task<IActionResult> DeleteVendorDetail(int id) 
        {
            try
            {
                return GetResult(await _vendorManagementService.DeleteVendor(id));

            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
