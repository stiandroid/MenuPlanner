namespace MenuPlanner.Services.NutrientService
{
    public class NutrientService(DataContext context, IMapper mapper) : INutrientService
    {
        private readonly DataContext _context = context;
        private readonly IMapper _mapper = mapper;

        public async Task<int> Count(LifecycleState state)
            => await _context.Nutrients.Where(n => n.State == state).CountAsync();

        public async Task<ServiceResponse<List<NutrientDisplayDTO>>> GetAll()
        {
            List<Nutrient>? nutrients = await _context.Nutrients.ToListAsync();
            return new ServiceResponse<List<NutrientDisplayDTO>>
            {
                Data = _mapper.Map<List<NutrientDisplayDTO>>(nutrients),
                Success = nutrients != null,
                Message = nutrients != null
                    ? "A list of all nutrients was successfully retrieved."
                    : "No nutrients were found."
            };
        }

        public async Task<ServiceResponse<NutrientDisplayDTO>> GetBySlug(string slug)
        {
            Nutrient? nutrient = await _context.Nutrients
                .FirstOrDefaultAsync(r => r.Slug == slug);
            return new ServiceResponse<NutrientDisplayDTO>
            {
                Data = _mapper.Map<NutrientDisplayDTO>(nutrient),
                Success = nutrient != null,
                Message = nutrient != null
                    ? "The nutrient was successfully retrieved."
                    : "Nutrient not found."
            };
        }

        public async Task<ServiceResponse<NutrientEditDTO>> Edit(NutrientEditDTO nutrient)
        {
            Nutrient? dbNutrient;
            if (nutrient.Id == null) // => CREATE
            {
                dbNutrient = await Create(nutrient);
            }
            else // => UPDATE
            {
                dbNutrient = await Update(nutrient);
            }
            return new ServiceResponse<NutrientEditDTO>
            {
                Data = _mapper.Map<NutrientEditDTO>(dbNutrient),
                Success = dbNutrient != null,
                Message = dbNutrient != null
                    ? $"The nutrient was successfully {(nutrient.Id == null ? "created" : "updated")}."
                    : nutrient.Id == null
                        ? "Nutrient could not be created."
                        : "Nutrient not found."
            };
        }

        public async Task<ServiceResponse<List<NutrientDisplayDTO>>> Delete(int id)
        {
            try
            {
                Nutrient? dbNutrient = await _context.Nutrients.FindAsync(id);
                if (dbNutrient != null)
                {
                    _context.Remove(dbNutrient);
                    await _context.SaveChangesAsync();
                }
                var remainingNutrients = await GetAll();
                return new ServiceResponse<List<NutrientDisplayDTO>>()
                {
                    Data = remainingNutrients.Data,
                    Success = dbNutrient != null,
                    Message = dbNutrient != null
                        ? "Nutrient was deleted."
                        : "Nutrient not found."
                };
            }
            catch (Exception ex)
            {
                var allNutrients = await GetAll();
                return new ServiceResponse<List<NutrientDisplayDTO>>()
                {
                    Data = allNutrients.Data,
                    Success = false,
                    Message = $"An error occured: {ex.Message}"
                };
            }
        }

        private async Task<Nutrient?> Create(NutrientEditDTO nutrient)
        {
            Nutrient newNutrient = _mapper!.Map<Nutrient>(nutrient);
            _context.Add(newNutrient);
            await _context.SaveChangesAsync();
            return newNutrient;
        }

        private async Task<Nutrient?> Update(NutrientEditDTO nutrient)
        {
            Nutrient? dbNutrient = await _context.Nutrients.FindAsync(nutrient.Id);
            _mapper.Map(source: nutrient, destination: dbNutrient);
            await _context.SaveChangesAsync();
            return dbNutrient;
        }
    }
}
