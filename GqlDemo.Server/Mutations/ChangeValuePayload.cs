using GqlDemo.Server.Data;

namespace GqlDemo.Server.Mutations
{
    public class ChangeValuePayload
    {
        public ChangeValuePayload(Share share)
        {
            this.Share = share;
        }

        public Share Share { get; }
    }
}
