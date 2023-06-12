using System.Configuration;
using System.Data.Common;

namespace PizzariaDoZe.Infra.Compartilhado
{
    public abstract class Connection
    {
        protected DbProviderFactory factory { get; set; }

        protected string Provider { get; set; }

        protected string strConnection { get; set; }

        public Connection()
        {
            Provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            factory = DbProviderFactories.GetFactory(Provider);
        }
    }
}
