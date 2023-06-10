using PizzariaDoZe.Distribuiton.FeatureCliente;
using PizzariaDoZe.Distribuiton.FeatureFuncionario;
using PizzariaDoZe.Distribuiton.FeatureIngrediente;
using PizzariaDoZe.Distribuiton.FeatureProduto;
using PizzariaDoZe.Distribuiton.FeatureSabor;
using PizzariaDoZe.Distribuiton.FeatureValor;
using PizzariaDoZe.Domain.FeatureCliente;
using PizzariaDoZe.Domain.FeatureFuncionario;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Domain.FeatureProduto;
using PizzariaDoZe.Domain.FeatureSabor;
using PizzariaDoZe.Domain.FeatureValor;
using PizzariaDoZe.Infra.FeatureCliente;
using PizzariaDoZe.Infra.FeatureFuncionario;
using PizzariaDoZe.Infra.FeatureIngrediente;
using PizzariaDoZe.Infra.FeatureProduto;
using PizzariaDoZe.Infra.FeatureSabor;
using PizzariaDoZe.Infra.FeatureValor;
using PizzariaDoZe.Telas.Cadastros.TelaCliente;
using PizzariaDoZe.Telas.Cadastros.TelaIngrediente;
using PizzariaDoZe.Telas.Cadastros.TelaProduto;
using PizzariaDoZe.Telas.Cadastros.TelaSabores;
using PizzariaDoZe.Telas.Cadastros.TelasFuncionario;
using PizzariaDoZe.Telas.Cadastros.TelaValor;
using System.Data.Common;

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

            IRepositorioFuncionario repositorioFuncionario = new RepositorioFuncionario();
            FuncionarioService serviceFuncionario = new FuncionarioService(repositorioFuncionario);
            controladores.Add("ControladorFuncionario", new ControladorFuncionario(serviceFuncionario));

            IRepositorioCliente repositorioCliente = new RepositorioCliente();
            ClienteService clienteService = new ClienteService(repositorioCliente);
            controladores.Add("ControladorCliente", new ControladorCliente(clienteService));

            IRepositorioSabor repositorioSabor = new RepositorioSabor();
            SaborService saborService = new SaborService(repositorioSabor);
            controladores.Add("ControladorSabor", new ControladorSabor(saborService));

            IRepositorioIngrediente repositorioingrediente = new RepositorioIngrediente();
            IngredienteService serviceCliente = new IngredienteService(repositorioingrediente);
            controladores.Add("ControladorIngrediente", new ControladorIngrediente(serviceCliente));

            IRepositorioProduto repositorioProduto = new RepositorioProduto();
            ProdutoService produtoService = new ProdutoService(repositorioProduto);
            controladores.Add("ControladorProduto", new ControladorProduto(produtoService));

            IRepositorioValor repositorioValor = new RepositorioValor();
            ValorService valorService = new ValorService(repositorioValor);
            controladores.Add("ControladorValor", new ControladorValor(valorService));
        }
    }
}
