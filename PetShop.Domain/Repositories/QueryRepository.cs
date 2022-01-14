namespace PetShop.Domain.Repositories
{
    public class QueryRepository<Model> : IQueryRepository<Model> where Model : BaseModel
    {
        private readonly PetShopDbContext _context;

        public QueryRepository(PetShopDbContext context)
        {
            _context = context;
        }

        public async Task<Model> GetAsync(int id)
        {
            return await _context.Set<Model>().FindAsync(id);
        }

        public async Task<List<Model>> GetAsync()
        {
            return await _context.Set<Model>().ToListAsync();
        }

        public async Task<List<Model>> GetAsync(Expression<Func<Model, bool>> expression)
        {
            return await _context.Set<Model>().Where(expression).ToListAsync();
        }

        public async Task<int> GetCountAsync()
        {
            return await _context.Set<Model>().CountAsync();
        }

        public async Task<Model> GetFirstOrDefaultAsync(Expression<Func<Model, bool>> expression)
        {
            return await _context.Set<Model>().Where(expression).FirstOrDefaultAsync();
        }

        public async Task<Model> GetSingleOrDefaultAsync(Expression<Func<Model, bool>> expression)
        {
            return await _context.Set<Model>().Where(expression).SingleOrDefaultAsync();
        }
    }
}
