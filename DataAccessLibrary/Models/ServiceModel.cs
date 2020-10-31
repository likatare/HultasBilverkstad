using DataAccessLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

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
