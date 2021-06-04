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
        /// <summary>
        /// Esta fun��o � respons�vel por Arquivar todas as Apostas Ativas
        /// </summary>
        /// <param> <c>request</c> � um parametro de entrada Vazio -> Tipo Empty </param>
        /// <param> <c>context</c> � o contexto do Server-Side Call </param>
        /// <returns>Retorna o Estado (True/False) da opera��o: True -> Opera��o efetuada com sucesso ; False -> Opera��o falhou</returns>
        public override Task<ArquivoResposta> Arquivar(Empty request, ServerCallContext context)
        {
            try
            {
                //Atualizar os registos com o parametro Arquivado false para true
                var ApostasAtivas = _dbcontext.Apostas.Include("Chave").Where(element => element.Arquivada == false).ToList();
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
        /// Esta fun��o � respons�vel por consultar todos os Utilizadores que j� registaram apostas e tambem de toda a informa��o das 
        /// apostas que est�o em sorteio
        /// </summary>
        /// <param> <c>request</c> � um parametro de entrada Vazio -> Tipo Empty </param>
        /// <param> <c>context</c> � o contexto do Server-Side Call </param>
        /// <returns>Retorna o estado(True/False) da opera��o e tambem a informa��o de todos os Utilizadores e das apostas ativas para sorteio</returns>
        public override Task<ConsultarResposta> Consultar(Empty request, ServerCallContext context)
        {
            //Consultar todos as apostas com NIF diferente
            var ApostasUsers = _dbcontext.Apostas.Include("Chave").ToList().GroupBy(elemento => elemento.NIF).Distinct().ToList();
            if (ApostasUsers.Count != 0 && ApostasUsers != null)
            {
                //Para retornar a informa��o ao cliente � necess�rio fazer a "tradu��o" da informa��o: List -> RepeatableField
                RepeatedField<Utilizador> ApostadoresConvertidos = new RepeatedField<Utilizador>();
                RepeatedField<Historico> ApostasConvertidas = new RepeatedField<Historico>();
                ApostasUsers.ForEach((elem) =>
                {
                    ApostadoresConvertidos.Add(new Utilizador { NIF = elem.Key });
                });

                //Consultar apostas ativas
                var Apostas = _dbcontext.Apostas.Include("Chave").Where(element => element.Arquivada == false).ToList();
                Apostas.ForEach((element) =>
                {
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
