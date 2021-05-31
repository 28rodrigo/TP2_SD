using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP2_SD
{
    public class ClientService : ClienteUtilizador.ClienteUtilizadorBase
    {
        private readonly ILogger<ClientService> _logger;
        public ClientService(ILogger<ClientService> logger)
        {
            _logger = logger;
        }

        public override Task<EstadoAposta>RegistarAposta(Aposta request, ServerCallContext context)
        {
            return Task.FromResult(new EstadoAposta
            {
                Estado = true
            });
        }
    }
}
