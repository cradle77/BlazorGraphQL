﻿using GqlDemo.Server.Data;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace GqlDemo.Server.Subscriptions
{
    public class SharesSubscription
    {
        [Subscribe]
        [Topic]
        [UseDbContext(typeof(MyContext))]
        public Task<Share> OnShareValueChangedAsync(
            [EventMessage] int shareId,
            MyContext dbcontext,
            CancellationToken cancellationToken)
        {
            return dbcontext.Shares
                .Include(x => x.Industry)
                .SingleAsync(x => x.Id == shareId);
        }
    }
}
