using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLibrary
{
    public class PensionerModel : UserModel
    {
        private string _birthDate;
        [DisplayName("Personnummer *")]
        [Required(ErrorMessage = "personnummer saknas")]
        public string BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        private ServiceModel _bookedService;

        public ServiceModel BookedService
        {
            get { return _bookedService; }
            set { _bookedService = value; }
        }

        public int GetAgeMinimum()
        {


            return 26;

        }

        public int GetAgeMaximum()
        {


            return 100;

        }

        public bool CheckAge(RegisterModel regModel)
        {
            PensionerModel pensioner = new PensionerModel();


            regModel.Age = regModel.GetAge(regModel);

            if (regModel.Age >= pensioner.GetAgeMinimum() && regModel.Age <= pensioner.GetAgeMaximum())
            {
                return true;

            }
            else
            {
                return false;
            }



        }


        public PensionerModel Booking(RegisterModel regModel)
        {
            PensionerModel userModel = new PensionerModel
            {
                FirstName = regModel.FirstName,
                LastName = regModel.LastName,
                Email = regModel.Email,
                PhoneNumber = regModel.PhoneNumber,
                BirthDate = regModel.BirthYear 
            };

            return userModel;
        }
    }
}
