using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Repository
{
    public class PensionerRepository
    {
        public static bool CheckUsername(string email)
        {
            Database db = new Database();
            PensionerModel user = db.PensionerCollection.Find(u => u.Email == email).First();
            if (user != null)
            {
                return false;
            }
            return true;
        }

        public static void InsertUser(PensionerModel userModel)
        {
            Database db = new Database();
            db.PensionerCollection.InsertOne(userModel);
        }

        public static void InsertBookingresult(ServiceModel service, PensionerModel pensioners)
        {
            pensioners.BookedService = service;

            Database db = new Database();
            db.PensionerCollection.InsertOne(pensioners);
        }
    }
}
