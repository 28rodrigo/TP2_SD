using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP2_SD.Database;

namespace TP2_SD
{
    public class GestorService : ClienteGestorSorteioP.ClienteGestorSorteioPBase
    {
        private readonly ILogger<GestorService> _loggerG;
        private readonly ChavesContext _context;
        public GestorService(ILogger<GestorService> loggerG,ChavesContext context)
        {
            _loggerG = loggerG;
            _context = context;
        }

        public override Task<EstadoResultado>GerirSorteio(Resultado request, ServerCallContext context)
        {
            string NumerosReceived = request.Numeros[0] + "," + request.Numeros[1] + "," + request.Numeros[2] + "," + request.Numeros[3] + "," + request.Numeros[4];
            string EstrelasReceived = request.Estrelas[0] + "," + request.Estrelas[1];
            var apostasVencedoras =  _context.Apostas.Include("Chaves")
                .Where(element => element.Chave.Numeros == NumerosReceived)
                .Where(element => element.Chave.Estrelas == EstrelasReceived)
                .ToList();


            return Task.FromResult(new EstadoResultado
            {
                Estado = true,
                ApostasVencedoras = {}
            });
        }
    }
}
