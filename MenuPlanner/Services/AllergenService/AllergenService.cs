﻿
namespace MenuPlanner.Services.AllergenService
{
    public class AllergenService(DataContext context, IMapper mapper) : IAllergenService
    {
        private readonly DataContext _context = context;
        private readonly IMapper _mapper = mapper;

        public async Task<int> Count(LifecycleState state)
            => await _context.Allergens.Where(a => a.State == state).CountAsync();

        public async Task<ServiceResponse<List<AllergenDisplayDTO>>> GetAll()
        {
            List<Allergen>? allergens = await _context.Allergens.ToListAsync();
            return new ServiceResponse<List<AllergenDisplayDTO>>
            {
                Data = _mapper.Map<List<AllergenDisplayDTO>>(allergens),
                Success = allergens != null,
                Message = allergens != null
                    ? "A list of all allergens was successfully retrieved."
                    : "No allergens were found."
            };
        }

        public async Task<ServiceResponse<AllergenDisplayDTO>> GetBySlug(string slug)
        {
            Allergen? allergen = await _context.Allergens
                .FirstOrDefaultAsync(r => r.Slug == slug);
            return new ServiceResponse<AllergenDisplayDTO>
            {
                Data = _mapper.Map<AllergenDisplayDTO>(allergen),
                Success = allergen != null,
                Message = allergen != null
                    ? "The allergen was successfully retrieved."
                    : "Allergen not found."
            };
        }
    }
}
