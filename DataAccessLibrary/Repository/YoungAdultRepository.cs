using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Repository
{
    public class YoungAdultRepository
    {
        public static bool CheckUsername(string email)
        {
            Database db = new Database();
            YoungAdultModel user = db.YoungAdultCollection.Find(u => u.Email == email).First();
            if (user != null)
            {
                return false;
            }
            return true;
        }

        public static void InsertUser(YoungAdultModel userModel)
        {
            Database db = new Database();
            db.YoungAdultCollection.InsertOne(userModel);
        }

        public static void InsertBookingresult(ServiceModel service, YoungAdultModel youngAdult)
        {

            youngAdult.BookedService = service;

            Database db = new Database();
            db.YoungAdultCollection.InsertOne(youngAdult);

        }
    }
}
