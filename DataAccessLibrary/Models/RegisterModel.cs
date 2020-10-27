using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLibrary
{
    public class RegisterModel
    {
        private string _firstName;
        [DisplayName("Förnamn")]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;
        [DisplayName("Efternamn")]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _email;
        [DisplayName("Epost")]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _phoneNumber;
        [DisplayName("Telefonummer")]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        private int _age;
        [DisplayName("Ålder")]
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private int _personalIdentityNumber;
        [DisplayName("Personummer")]
        public int PersonalIdentityNumber
        {
            get { return _personalIdentityNumber; }
            set { _personalIdentityNumber = value; }
        }


       

    }
}
