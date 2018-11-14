using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TerritoryMgr.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string UnitNumber { get; set; }
        public string Street { get; set; }
        public string Community { get; set; }
        public bool Confirmed { get; set; }
        public bool Possible { get; set; }
        public string Comment { get; set; }
    }
}