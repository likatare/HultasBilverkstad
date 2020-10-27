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


            if (regModel.Age < 25)
            {
                youngAdult = youngAdult.CheckAge(regModel);
                //YoungAdultRepository.InsertUser(youngAdult);
                return RedirectToAction("YoungAdult", "Booking", youngAdult);
               
            }
            else
            {

                pensioner = pensioner.Booking(regModel);
                PensionerRepository.InsertUser(pensioner);
                return RedirectToAction("Pensioner", "Booking", pensioner);
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
