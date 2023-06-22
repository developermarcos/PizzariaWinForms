using PizzariaDoZe.Domain.FeaturePedido;
using PizzariaDoZe.Infra.Compartilhado.Mapeador;
using System.Data.Common;
using System.Data.SqlClient;

namespace PizzariaDoZe.Infra.FeaturePedido
{
    public class MapeadorPedido : MapeadorBase<Pedido>
    {
        public override Pedido ConverterRegistro(SqlDataReader leitorRegistro)
        {
            Pedido pedido = new Pedido();

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("id")))
            {
                int id_ingrediente = leitorRegistro.GetInt32(leitorRegistro.GetOrdinal("id"));
                pedido.Id = id_ingrediente;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("dataPedido")))
            {
                DateTime dataPedido = leitorRegistro.GetDateTime(leitorRegistro.GetOrdinal("dataPedido"));
                pedido.dataPedido = dataPedido;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("ClienteId")))
            {
                int ClienteId = leitorRegistro.GetInt32(leitorRegistro.GetOrdinal("ClienteId"));
                pedido.ClienteId = ClienteId;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("FuncionarioId")))
            {
                int FuncionarioId = leitorRegistro.GetInt32(leitorRegistro.GetOrdinal("FuncionarioId"));
                pedido.FuncionarioId = FuncionarioId;
            }


            return pedido;
        }
        public override void ConfigurarParametros(Pedido registro, DbCommand comando)
        {

            if (registro.Id != 0)
            {
                AdicionarParameter("id", registro.Id, comando);
            }
            AdicionarParameter("dataPedido", registro.dataPedido, comando);
            AdicionarParameter("ClienteId", registro.ClienteId, comando);
            AdicionarParameter("FuncionarioId", registro.FuncionarioId, comando);
        }
    }
}
