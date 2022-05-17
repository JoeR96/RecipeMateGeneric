using RecipeMateModels.Models;

namespace RecipeMatePersistence.Repository
{
    public interface IRepository<T> where T : Entity
    {
        public IEnumerable<T> GetAll();
        public T GetById(object id);
        public void Insert(T obj);
        public void Update(T obj);
        public void Delete(object id);
        public void Save();
    }
}