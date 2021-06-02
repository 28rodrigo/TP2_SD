using Google.Protobuf.Collections;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP2_SD.Database;

namespace TP2_SD
{
    public class ClientService : ClienteUtilizadorP.ClienteUtilizadorPBase
    {
        private readonly ILogger<ClientService> _loggerU;
        private readonly ChavesContext _dbcontext;
        public ClientService(ILogger<ClientService> loggerU, ChavesContext dbcontext)
        {
            _loggerU = loggerU;
            _dbcontext = new ChavesContext();
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
            var ApostasNif = _dbcontext.Apostas.Where(element => element.NIF == request.NumeroApostador).ToList();
            if(ApostasNif!=null)
            {
                RepeatedField<string> ApostasNifConverted = new RepeatedField<string>();
                ApostasNif.ForEach((element) =>
                {
                    ApostasNifConverted.Add(element.Chave.Numeros + ";" + element.Chave.Estrelas);
                });
                return Task.FromResult(new ResultadoHistorico
                {
                    Estado = true,
                    HistoricoApostas = { ApostasNifConverted }
                });
            }
            else
            {
                return Task.FromResult(new ResultadoHistorico
                {
                    Estado = false,
                    HistoricoApostas = { }
                });
            }
        }
    }
}
