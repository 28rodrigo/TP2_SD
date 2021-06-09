using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SD_TP2;
using SD_TP2.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_TP2
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
        /// <summary>
        /// Esta função é responsável por Arquivar todas as Apostas Ativas
        /// </summary>
        /// <param> <c>request</c> é um parametro de entrada Vazio -> Tipo Empty </param>
        /// <param> <c>context</c> é o contexto do Server-Side Call </param>
        /// <returns>Retorna o Estado (True/False) da operação: True -> Operação efetuada com sucesso ; False -> Operação falhou</returns>
        public override Task<ArquivoResposta> Arquivar(Empty request, ServerCallContext context)
        {
            try
            {
                //Atualizar os registos com o parametro Arquivado false para true
                var ApostasAtivas = _dbcontext.Apostas.Where(element => element.Arquivada == false).ToList();
                ApostasAtivas.ForEach(ele => {
                    ele.Arquivada = true;
                    _dbcontext.Apostas.Update(ele);
                });
                _dbcontext.SaveChanges();
                if(ApostasAtivas.Count==0)
                {
                    return Task.FromResult(new ArquivoResposta
                    {
                        EstadoArquivo = false

                    }); ;
                }
                else
                {
                    return Task.FromResult(new ArquivoResposta
                    {
                        EstadoArquivo = true

                    }); ;
                }
            }
            catch
            {
                return Task.FromResult(new ArquivoResposta
                {
                    EstadoArquivo = false
                }); ;
            }
            

        }
        /// <summary>
        /// Esta função é responsável por consultar todos os Utilizadores que já registaram apostas e tambem de toda a informação das 
        /// apostas que estão em sorteio
        /// </summary>
        /// <param> <c>request</c> é um parametro de entrada Vazio -> Tipo Empty </param>
        /// <param> <c>context</c> é o contexto do Server-Side Call </param>
        /// <returns>Retorna o estado(True/False) da operação e tambem a informação de todos os Utilizadores e das apostas ativas para sorteio</returns>
        public override Task<ConsultarResposta> Consultar(Empty request, ServerCallContext context)
        {
            //Consultar apostas ativas
            var Apostas = _dbcontext.Apostas.Where(element => element.Arquivada == false).ToList();
            if (Apostas.Count != 0 && Apostas != null)
            {
                //Para retornar a informação ao cliente é necessário fazer a "tradução" da informação: List -> RepeatableField
                RepeatedField<Historico> ApostasConvertidas = new RepeatedField<Historico>();

                Apostas.ForEach((element) =>
                {
                    ApostasConvertidas.Add(new Historico
                    { 
                        NumeroApostador = element.NIF,
                        NumeroAposta = element.RegistoApostaId,
                        Numeros = element.Numeros,
                        Estrelas = element.Estrelas,
                        DataAposta = Timestamp.FromDateTime(element.Data.ToUniversalTime()),
                        Premio = element.Premio
                    });

                });
                return Task.FromResult(new ConsultarResposta
                {
                    Estado = true,
                    Apostas = { ApostasConvertidas }

                });
            }
            else
            {
                return Task.FromResult(new ConsultarResposta
                {
                    Estado = false,
                    Apostas = {  }

                });
            }
        }
    }
}
