using SysFinance.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysFinance.BLL
{
    public class RelatoriosBLL
    {
        RelatoriosDAL obj = new RelatoriosDAL();

        #region carregar relatorio de extrato
        public DataTable CarregarExtrato(int idUser, string param = "")
        {
            return obj.CarregarExtrato(idUser, param);
        }
        #endregion

        #region carregar relatório de fluxo de caixa
        public DataTable CarregarFluxoCaixa(int idUser, string param = "", string param2 = "",string dtSaldo="")
        {
            Decimal vlSaldo = 0;
            DataTable fluxoCaixaFinal = new DataTable("Fluxo de Caixa");
            DataTable saldoInicial = new DataTable("Saldo inicial");

            var dtFluxocaixaLancto = obj.CarregarFluxoCaixa(idUser, param, param2).Tables[0];
            var dtSaldoInicial = obj.CarregarFluxoCaixa(idUser, param, param2).Tables[1];

            fluxoCaixaFinal = dtFluxocaixaLancto.Clone();
            fluxoCaixaFinal.Columns.Add("VL_SALDO", typeof(Decimal));

            // adicionando saldo inicial
            foreach (DataRow dr in dtSaldoInicial.Rows) 
            {
                var row = fluxoCaixaFinal.NewRow();

                row["DT_LANCTO"] = dtSaldo;
                row["DS_LANCTO"] = dr["DS_CONTA"];
                row["TP_OPERACAO"] = "";
                row["VL_ENTRADA"] = Convert.ToDecimal(0);
                row["VL_SAIDA"] = Convert.ToDecimal(0);
                row["VL_SALDO"] = Convert.ToDecimal(dr["VL_SALDO"]);

                vlSaldo = Convert.ToDecimal(dr["VL_SALDO"]);

                fluxoCaixaFinal.Rows.Add(row);
            }

            if (vlSaldo == 0) {

                var row = fluxoCaixaFinal.NewRow();

                row["DT_LANCTO"] = dtSaldo;
                row["DS_LANCTO"] = "SALDO INICIAL";
                row["TP_OPERACAO"] = "";
                row["VL_ENTRADA"] = Convert.ToDecimal(0);
                row["VL_SAIDA"] = Convert.ToDecimal(0);
                row["VL_SALDO"] = Convert.ToDecimal(0);

                fluxoCaixaFinal.Rows.Add(row);
            }


            // adicionando lancamentos
            foreach (DataRow dr in dtFluxocaixaLancto.Rows) {

                var row = fluxoCaixaFinal.NewRow();
                var vlEntrada = (Decimal)dr["VL_ENTRADA"];
                var vlSaida = (Decimal)dr["VL_SAIDA"];

                vlSaldo = (vlSaldo + vlEntrada) - (vlSaida) * (-1);

                row["DT_LANCTO"] = dr["DT_LANCTO"];
                row["DS_LANCTO"] = dr["DS_LANCTO"];
                row["TP_OPERACAO"] = dr["TP_OPERACAO"];
                row["VL_ENTRADA"] = dr["VL_ENTRADA"];
                row["VL_SAIDA"] = dr["VL_SAIDA"];
                row["VL_SALDO"] = vlSaldo;

                fluxoCaixaFinal.Rows.Add(row);
            }

            return fluxoCaixaFinal;
        }
        #endregion

    }
}
