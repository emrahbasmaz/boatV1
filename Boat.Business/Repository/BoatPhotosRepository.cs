using Boat.Data.Base;
using Boat.Data.DataModel.BoatModule.Entity;
using Boat.Data.DataModel.BoatModule.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Boat.Business.Repository
{
    public class BoatPhotosRepository : Repository<BoatPhotos, long>, IBoatPhotosRepository
    {
        public bool DeleteByBoatId(BoatPhotos boat)
        {
            return this.Delete(boat);
        }

        public BoatPhotos Get(int key)
        {
            return this.Get(key);
        }

        public async Task<BoatPhotos> GetAsync(int key)
        {
            return await this.GetAsync(key);
        }

        public long Insert(BoatPhotos photo)
        {
            return this.Insert(photo);
        }

        public List<BoatPhotos> SelectByBoatId(long boatId)
        {
            var sql = String.Format("select * from BOAT_PHOTOS where BOAT_ID = {0} and RECORD_STATUS = 1", boatId);
            return this.Query(sql) as List<BoatPhotos>;
        }
    }
}
