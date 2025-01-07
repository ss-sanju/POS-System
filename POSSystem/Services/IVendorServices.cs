using POSSystem.Models.Item_Management;

namespace POSSystem.Services
{
    public interface IVendorServices
    {
        Task<IEnumerable<Vendor>> GetAllVendorAsync();
        Task<Vendor> GetVendorByIdAsync(Guid id);
        Task AddVendorAsync(Vendor Vendor);
        Task UpdateVendorAsync(Vendor Vendor);
        Task DeleteVendorAsync(Guid id);
    }
}
