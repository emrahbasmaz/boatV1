using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Boat.Data.Base;
using Boat.Data.DataModel.BoatModule.Entity;
using Boat.Data.DataModel.BoatModule.Interface;
using Boat.Data.Utility;
using Dapper;

namespace Boat.Business.Repository
{
    public class BoatPhotosRepository : Repository<BoatPhotos, long>, IBoatPhotosRepository
    {
        //public bool DeleteByBoatId(BoatPhotos boat)
        //{
        //    return this.Delete(boat);
        //}

        //public BoatPhotos Get(int key)
        //{
        //    return this.Get(key);
        //}

        //public async Task<BoatPhotos> GetAsync(int key)
        //{
        //    return await this.GetAsync(key);
        //}

        //public long Insert(BoatPhotos photo)
        //{
        //    return this.Insert(photo);
        //}

        //public List<BoatPhotos> SelectByBoatId(long boatId)
        //{
        //    var sql = String.Format("select * from BOAT_PHOTOS where BOAT_ID = {0} and RECORD_STATUS = 1", boatId);
        //    return this.Query(sql) as List<BoatPhotos>;
        //}
        //public BoatPhotos Get(int key)
        //{
        //    var sql = String.Format("select * from BOAT_PHOTOS where BOAT_ID = @id and RECORD_STATUS = 1", key);
        //    using (var sqlConnection = new SqlConnection(DbConstant.DatabaseConnection))
        //        return SqlMapper.Query<BoatPhotos>(sqlConnection, sql).FirstOrDefault();
        //}

        //public async Task<BoatPhotos> GetAsync(int key)
        //{
        //    var sql = String.Format("select * from BOAT_PHOTOS where BOAT_ID = @id and RECORD_STATUS = 1", key);
        //    using (var sqlConnection = new SqlConnection(DbConstant.DatabaseConnection))
        //        return await SqlMapper.QueryFirstAsync<BoatPhotos>(sqlConnection, sql);
        //}
    }
}
