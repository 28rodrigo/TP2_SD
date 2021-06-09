using Google.Protobuf.Collections;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using SD_TP2.Database;
using SD_TP2.Models;

namespace SD_TP2
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

        /// <summary>
        /// Esta fun��o � respons�vel por registar uma aposta na base de dados 
        /// </summary>
        /// <param> <c>request</c> s�o os parametros de Entrada enviados pelo cliente -> Tipo Aposta </param>
        /// <param> <c>context</c> � o contexto do Server-Side Call </param>
        /// <returns>Retorna o Estado (True/False) da opera��o: True -> Opera��o efetuada com sucesso ; False -> Opera��o falhou</returns>
        public override Task<EstadoAposta>RegistarAposta(Aposta request, ServerCallContext context)
        {
            try
            {   //Transformar os Arrays de inteiros (Numeros e Estrelas) recebidos no parametro de entrada para String para serem armazenados na BD.
                string NumerosReceived = request.Numeros[0] + "," + request.Numeros[1] + "," + request.Numeros[2] + "," + request.Numeros[3] + "," + request.Numeros[4];
                string EstrelasReceived = request.Estrelas[0] + "," + request.Estrelas[1];
                
                //Guardar dados na BD e retornar Estado.
                RegistoAposta NovaAposta = new RegistoAposta { NIF = request.NumeroApostador, Data = (request.DataAposta.ToDateTime()), Numeros=NumerosReceived,Estrelas=EstrelasReceived, Arquivada = false, Premio = 0 };
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
        /// <summary>
        /// Esta fun��o � respons�vel por obter o hist�rico de Apostas de um determinado Utilizador(NIF)
        /// </summary>
        /// <param> <c>request</c> s�o os parametros de Entrada enviados pelo cliente -> Tipo PedidoHistorico </param>
        /// <param> <c>context</c> � o contexto do Server-Side Call </param>
        /// <returns> Retorna o estado da opera��o(true/false) e toda a informa��o das Apostas de um determinado Utilizador </returns>
        public override Task<ResultadoHistorico> HistoricoApostas(PedidoHistorico request, ServerCallContext context)
        {
            //Consultar Apostas com determinado NIF
            var ApostasNif = _dbcontext.Apostas.Where(element => element.NIF == request.NumeroApostador).ToList();
            if (ApostasNif != null)
            {
                //Para retornar a informa��o ao cliente � necess�rio fazer a "tradu��o" da informa��o: List-> RepeatableField
                RepeatedField<Historico> ApostasNifConverted = new RepeatedField<Historico>();
                ApostasNif.ForEach((element) =>
                {
                    ApostasNifConverted.Add(new Historico
                    {
                        NumeroAposta = element.RegistoApostaId,
                        DataAposta = Timestamp.FromDateTime(element.Data.ToUniversalTime()),
                        Estrelas = element.Estrelas,
                        Numeros = element.Numeros,
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
