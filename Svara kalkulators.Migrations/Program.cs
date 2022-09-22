using Microsoft.Extensions.DependencyInjection;
using FluentMigrator.Runner;
using Svara_kalkulators.Migrations.Migrations._20220913_Initial;
using Microsoft.Data.SqlClient;
using Dapper;

var serviceProvider = CreateServices();

using (var scope = serviceProvider.CreateScope())
UpdateDatabase(scope.ServiceProvider);

static IServiceProvider CreateServices()
{
    return new ServiceCollection()
        .AddFluentMigratorCore()
        .ConfigureRunner(rb => rb
            .AddSqlServer()
            .WithGlobalConnectionString(Environment.GetCommandLineArgs()[1])
            .ScanIn(typeof(ResultsMigration).Assembly).For.Migrations())
        .AddLogging(lb => lb.AddFluentMigratorConsole())
        .BuildServiceProvider(false);
}

static bool CheckDatabaseExists(string connectionString)
{
    using (var connection = new SqlConnection(connectionString))
    {
        using (var command = new SqlCommand($"SELECT db_id('Results')", connection))
        {
            connection.Open();
            return (command.ExecuteScalar() != DBNull.Value);
        }
    }
}

static void CreateDb()
{
    var cs = @"Server=.\SQLEXPRESS;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False";
    using var con = new SqlConnection(cs);
    con.Open();

    if (CheckDatabaseExists(cs) == false)
    {
        string query = "CREATE DATABASE Results";
        con.Execute(query);
    }
    else
    {
        return;
    }
}

static void UpdateDatabase(IServiceProvider serviceProvider)
{
    CreateDb();
    var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
    runner.MigrateUp();
}