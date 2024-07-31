using Fines.Data;
using Fines.Models.ViewModels;
using Fines.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fines.Controllers
{
    [Authorize]
    public class FinesController : Controller
    {
        #region Fields
        private readonly ApplicationDbContext _context;
        private readonly IFineService _fineService;
        #endregion

        #region Ctor
        public FinesController(ApplicationDbContext context, IFineService fineService)
        {
            _context = context;
            _fineService = fineService;
        }
        #endregion

        #region Methdos

        /// <summary>
        /// The index page
        /// </summary>
        /// <returns></returns>
        public IActionResult Search()
        {
            return View(new VehicleFinesViewModel());
        }
        /// <summary>
        /// Gets all fines for the license plates
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> SearchFines(string licensePlate, int page = 1)
        {
            const int pageSize = 10;

            // Get all fines for the license plate
            var allFines = await _fineService.GetFinesByLicensePlateAsync(licensePlate);
            var totalUnpaidFines = allFines.Where(f => !f.IsPaid).Sum(f => f.Amount);

            // Apply pagination
            var totalFines = allFines.Count;
            var fines = allFines
                .OrderBy(f => f.DateOfFine)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var viewModel = new VehicleFinesViewModel
            {
                LicensePlate = licensePlate,
                Fines = fines,
                TotalUnpaidFines = totalUnpaidFines,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling((double)totalFines / pageSize)
            };

            return View("Search", viewModel);
        }

        /// <summary>
        /// Pays the fine of that license plate
        /// </summary>
        /// <param name="fineId"></param>
        /// <param name="licensePlate"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PayFine(int fineId, string licensePlate, int page = 1)
        {
            const int pageSize = 10;
            var result = await _fineService.PayFineAsync(fineId);
            if (!result)
            {
                ModelState.AddModelError("", "Failed to pay the fine.");
            }

            var fines = await _fineService.GetFinesByLicensePlateAsync(licensePlate);
            var totalUnpaidFines = fines.Where(f => !f.IsPaid).Sum(f => f.Amount);

            var viewModel = new VehicleFinesViewModel
            {
                LicensePlate = licensePlate,
                Fines = fines.OrderBy(f => f.DateOfFine).Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                TotalUnpaidFines = totalUnpaidFines,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling((double)fines.Count / pageSize)
            };

            return View("Search", viewModel);
        }

        #endregion
    }
}
