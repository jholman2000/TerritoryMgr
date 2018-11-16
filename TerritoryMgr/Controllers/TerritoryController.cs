using System.Linq;
using Dapper;
using TerritoryMgr.Models;
using TerritoryMgr.ViewModels;

namespace TerritoryMgr.Controllers
{
    public class TerritoryController : BaseController
    {
        public TerritoryViewModel GetTerritory(int id)
        {
            var model = new TerritoryViewModel();

            using (var conn = Connection)
            {
                var sql = $"select * from terr_Territory where Id={id};" +
                    $"select * from terr_Address where TerritoryId={id};" +
                    $"select * from terr_Publisher where Id=(select PublisherId from terr_Territory where Id={id});";

                conn.Open();
                var multi = conn.QueryMultiple(sql);

                model.Territory = multi.Read<Territory>().FirstOrDefault();
                model.Addresses = multi.Read<Address>().ToList();
                model.Publisher = multi.Read<Publisher>().FirstOrDefault();
            }

            return model;
        }
    }
}