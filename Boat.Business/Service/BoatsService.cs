using Boat.Data.DataModel.BoatModule.Entity;
using Boat.Data.DataModel.BoatModule.Interface;
using Boat.Framework.Service;

namespace Boat.Business.Service
{
    public class BoatsService : Service<Boats, long, IBoatsRepository>, IBoatsService
    {
        public BoatsService(IBoatsRepository repository) : base(repository)
        {
        }

        ////private readonly UnitOfWork unitOfWork;
        //private readonly IBoatsRepository _repository;
        //public BoatsService(IBoatsRepository repository)
        //{
        //    //unitOfWork = new UnitOfWork(DbConstant.DatabaseConnection);
        //    _repository = repository;
        //}

        //public long Add(Boats entity)
        //{
        //    //this.unitOfWork.BeginTransaction();

        //    return this._repository.Save(entity);

        //    //this.unitOfWork.Commit();

        //    //return id;

        //}

        //public Task<long> AddAsync(Boats entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void Delete(Boats entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public Task DeleteAsync(Boats entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public Boats Get(long id)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public IEnumerable<Boats> GetAll()
        //{
        //    return this._repository.GetAll();
        //}

        //public Task<Boats> GetAsync(long id)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void Update(Boats entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public Task UpdateAsync(Boats entity)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
