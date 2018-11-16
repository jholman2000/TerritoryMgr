using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using static TerritoryMgr.Models.AddressCodeDescription;

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
    }

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum AddressCode
    {
        [Description(AddressCodeDescription.NotAtHome)]
        NotAtHome=0

    }

    public static class AddressCodeDescription
    {
        public const string NotAtHome = "No en casa";
    }
}