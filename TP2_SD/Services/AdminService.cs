using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
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
            try
            {
                var ApostasAtivas = _dbcontext.Apostas.Include("Chave").Where(element => element.Arquivada == false).ToList();
                ApostasAtivas.ForEach(ele => {
                    ele.Arquivada = true;
                    _dbcontext.Apostas.Update(ele);
                });
                _dbcontext.SaveChanges();
                return Task.FromResult(new ArquivoResposta
                {
                    EstadoArquivo = true

                }); ;
            }
            catch
            {
                return Task.FromResult(new ArquivoResposta
                {
                    EstadoArquivo = false

                }); ;
            }
            

        }
        public override Task<ConsultarResposta> Consultar(ConsultarInput request, ServerCallContext context)
        {
            var Apostas = _dbcontext.Apostas.Include("Chave").Where(element=>element.Arquivada==false).ToList();
            if (Apostas != null)
            {
                RepeatedField<Utilizador> ApostadoresConvertidos = new RepeatedField<Utilizador>();
                RepeatedField<Historico> ApostasConvertidas = new RepeatedField<Historico>();
                Apostas.ForEach((element) =>
                {
                    ApostadoresConvertidos.Add(new Utilizador { NIF = element.NIF });

                    ApostasConvertidas.Add(new Historico
                    {
                        NumeroAposta = element.RegistoApostaId,
                        Numeros = element.Chave.Numeros,
                        Estrelas = element.Chave.Estrelas,
                        DataAposta = Timestamp.FromDateTime(element.Data.ToUniversalTime()),
                        Premio = element.Premio

                    });

                });


                return Task.FromResult(new ConsultarResposta
                {
                    Estado = true,
                    Utilizadores = { ApostadoresConvertidos },
                    Apostas = { ApostasConvertidas }

                });
            }
            else
            {
                return Task.FromResult(new ConsultarResposta
                {
                    Estado = false,
                    Utilizadores = {  },
                    Apostas = {  }

                });
            }
        }
    }
}
