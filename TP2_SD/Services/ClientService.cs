using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP2_SD
{
    public class ClientService : ClienteUtilizadorP.ClienteUtilizadorPBase
    {
        private readonly ILogger<ClientService> _loggerU;
        public ClientService(ILogger<ClientService> loggerU)
        {
            _loggerU = loggerU;
        }

        public override Task<EstadoAposta>RegistarAposta(Aposta request, ServerCallContext context)
        {
            return Task.FromResult(new EstadoAposta
            {
                Estado = true
            });
        }

        public override Task<ResultadoHistorico> HistoricoApostas(PedidoHistorico request, ServerCallContext context)
        {
            return Task.FromResult(new ResultadoHistorico
            {
                Estado = true,
                HistoricoApostas = {}
            });
        }
    }
}
