using System;
using System.Linq;
using System.Web.Http;
using Dapper;
using Dapper.Contrib.Extensions;
using TerritoryMgr.Models;
using TerritoryMgr.ViewModels;

namespace TerritoryMgr.Controllers
{
    /// <summary>
    /// Provides Territory information
    /// </summary>
    public class TerritoryController : BaseController
    {
        /// <summary>
        /// Get all details for a given Territory
        /// </summary>
        /// <param name="id">ID assigned to the Territory</param>
        /// <returns>Territory details</returns>
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

        [HttpPost]
        public bool Save([FromBody]Territory model)
        {
            try
            {
                if (model.Id == 0)
                {
                    Connection.Insert(model);
                }
                else
                {
                    Connection.Update(model);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}