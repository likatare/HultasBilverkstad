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

        
        private string _birthYear;
        [DisplayName("Personnummer *")]
        [RegularExpression(@"^(19|20)?[0-9]{6}[- ]?[0-9]{4}$", ErrorMessage ="personnummer fel format") ]
        [Required (ErrorMessage ="personnummer saknas")]
        public string BirthYear
        {
            get { return _birthYear; }
            set { _birthYear = value; }
        }
        
        public int GetAge(RegisterModel regModel)
        {
            var piecesOfBirthyear  = regModel.BirthYear.Substring(0,4);

            regModel.BirthYear = piecesOfBirthyear;

            DateTime now = DateTime.Now;
            int age = now.Year - int.Parse(regModel.BirthYear);

            return age;
        }



    }
}
