using GqlDemo.Server.Data;
using HotChocolate;
using HotChocolate.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GqlDemo.Server.Mutations
{
    public class ShareMutation
    {
        [UseDbContext(typeof(MyContext))]
        public async Task<ChangeValuePayload> ChangeValueAsync(ChangeValueInput input, [ScopedService] MyContext dbcontext)
        {
            var share = await dbcontext.Shares
                .Include(x => x.Industry)
                .SingleAsync(x => x.Id == input.Id);

            share.Value *= (decimal)(100 + input.Percentage)/100;

            await dbcontext.SaveChangesAsync();

            return new ChangeValuePayload(share);
        }
    }
}
