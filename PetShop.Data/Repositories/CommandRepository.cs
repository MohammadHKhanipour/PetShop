using PetShop.Data.Context;

namespace PetShop.Data.Repositories
{
    public class CommandRepository<Model> : ICommandRepository<Model> where Model : BaseModel
    {
        private readonly PetShopDbContext _context;

        public CommandRepository(PetShopDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAsync(Model entity)
        {
            try
            {
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> AddRangeAsync(List<Model> entities)
        {
            try
            {
                await _context.AddRangeAsync(entities);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var model = _context.Set<Model>().FindAsync(id);
                if (model == null)
                    return false;
                _context.Remove(model);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(Model entity)
        {
            try
            {
                _context.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteRangeAsync(List<Model> entities)
        {
            try
            {
                _context.RemoveRange(entities);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(Model entity)
        {
            try
            {
                _context.Update(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
