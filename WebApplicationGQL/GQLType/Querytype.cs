using Microsoft.EntityFrameworkCore;
using WebApplicationGQL.Data;

namespace WebApplicationGQL
{
    public class QueryType
    {
        public async Task<List<Cake>> AllCakesAsync([Service] ApplicationDbContext context)
        {
            return await context.Cake.ToListAsync();
        }
    }
}

