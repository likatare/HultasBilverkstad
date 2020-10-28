using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLibrary
{
    public class YoungAdultModel : UserModel
    {
        private int _age;
        [DisplayName("Ålder")]
        [Required(ErrorMessage = "ålder saknas")]
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private ServiceModel _bookedService;

        public ServiceModel BookedService
        {
            get { return _bookedService; }
            set { _bookedService = value; }
        }


        public int GetAgeMinimum()
        {


            return 18;

        }

        public int GetAgeMaximum()
        {


            return 25;

        }




        public bool CheckAge(RegisterModel regModel)
        {
            YoungAdultModel youngAdult = new YoungAdultModel();
           

            regModel.Age = regModel.GetAge(regModel);

            if (regModel.Age >= youngAdult.GetAgeMinimum() && regModel.Age <= youngAdult.GetAgeMaximum())
            {
                return true;

            }
            else
            {
                return false;
            }



        }

        public YoungAdultModel Booking(RegisterModel regModel)
        {
            YoungAdultModel userModel = new YoungAdultModel
            {
                FirstName = regModel.FirstName,
                LastName = regModel.LastName,
                Email = regModel.Email,
                PhoneNumber = regModel.PhoneNumber,
                Age = regModel.Age,
            };
            return userModel;
        }
    }
}
