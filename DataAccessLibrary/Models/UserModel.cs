using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLibrary
{
    public abstract class UserModel
    {
        private string _firstname;
        [DisplayName("Förnamn")]
        [Required(ErrorMessage = "förnamn saknas")]
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        private string _lastName;
        [DisplayName("Efternamn")]
        [Required(ErrorMessage = "efternamn saknas")]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _email;
        [DisplayName("Epost")]
        [Required(ErrorMessage = "epost saknas")]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _phoneNumber;
        [DisplayName("Telefonnummer")]
        [Required(ErrorMessage = "telefonnummer saknas")]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
    }
}
