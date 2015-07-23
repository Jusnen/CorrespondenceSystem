using System.Collections.Generic;
using CorrespondenceSystem.Implementations;

namespace CorrespondenceSystem.Interfaces
{
    public interface IServiceBase
    {
        List<Entity<int>> GetAllEntities();
        Entity<int> GetEntity(int id);
        void CreateEntity(Entity<int> entity);
        void UpdateEntity(Entity<int> entity);
        void DeleteEntity(int id);
    }
}