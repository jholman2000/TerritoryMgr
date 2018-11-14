using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using TerritoryMgr.Models;

namespace TerritoryMgr.Controllers
{
    public class PublisherController : BaseController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public Publisher Get(int id)
        {
            using (var conn = Connection)
            {
                var sql = $"select * from terr_Publisher where Id={id};";

                var results = GetListFromSql<Publisher>(sql).FirstOrDefault();
                //conn.Open();
                //var multi = conn.QueryMultiple(sql);

                //var data = multi.Read<Territory>().FirstOrDefault();
                return results;
            }
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
