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

        // GET: /Vehicle/Search
        public IActionResult Search()
        {
            return View(new VehicleFinesViewModel());
        }

        // POST: /Vehicle/SearchFines
        [HttpPost]
        public async Task<IActionResult> SearchFines(string licensePlate)
        {
            var fines = await _fineService.GetFinesByLicensePlateAsync(licensePlate);
            var totalUnpaidFines = fines.Where(f => !f.IsPaid).Sum(f => f.Amount);

            var viewModel = new VehicleFinesViewModel
            {
                LicensePlate = licensePlate,
                Fines = fines,
                TotalUnpaidFines = totalUnpaidFines
            };

            return View("Search", viewModel);
        }

        // POST: /Vehicle/PayFine
        [HttpPost]
        public async Task<IActionResult> PayFine(int fineId, string licensePlate)
        {
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
                Fines = fines,
                TotalUnpaidFines = totalUnpaidFines
            };

            return View("Search", viewModel);
        }

        #endregion
    }
}
