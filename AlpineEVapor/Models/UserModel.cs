using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlpineEVapor.Models
{
    public class UserModel
    {
        private object _id { get; set; }
        public int ID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phoneNo { get; set; }
        public string streetAdress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipCode { get; set; }
    }
}