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
        [DisplayName("Förnamn *")]
        [Required(ErrorMessage = "förnamn saknas")]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;
        [DisplayName("Efternamn *")]
        [Required(ErrorMessage = "efternamn saknas")]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _email;
        [DisplayName("Epost *")]
        [Required(ErrorMessage = "epost saknas")]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _phoneNumber;
        [DisplayName("Telefonnummer")]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        private int _age;
        [DisplayName("Ålder *")]
        [Required(ErrorMessage = "ålder saknas")]
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private DateTime _birthYear;
        [DisplayName("Personnummer *")]
        [Required (ErrorMessage ="personnummer saknas")]
        public DateTime BirthYear
        {
            get { return _birthYear; }
            set { _birthYear = value; }
        }


        

        public int GetAge(RegisterModel regModel)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - regModel.BirthYear.Year;

            return age;
        }



    }
}
