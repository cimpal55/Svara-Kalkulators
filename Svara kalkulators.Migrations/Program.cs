using Microsoft.Extensions.DependencyInjection;
using FluentMigrator.Runner;
using Svara_kalkulators.Migrations.Migrations._20220913_Initial;
using Microsoft.Data.SqlClient;

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

static void UpdateDatabase(IServiceProvider serviceProvider)
{
    var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
    runner.MigrateUp();
}