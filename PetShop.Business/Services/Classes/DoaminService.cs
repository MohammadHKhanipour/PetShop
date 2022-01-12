using PetShop.Business.Services.Interfaces;
using PetShop.Data.Adapters;
using PetShop.Data.Repositories;
using System.Linq.Expressions;

namespace PetShop.Business.Services.Classes
{
    public class DoaminService<Model, Dto> : IDomainService<Model, Dto> where Model : BaseModel where Dto : BaseDto
    {
        private readonly IQueryRepository<Model> _queryRepository;
        private readonly ICommandRepository<Model> _commandRepository;
        private readonly IBaseAdapter<Model, Dto> _baseAdapter;

        public DoaminService(IQueryRepository<Model> queryRepository, ICommandRepository<Model> commandRepository, IBaseAdapter<Model, Dto> baseAdapter)
        {
            _queryRepository = queryRepository;
            _commandRepository = commandRepository;
            _baseAdapter = baseAdapter;
        }

        public async Task<Dto> GetAsync(int id)
        {
            var model = await _queryRepository.GetAsync(id);
            return _baseAdapter.GetDto(model);
        }

        public async Task<List<Dto>> GetAsync()
        {
            var models = await _queryRepository.GetAsync();
            return _baseAdapter.GetDtos(models).ToList();
        }

        public async Task<List<Dto>> GetAsync(Expression<Func<Model, bool>> expression)
        {
            var models = await _queryRepository.GetAsync(expression);
            return _baseAdapter.GetDtos(models).ToList();
        }

        public async Task<int> GetCountAsync()
        {
            return await _queryRepository.GetCountAsync();
        }

        public async Task<Dto> GetFirstOrDefaultAsync(Expression<Func<Model, bool>> expression)
        {
            var model = await _queryRepository.GetFirstOrDefaultAsync(expression);
            return _baseAdapter.GetDto(model);
        }

        public async Task<Dto> GetSingleOrDefaultAsync(Expression<Func<Model, bool>> expression)
        {
            var model = await _queryRepository.GetSingleOrDefaultAsync(expression);
            return _baseAdapter.GetDto(model);
        }

        public async Task<bool> AddAsync(Model entity)
        {
            return await _commandRepository.AddAsync(entity);
        }

        public async Task<bool> AddRangeAsync(List<Model> entities)
        {
            return await _commandRepository.AddRangeAsync(entities);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _commandRepository.DeleteAsync(id);
        }

        public async Task<bool> DeleteAsync(Model entity)
        {
            return await _commandRepository.DeleteAsync(entity);
        }

        public async Task<bool> DeleteRangeAsync(List<Model> entities)
        {
            return await _commandRepository.DeleteRangeAsync(entities);
        }

        public async Task<bool> UpdateAsync(Model entity)
        {
            return await _commandRepository.UpdateAsync(entity);
        }
    }
}
