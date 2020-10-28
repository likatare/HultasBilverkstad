using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccessLibrary;
using DataAccessLibrary.Repository;

namespace HultasBilverkstad.Controllers
{
    public class RegisterController : Controller
    {
        
        // GET: RegisterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegisterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegisterModel regModel)
        {
            YoungAdultModel youngAdult = new YoungAdultModel();
            PensionerModel pensioner = new PensionerModel();

           

            if (youngAdult.CheckAge(regModel))
            {
                youngAdult = youngAdult.Booking(regModel);
                return RedirectToAction("YoungAdult", "Booking", youngAdult);
               
            }
            else if(pensioner.CheckAge(regModel))
            {
                pensioner = pensioner.Booking(regModel);
                return RedirectToAction("Pensioner", "Booking", pensioner);
            }
            else
            {
                
                ViewBag.Errormessage = "Ange en annan ålder";
                return View(regModel);
            }

        }
        //private bool CheckUsername(string username)
        //{
        //    bool isUsernameValid;

        //    isUsernameValid = PensionerRepository.CheckUsername(username);

        //    if (!isUsernameValid)
        //    {
        //        return isUsernameValid;
        //    }

        //    isUsernameValid = YoungAdultRepository.CheckUsername(username);

        //    return isUsernameValid;
        //}

    }
}
