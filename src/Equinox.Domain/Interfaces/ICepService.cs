using Equinox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equinox.Domain.Interfaces
{
    public interface ICepService
    {
        public ConsultaCep ConsultarCep(string cep);
    }
}
