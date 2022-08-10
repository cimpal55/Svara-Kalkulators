namespace Svara_kalkulators.DbConnections
{
    public class SqliteDbConnectionFactory
    {
        public IDbConnection Connect()
        {
            return new SqliteDbConnection
        }
    }
}
