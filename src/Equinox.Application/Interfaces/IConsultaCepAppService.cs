using Equinox.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equinox.Application.Interfaces
{
    public interface IConsultaCepAppService : IDisposable
    {
        Task<ConsultaCepViewModel> ConsultarCep(ConsultaCepInViewModel model);
    }
}
