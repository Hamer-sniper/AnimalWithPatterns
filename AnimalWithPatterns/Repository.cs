using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace AnimalWithPatterns
{
    public class Repository : DbContext
    {
        /// <summary>
        /// Получить строку подключения к SQL
        /// </summary>
        /// <returns>Строка подключения</returns>
        public static string GetSQLConnectionString()
        {
            Microsoft.Data.SqlClient.SqlConnectionStringBuilder sqlCon = new Microsoft.Data.SqlClient.SqlConnectionStringBuilder()
            {
                DataSource = @"(localdb)\MSSQLLocalDB",
                InitialCatalog = @"MSSQLLocalDemo",
                IntegratedSecurity = true,
                UserID = "sa",
                Password = "123",
                Pooling = false
            };

            return sqlCon.ConnectionString;
        }

        public Repository() : base(GetSQLConnectionString()) { }

        public DbSet<Animal> Animals { get; set; }
    }
}
