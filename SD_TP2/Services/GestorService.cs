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
using SD_TP2.AuxClasses;

namespace SD_TP2
{
    public class GestorService : ClienteGestorSorteioP.ClienteGestorSorteioPBase
    {
        private readonly ILogger<GestorService> _loggerG;
        private readonly ChavesContext _dbcontext;
        public GestorService(ILogger<GestorService> loggerG, ChavesContext dbcontext)
        {
            _loggerG = loggerG;
            _dbcontext = dbcontext;
        }

        /// <summary>
        /// Esta fun��o GerirSorteio � respons�vel por obter os Vencedores e calcular todos os Pr�mios dos participantes do sorteio.
        /// </summary>
        /// <param> <c>request</c> s�o os parametros de Entrada enviados pelo cliente -> Tipo Resultado </param>
        /// <param> <c>context</c> � o contexto do Server-Side Call </param>
        /// <returns>Retorna o estado da opera��o (true/false) e a informa��o das Apostas Vencedoras</returns>
        public override Task<EstadoResultado>GerirSorteio(Resultado request, ServerCallContext context)
        {   
            //Consultar Apostas ativas 
            var ApostasAtivas = _dbcontext.Apostas.Where(element => element.Arquivada == false).ToList();

            //Calcular Pr�mios
            ApostasAtivas.ForEach(ele => {
                var NumerosString=ele.Numeros;
                var EstrelasString = ele.Estrelas;
                int[] _numeros = CalculoPremios.ConvertArrayToInt(NumerosString,',');
                int[] _estrelas = CalculoPremios.ConvertArrayToInt(EstrelasString,',');
                int _premio = CalculoPremios.CalcularPremio(_numeros, _estrelas, request.Numeros.ToArray(), request.Estrelas.ToArray());
                ele.Premio = _premio;
                _dbcontext.Apostas.Update(ele);
            });
            _dbcontext.SaveChanges();

            //Consultar Apostas Vencedoras
            var ApostasWin = _dbcontext.Apostas.Where(element => element.Arquivada == false).Where(element => element.Premio != 0).OrderBy(element => element.Premio).ToList();


            if (ApostasWin != null)
            {
                //Para retornar a informa��o ao cliente � necess�rio fazer a "tradu��o" da informa��o List-> RepeatableField
                RepeatedField<Vencedor> ApostasWinConverted = new RepeatedField<Vencedor>();
                ApostasWin.ForEach((element) =>
                {
                    ApostasWinConverted.Add(new Vencedor
                    {
                        NIF = element.NIF,
                        NumeroAposta = element.RegistoApostaId,
                        DataAposta = Timestamp.FromDateTime(element.Data.ToUniversalTime()),
                        Estrelas = element.Estrelas,
                        Numeros = element.Numeros,
                        Premio = element.Premio
                    });
                });
                return Task.FromResult(new EstadoResultado
                {
                    Estado = true,
                    ApostasVencedoras = {ApostasWinConverted}
                });
            }
            else
            {
                return Task.FromResult(new EstadoResultado
                {
                    Estado = false,
                    ApostasVencedoras = {}
                });
            }
        }
    }
}
