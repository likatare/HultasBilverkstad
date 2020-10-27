using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary;
using Microsoft.AspNetCore.Mvc;
using HultasBilverkstad.ViewModel;
using DataAccessLibrary.Repository;

namespace HultasBilverkstad.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Pensioner(PensionerModel pensioner)
        {
            PensionerBookingViewModel pensionerBooking = new PensionerBookingViewModel
            {
                Pensioners = pensioner,
                Service = new ServiceModel()

            };
                    
            return View(pensionerBooking);
        }

        // POST: RegisterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PensionerBookingResult(PensionerBookingViewModel pensionerBooking)
        {
            PensionerRepository.InsertBookingresult(pensionerBooking.Service,pensionerBooking.Pensioners);

            return View(pensionerBooking);
        }


        public IActionResult YoungAdult(YoungAdultModel youngAdult)
        {
            YoungAdultBookingViewModel youngAdultBooking = new YoungAdultBookingViewModel
            {
                YoungAdult= youngAdult,
                Service = new ServiceModel()
            };

            return View(youngAdultBooking);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult YoungAdultBookingResult(YoungAdultBookingViewModel youngAdultBooking)
        {
            YoungAdultRepository.InsertBookingresult(youngAdultBooking.Service, youngAdultBooking.YoungAdult);

            return View(youngAdultBooking);
        }

    }
}
