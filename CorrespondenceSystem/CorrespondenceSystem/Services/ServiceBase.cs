using System.Collections.Generic;
using CorrespondenceSystem.Implementations;
using CorrespondenceSystem.Interfaces;

namespace CorrespondenceSystem.Services
{
    public class ServiceBase : IServiceBase
    {
        

        public List<Entity<int>> GetAllEntities()
        {
            throw new System.NotImplementedException();
        }

        public Entity<int> GetEntity(int id)
        {
            throw new System.NotImplementedException();
        }

        public void CreateEntity(Entity<int> entity)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateEntity(Entity<int> entity)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEntity(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}