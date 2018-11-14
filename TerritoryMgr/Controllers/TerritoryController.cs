using System.Linq;
using TerritoryMgr.Models;

namespace TerritoryMgr.Controllers
{
    public class TerritoryController : BaseController
    {
        public Territory GetTerritory(int id)
        {
            using (var conn = Connection)
            {
                var sql = $"select * from terr_Territory where Id={id};";

                var results = GetListFromSql<Territory>(sql).FirstOrDefault();
                //conn.Open();
                //var multi = conn.QueryMultiple(sql);

                //var data = multi.Read<Territory>().FirstOrDefault();
                return results;
            }
        }
    }
}