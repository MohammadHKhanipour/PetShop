using PetShop.Business.Businesses.Interfaces;

namespace PetShop.Business.Businesses.Classes
{
    public class DomainBusiness<Model, Dto> : IDomainBusiness<Model, Dto> where Model : BaseModel where Dto : BaseDto
    {
        private readonly IDomainService<Model, Dto> _domainService;
        private readonly IBaseAdapter<Model, Dto> _baseAdapter;

        public DomainBusiness(IDomainService<Model, Dto> domainService, IBaseAdapter<Model, Dto> baseAdapter)
        {
            _domainService = domainService;
            _baseAdapter = baseAdapter;
        }

        public async Task<Dto> Get(int id)
            => await _domainService.GetAsync(id);

        public async Task<List<Dto>> Get()
            => await _domainService.GetAsync();

        public async Task<List<Dto>> Get(Expression<Func<Model, bool>> expression)
            => await _domainService.GetAsync(expression);

        public async Task<int> GetCount()
            => await _domainService.GetCountAsync();

        public async Task<Dto> GetFirstOrDefault(Expression<Func<Model, bool>> expression)
            => await _domainService.GetFirstOrDefaultAsync(expression);

        public async Task<Dto> GetSingleOrDefault(Expression<Func<Model, bool>> expression)
            => await _domainService.GetSingleOrDefaultAsync(expression);

        public async Task<bool> Create(Dto entity)
        {
            var model = _baseAdapter.GetModel(entity);
            return await _domainService.AddAsync(model);
        }

        public async Task<bool> CreateRange(List<Dto> entities)
        {
            List<Model> models = (List<Model>)_baseAdapter.GetModels(entities);
            return await _domainService.AddRangeAsync(models);
        }

        public async Task<bool> Remove(int id)
            => await _domainService.DeleteAsync(id);

        public async Task<bool> Remove(Dto entity)
        {
            var model = _baseAdapter.GetModel(entity);
            return await _domainService.DeleteAsync(model);
        }

        public async Task<bool> RemoveRange(List<Dto> entities)
        {
            List<Model> models = (List<Model>)_baseAdapter.GetModels(entities);
            return await _domainService.DeleteRangeAsync(models);
        }

        public async Task<bool> Update(Dto entity)
        {
            var model = _baseAdapter.GetModel(entity);
            return await _domainService.UpdateAsync(model);
        }
    }
}
