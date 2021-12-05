using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace GqlDemo.Gateway
{
    public class ForwardTokenHandler : DelegatingHandler
    {
        private IHttpContextAccessor _contextAccessor;

        public ForwardTokenHandler(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpContext context = _contextAccessor.HttpContext;

            if (context.Request.Headers.ContainsKey("Authorization"))
            {
                request.Headers.Authorization =
                    AuthenticationHeaderValue.Parse(
                        context.Request.Headers["Authorization"]
                            .ToString());
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}
