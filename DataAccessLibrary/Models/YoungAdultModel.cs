using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataAccessLibrary
{
    public class YoungAdultModel : UserModel
    {
        private int _age;
        [DisplayName("Ålder")]
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


        public YoungAdultModel CheckAge(RegisterModel regModel)
        {
            YoungAdultModel youngAdultModel = new YoungAdultModel();

            if (regModel.Age < 25)
            {
                youngAdultModel = Booking(regModel);
            }

            return youngAdultModel;

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
