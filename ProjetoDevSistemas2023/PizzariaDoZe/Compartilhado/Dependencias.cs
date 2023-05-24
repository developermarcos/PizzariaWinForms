using PizzariaDoZe.Distribuiton.FeatureIngrediente;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Infra.FeatureIngrediente;
using PizzariaDoZe.Telas.Cadastros.TelaCliente;
using PizzariaDoZe.Telas.Cadastros.TelaIngrediente;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Compartilhado
{
    public class Dependencias
    {
        private Dictionary<string, ControladorBase> controladores;
        public Dependencias()
        {
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);

            //for Connection
            var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            DbConnection connection = factory.CreateConnection();

            InicializarControladores();
        }
        public T Get<T>() where T : ControladorBase
        {
            var tipo = typeof(T);

            var nomeControlador = tipo.Name;

            return (T)controladores[nomeControlador];
        }

        public void InicializarControladores()
        {
            controladores = new Dictionary<string, ControladorBase>();

            IRepositorioIngrediente repositorioingrediente = new RepositorioIngrediente();
            IngredienteService serviceCliente = new IngredienteService(repositorioingrediente);
            controladores.Add("ControladorIngrediente", new ControladorIngrediente(serviceCliente));
        }
    }
}
