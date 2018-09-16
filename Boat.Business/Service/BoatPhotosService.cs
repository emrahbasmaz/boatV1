﻿using Boat.Business.Repository;
using Boat.Data.DataModel.BoatModule.Entity;
using Boat.Data.DataModel.BoatModule.Interface;
using Boat.Data.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Boat.Business.Service
{
    public class BoatPhotosService : IBoatPhotosService
    {
        private readonly IBoatPhotosRepository photosRepository;

        public BoatPhotosService(IBoatPhotosRepository photosRepository)
        {
            this.photosRepository = photosRepository;

        }

        public object Add(BoatPhotos entity)
        {
            return this.photosRepository.Save(entity);
        }

        public async Task<int> AddAsync(BoatPhotos entity)
        {
            return await this.photosRepository.SaveAsync(entity);
        }

        public void Delete(BoatPhotos entity)
        {
            this.photosRepository.Delete(entity);
        }

        public Task DeleteAsync(BoatPhotos entity)
        {
            return this.photosRepository.DeleteAsync(entity);
        }

        public IEnumerable<BoatPhotos> Get()
        {
            var sql = String.Format("select * from BOAT_PHOTOS where RECORD_STATUS = 1");
            return this.photosRepository.Query(sql);
        }

        public BoatPhotos Get(long id)
        {
            return this.photosRepository.Get(Convert.ToInt32(id));
        }

        public async Task<BoatPhotos> GetAsync(long id)
        {
            return await this.photosRepository.GetAsync(Convert.ToInt32(id));
        }

        public void Update(BoatPhotos entity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(BoatPhotos entity)
        {
            throw new System.NotImplementedException();
        }
    }
}