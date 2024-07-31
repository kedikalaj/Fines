using Fines.Models;

namespace Fines.Services.Abstract
{
    public interface IFineService
    {
        /// <summary>
        /// Get all fines by license plate 
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <returns></returns>
        Task<List<Fine>> GetFinesByLicensePlateAsync(string licensePlate);

        /// <summary>
        /// Pays the fine
        /// </summary>
        /// <param name="fineId"></param>
        /// <returns></returns>
        Task<bool> PayFineAsync(int fineId);
    }
}
