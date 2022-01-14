namespace PetShop.Business.Businesses.Interfaces
{
    public interface IDomainBusiness<Model, Dto> where Model : BaseModel where Dto : BaseDto
    {
        public Task<Dto> Get(int id);
        public Task<List<Dto>> Get();
        public Task<List<Dto>> Get(Expression<Func<Model, bool>> expression);
        public Task<int> GetCount();
        public Task<Dto> GetFirstOrDefault(Expression<Func<Model, bool>> expression);
        public Task<Dto> GetSingleOrDefault(Expression<Func<Model, bool>> expression);
        public Task<bool> Create(Dto entity);
        public Task<bool> CreateRange(List<Dto> entities);
        public Task<bool> Remove(int id);
        public Task<bool> Remove(Dto entity);
        public Task<bool> RemoveRange(List<Dto> entities);
        public Task<bool> Update(Dto entity);
    }
}
