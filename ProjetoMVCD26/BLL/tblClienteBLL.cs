using ProjetoMVCD26.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetoMVCD26.BLL
{
    public class tblClienteBLL
    {
        private DALMVC daoBanco = new DALMVC();

        public Boolean consultarBeneficio(string cpf, string nome, string nomeMae)
        {
            string consulta = string.Format($@"select * from dt_clienteD26 where cpf_cliente = '{cpf}' && nome_cliente = '{nome}' && nome_mae = '{nomeMae}';");
            DataTable dt = daoBanco.executarConsulta(consulta);
            if(dt.Rows.Count == 1)
            {
                return true;
            }else
            {
                return false;
            }

        }
    }
}