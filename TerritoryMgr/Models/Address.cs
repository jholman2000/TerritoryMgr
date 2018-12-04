using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;
using TerritoryMgr.Infrastructure;

namespace TerritoryMgr.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int TerritoryId { get; set; }
        public string UnitNumber { get; set; }
        public string Street { get; set; }
        public string Community { get; set; }
        public AddressCode Code { get; set; }    
        public bool Confirmed { get; set; }
        public bool Possible { get; set; }
        public bool DoNotKnock { get; set; }
        public string Comment { get; set; }

        public string CodeDescription => Code.EnumDescription();
    }

    
    public enum AddressCode
    {
        [Description(AddressCodeDescription.NotAtHome)]
        NotAtHome=0,
        [Description(AddressCodeDescription.NotInterested)]
        NotInterested = 1,
        [Description(AddressCodeDescription.Man)]
        Man = 2,
        [Description(AddressCodeDescription.Woman)]
        Woman = 3,
        [Description(AddressCodeDescription.Child)]
        Child = 4
    }

    public static class AddressCodeDescription
    {
        public const string NotAtHome = "No en casa";
        public const string NotInterested = "No interesado";
        public const string Man = "Hombre";
        public const string Woman = "Mujer";
        public const string Child = "Joven";
        
    }
}