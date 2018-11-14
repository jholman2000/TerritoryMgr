using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace TerritoryMgr.Models
{
    public class Territory
    {
        public int Id { get; set; }
        public string TerritoryNumber { get; set; }
        public string TerritoryName { get; set; }
        public DateTime? DateLastAssigned { get; set; }
        public DateTime? DateLastReturned { get; set; }     
        public Publisher Publisher { get; set; }
    }
}