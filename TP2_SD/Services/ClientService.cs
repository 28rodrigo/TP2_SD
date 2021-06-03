using Google.Protobuf.Collections;
using Grpc.Core;
using TP2_SD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP2_SD.Database;
using Google.Protobuf.WellKnownTypes;

namespace TP2_SD
{
    public class ClientService : ClienteUtilizadorP.ClienteUtilizadorPBase
    {
        private readonly ILogger<ClientService> _loggerU;
        private readonly ChavesContext _dbcontext;
        public ClientService(ILogger<ClientService> loggerU, ChavesContext dbcontext)
        {
            _loggerU = loggerU;
            _dbcontext = dbcontext;
        }

        public override Task<EstadoAposta>RegistarAposta(Aposta request, ServerCallContext context)
        {
            try
            {
                string NumerosReceived = request.Numeros[0] + "," + request.Numeros[1] + "," + request.Numeros[2] + "," + request.Numeros[3] + "," + request.Numeros[4];
                string EstrelasReceived = request.Estrelas[0] + "," + request.Estrelas[1];
                RegistoChave NovaChave = new RegistoChave { Numeros = NumerosReceived, Estrelas = EstrelasReceived };
                var dbChavereturn = _dbcontext.Chaves.Add(NovaChave);
                _dbcontext.SaveChanges();
                int IdChave = NovaChave.ChaveId;
                RegistoAposta NovaAposta = new RegistoAposta { NIF = request.NumeroApostador, Data = DateTime.UtcNow, Chave = NovaChave, Arquivada = false, Premio = 0 };
                _dbcontext.Apostas.Add(NovaAposta);
                _dbcontext.SaveChanges();
                return Task.FromResult(new EstadoAposta
                {
                    Estado = true
                });
            }
            catch
            {
                return Task.FromResult(new EstadoAposta
                {
                    Estado = false
                });
            }
        }

        public override Task<ResultadoHistorico> HistoricoApostas(PedidoHistorico request, ServerCallContext context)
        {
            var ApostasNif = _dbcontext.Apostas.Include("Chave").Where(element => element.NIF == request.NumeroApostador).ToList();
            if (ApostasNif != null)
            {
                RepeatedField<Historico> ApostasNifConverted = new RepeatedField<Historico>();
                ApostasNif.ForEach((element) =>
                {
                    ApostasNifConverted.Add(new Historico
                    {
                        NumeroAposta = element.RegistoApostaId,
                        DataAposta = Timestamp.FromDateTime(element.Data.ToUniversalTime()),
                        Estrelas = element.Chave.Estrelas,
                        Numeros = element.Chave.Numeros,
                        Premio = element.Premio
                    });
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
