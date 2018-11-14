using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dapper;
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

                conn.Open();
                var multi = conn.QueryMultiple(sql);

                var data = multi.Read<Territory>().FirstOrDefault();
                return data;
            }
        }
    }
}