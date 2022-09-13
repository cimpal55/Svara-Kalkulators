using FluentMigrator;
using Svara_kalkulators.Migrations.Migrations.Interfaces;

namespace Svara_kalkulators.Migrations.Migrations._20220913_Initial
{
    [Migration(2022091301)]
    internal sealed class ResultsMigration : ISubMigration
    {
        private const string TableName = "Results";
        public void Up(Migration migration)
        {
            migration.Create.Table(TableName)
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Barcode").AsString(12).NotNullable()
                .WithColumn("Weight").AsDecimal().NotNullable()
                .WithColumn("DateTime").AsDateTime().NotNullable();
        }
        public void Down(Migration migration)
        {
            migration.Delete.Table(TableName);
        }
    }
}
