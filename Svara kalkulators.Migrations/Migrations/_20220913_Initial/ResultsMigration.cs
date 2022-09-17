using FluentMigrator;
using Svara_kalkulators.Migrations.Migrations.Interfaces;

namespace Svara_kalkulators.Migrations.Migrations._20220913_Initial
{
    [Migration(2022091301)]
    public sealed class ResultsMigration : Migration
    {
        private const string TableName = "Results";
        public override void Up()
        {
            
            Create.Table(TableName)
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Barcode").AsString(12).NotNullable()
                .WithColumn("Weight").AsDecimal().NotNullable()
                .WithColumn("DateTime").AsDateTime().NotNullable();
        }
        public override void Down()
        {
            Delete.Table(TableName);
        }
    }
}
