using POSSystem.Generic;
using POSSystem.Models.Item_Management;

namespace POSSystem.Services;

public class VendorServices : IVendorServices
{
    private readonly IUnitOfWork _unitofwork;
    public VendorServices(IUnitOfWork unitofwork)
    {
        _unitofwork = unitofwork;
    }   
    public async Task<IEnumerable<Vendor>> GetAllVendorAsync()
    {
        return await _unitofwork.VendorRepository.GetAllAsync();
    }
    public async Task<Vendor> GetVendorByIdAsync(Guid id)
    {
        return await _unitofwork.VendorRepository.GetByIdAsync(id);
    }
    public async Task AddVendorAsync(Vendor Vendor)
    {
         await _unitofwork.VendorRepository.AddAsync(Vendor);
        await _unitofwork.SaveAsync();
    }
    public async Task UpdateVendorAsync(Vendor Vendor)
    {
        await _unitofwork.VendorRepository.UpdateAsync(Vendor);
        await _unitofwork.SaveAsync();
    }
    public async Task DeleteVendorAsync(Guid id)
    {
        await _unitofwork.VendorRepository.DeleteAsync(id);
        await _unitofwork.SaveAsync();
    }

}
