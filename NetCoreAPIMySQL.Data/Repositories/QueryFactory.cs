using MySql.Data.MySqlClient;
using SqlKata.Compilers;

namespace NetCoreAPIMySQL.Data.Repositories
{
    internal class QueryFactory
    {
        private MySqlConnection connection;
        private MySqlCompiler mySqlCompiler;

        public QueryFactory(MySqlConnection connection, MySqlCompiler mySqlCompiler)
        {
            this.connection = connection;
            this.mySqlCompiler = mySqlCompiler;
        }

        internal IEnumerable<object> Query(string v)
        {
            throw new NotImplementedException();
        }
    }
}