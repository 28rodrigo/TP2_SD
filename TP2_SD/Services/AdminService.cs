using Google.Protobuf.Collections;
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
    public class AdminService : ClienteAdministradorP.ClienteAdministradorPBase
    {
        private readonly ILogger<AdminService> _loggerA;
        private readonly ChavesContext _dbcontext;
        public AdminService(ILogger<AdminService> loggerA, ChavesContext dbcontext)
        {
            _loggerA = loggerA;
            _dbcontext = dbcontext;
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
            var Jogadores = _dbcontext.Apostas.Include("Chave").ToList();
            if (Jogadores != null)
            {
                RepeatedField<Vencedor> ApostadoresConvertidos = new RepeatedField<Vencedor>();
            Jogadores.ForEach((element) =>
            {
                ApostadoresConvertidos.Add(new Vencedor
                {
                    NIF = element.NIF,
                });
            });
            return Task.FromResult(new ConsultarResposta
            {
                Estado = true,
                Utilizadores = {},
                Apostas = {}
            });
        }
    }
}
