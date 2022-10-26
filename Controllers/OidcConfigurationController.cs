using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer4WebApp.Controllers
{
    [ApiController]
    public class OidcConfigurationController : ControllerBase
    {
        private readonly IClientRequestParametersProvider _clientRequestParametersProvider;

        public OidcConfigurationController(IClientRequestParametersProvider clientRequestParametersProvider)
        {
            _clientRequestParametersProvider = clientRequestParametersProvider;
        }

        [HttpGet("_configuration/{clientId}")]
        public IActionResult GetClientRequestParameters([FromRoute] string clientId)
        {
            var parameters = _clientRequestParametersProvider.GetClientParameters(HttpContext, clientId);
            return Ok(parameters);
        }
    }
}
