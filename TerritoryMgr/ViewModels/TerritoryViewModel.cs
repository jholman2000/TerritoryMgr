using System.Collections.Generic;
using TerritoryMgr.Models;

namespace TerritoryMgr.ViewModels
{
    /// <summary>
    ///     Retrieve Territory details, including Addresses and assigned Publisher
    /// </summary>
    public class TerritoryViewModel
    {
        public Territory Territory { get; set; }
        public List<Address> Addresses { get; set; }
        public Publisher Publisher { get; set; }
    }
}