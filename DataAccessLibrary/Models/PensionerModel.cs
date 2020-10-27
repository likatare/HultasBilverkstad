using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel;

namespace DataAccessLibrary
{
    public class PensionerModel : UserModel
    {
        private int _personalIdentityNumber;
        [DisplayName("Personnummer")]
        public int PersonalIdentityNumber
        {
            get { return _personalIdentityNumber; }
            set { _personalIdentityNumber = value; }
        }

        private ServiceModel _bookedService;

        public ServiceModel BookedService
        {
            get { return _bookedService; }
            set { _bookedService = value; }
        }


        private void GetAge()
        {
            DateTime DateTime = DateTime.Now;
        }

        public PensionerModel  Booking(RegisterModel regModel)
        {
            PensionerModel userModel = new PensionerModel
            {
                FirstName = regModel.FirstName,
                LastName = regModel.LastName,
                Email = regModel.Email,
                PhoneNumber = regModel.PhoneNumber,
                PersonalIdentityNumber = regModel.PersonalIdentityNumber
            };

            return userModel;
        }
    }
}
