using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Svara_kalkulators.DbConnections
{
    public class ResultsRepository : IResultsRepository
    {
        private IDbConnection db;

        public ResultsRepository(string connString)
        {
            this.db = new SqlConnection(connString);
        }
        public Results Add(Results results)
        {
            var sql =
                "INSERT INTO Results (Barcode, Weight, DateTime) VALUES (@Barcode, @Weight, @DateTime); " + 
                "SELECT CAST(SCOPE_IDENTITY() AS INTEGER)";
            var id = this.db.Query<int>(sql, results).Single();
            results.Id = id;
            return results;
        }

        public Results Find(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Results> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public Results Update(Results results)
        {
            throw new System.NotImplementedException();
        }

        public void CreateDb()
        {
            var sql =
                "CREATE DATABASE Results";
            
            
        }
    }
}
