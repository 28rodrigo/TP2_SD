using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP2_SD
{
    public class AdminService : ClienteAdministradorP.ClienteAdministradorPBase
    {
        private readonly ILogger<AdminService> _loggerA;
        public AdminService(ILogger<AdminService> loggerA)
        {
            _loggerA = loggerA;
        }

        public override Task<ArquivoResposta> Arquivar(ArquivoInput request, ServerCallContext context)
        {
            return Task.FromResult(new ArquivoResposta
            {
                EstadoArquivo = ""
            });
        }
        public override Task<ConsultarResposta> Consultar(ConsultarInput request, ServerCallContext context)
        {
            return Task.FromResult(new ConsultarResposta
            {
                Estado = true,
                Utilizadores = {},
                Apostas = {}
            });
        }
    }
}
