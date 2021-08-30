using Equinox.Application.Interfaces;
using Equinox.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Equinox.Services.Api.Controllers
{
    public class ConsultaCepController : ApiController
    {
        private readonly IConsultaCepAppService _consultaCepAppService;

        public ConsultaCepController(IConsultaCepAppService consultaCepAppService)
        {
            _consultaCepAppService = consultaCepAppService;
        }

        [AllowAnonymous]
        [HttpPost("consultar-cep/")]
        public async Task<ConsultaCepViewModel> ConsultarCep([FromBody]ConsultaCepInViewModel model)
        {
            return await _consultaCepAppService.ConsultarCep(model);
        }

    }
}
