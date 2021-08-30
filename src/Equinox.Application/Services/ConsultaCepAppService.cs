using AutoMapper;
using Equinox.Application.Interfaces;
using Equinox.Application.ViewModels;
using Equinox.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace Equinox.Application.Services
{
    public class ConsultaCepAppService : IConsultaCepAppService
    {
        private readonly ICepService _cepService;
        private readonly IMapper _mapper;

        public ConsultaCepAppService(ICepService cepService, IMapper mapper)
        {
            _cepService = cepService;
            _mapper = mapper;
        }

        public async Task<ConsultaCepViewModel> ConsultarCep(ConsultaCepInViewModel model)
        {
            await Task.Yield();
            return _mapper.Map<ConsultaCepViewModel>(_cepService.ConsultarCep(model.Cep));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
