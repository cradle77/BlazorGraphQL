using GqlDemo.Server.Data;
using GqlDemo.Server.Subscriptions;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Subscriptions;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GqlDemo.Server.Mutations
{
    public class ShareMutation
    {
        [UseDbContext(typeof(MyContext))]
        public async Task<ChangeValuePayload> ChangeValueAsync(ChangeValueInput input, 
            MyContext dbcontext,
            [Service] ITopicEventSender eventSender)
        {
            var share = await dbcontext.Shares
                .Include(x => x.Industry)
                .SingleAsync(x => x.Id == input.Id);

            share.Value *= (decimal)(100 + input.Percentage)/100;

            await dbcontext.SaveChangesAsync();

            await eventSender.SendAsync(
                nameof(SharesSubscription.OnShareValueChangedAsync),
                share.Id);

            await eventSender.SendAsync(
                share.Industry.Name,
                share.Id);

            return new ChangeValuePayload(share);
        }
    }
}
