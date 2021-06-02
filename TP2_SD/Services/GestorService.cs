using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP2_SD
{
    public class GestorService : ClienteGestorSorteioP.ClienteGestorSorteioPBase
    {
        private readonly ILogger<GestorService> _loggerG;
        public GestorService(ILogger<GestorService> loggerG)
        {
            _loggerG = loggerG;
        }

        public override Task<EstadoResultado>GerirSorteio(Resultado request, ServerCallContext context)
        {
            return Task.FromResult(new EstadoResultado
            {
                Estado = true,
                ApostasVencedoras = {}
            });
        }
    }
}
