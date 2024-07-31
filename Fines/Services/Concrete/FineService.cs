using Fines.Data;
using Fines.Models;
using Fines.Services.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Fines.Services.Concrete
{
    public class FineService : IFineService
    {
        #region Fields
        private readonly ApplicationDbContext _context;
        #endregion


        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="context"></param>
        public FineService(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get all fines by license plate 
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <returns></returns>
        public async Task<List<Fine>> GetFinesByLicensePlateAsync(string licensePlate)
        {
            if (string.IsNullOrWhiteSpace(licensePlate))
            {
                return new List<Fine>();
            }

            var platesList = licensePlate.Split(',')
                                           .Select(p => p.Trim())
                                           .Where(p => !string.IsNullOrWhiteSpace(p))
                                           .Select(p => p.Replace(" ", "").ToLower())
                                           .ToList();
            if (!platesList.Any())
            {
                return new List<Fine>();
            }

            // Search the database to find fines where the license plate contains any of the input strings
            return await _context.Fine
                .Include(f => f.Vehicle)
                .Where(f => platesList.Any(plate => f.Vehicle.LicensePlate.Replace(" ", "").ToLower().Contains(plate)))
                .ToListAsync();
        }


        /// <summary>
        /// Pays the fine
        /// </summary>
        /// <param name="fineId"></param>
        /// <returns></returns>
        public async Task<bool> PayFineAsync(int fineId)
        {
            var fine = await _context.Fine.FindAsync(fineId);
            if (fine == null || fine.IsPaid)
            {
                return false;
            }

            fine.IsPaid = true;
            fine.PaymentDate = DateTime.Now;
            await _context.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
