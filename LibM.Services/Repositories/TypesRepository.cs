using LibM.Contracts;
using LibM.Contracts.NewTypes;
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
            return context.Types.Select(t => new TypesViewDto
            {
                Name = t.Name
            }).ToList();
        }

        public List<OptionDto> GetTypesAsOptions()
        {
            return context.Types.Select(t => new OptionDto
            {
                Code = t.Id,
                Label = t.Name
            }).ToList();
        }

        public bool CreateNewTypes(NewAddTypesViewDto newAddTypesViewDto)
        {
            var type = new Data.Entities.Definition.Type()
            {
                Name = newAddTypesViewDto.Name,
            };
            context.Add(type);
            var result = context.SaveChanges();
            return result == 1;
        }
    }
}