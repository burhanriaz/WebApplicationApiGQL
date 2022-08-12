using WebApplicationGQL.Data;

namespace WebApplicationGQL.GQLType
{
    public class MutationsType
    {
        public async Task<Cake> saveCakeAsync([Service] ApplicationDbContext context ,Cake newCake)
        {
            context.Cake.Add(newCake);
           await  context.SaveChangesAsync();
            return newCake;
        }


        public async Task<Cake> updateCakeAsync([Service] ApplicationDbContext context, Cake updateCake)
        {
            context.Cake.Update(updateCake);
            await context.SaveChangesAsync();
            return updateCake;
        }
        
        public async Task<string> deleteCakeAsync([Service] ApplicationDbContext context, int id)
        {
            var deletecake = await context.Cake.FindAsync(id);
            if (deletecake != null)
            {
                context.Cake.Remove(deletecake);
                await context.SaveChangesAsync();
                return "Record Deleted";
            }
            else
            {
                return "Invalide Opreations";
            }
          
        }
    }
}
