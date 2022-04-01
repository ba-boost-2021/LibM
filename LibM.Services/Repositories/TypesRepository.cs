using LibM.Contracts.Types;
using LibM.Data.Access;
using LibM.Data.Access.Managers;

namespace LibM.Services.Repositories
{
    public class TypesRepository
    {
        private readonly LibMDbContext context;

        public TypesRepository()
        {
            context = context = ContextManager.GetDbContext();
        }
        public List<TypesViewDto> GetAllTypes()
        {
            var types = context.Types.Select(t => new TypesViewDto
            {
                Name = t.Name
            }).ToList();
            return types;
        }
    }
}