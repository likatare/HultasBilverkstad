using DataAccessLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace DataAccessLibrary
{
    public class ServiceModel
    {
        private string _additionalService;

        public string AdditionalService
        {
            get { return _additionalService; }
            set { _additionalService = value; }
        }

        private DateTime _dateTime = DateTime.Today.Date;
        
        [DisplayName("Datum")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Required(ErrorMessage = "datum saknas")]
        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        private string _comment;
        [DisplayName("Kommentar")]
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        private string _registrationsNumber;
        [DisplayName("Registreringsnummer")]
        [Required(ErrorMessage ="Registreringsnummer saknas")]
        [RegularExpression("[A-Za-z]{3}[0-9]{2}[A-Za-z0-9]{1}", ErrorMessage = "Ange ett giltigt registreringsnummer")]
        [MaxLength(7)]
        [MinLength(2)]
        public string RegistrationsNumber
        {
            get { return _registrationsNumber; }
            set { _registrationsNumber = value; }
        }

        public void ServicePensioner( PensionerModel pensioner , ServiceModel service)
        {
            PensionerRepository.InsertBookingresult(service,pensioner );
        }

        public void ServiceYoungAdult(YoungAdultModel youngAdult, ServiceModel service)
        {
            YoungAdultRepository.InsertBookingresult(service, youngAdult);
        }


    }
}
