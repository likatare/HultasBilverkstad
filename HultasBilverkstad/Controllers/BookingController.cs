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
           
            ServiceModel service = new ServiceModel();
            service.ServicePensioner(pensionerBooking.Pensioners, pensionerBooking.Service);

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
            ServiceModel service = new ServiceModel();
            service.ServiceYoungAdult(youngAdultBooking.YoungAdult, youngAdultBooking.Service);
            

            return View(youngAdultBooking);
        }

    }
}
