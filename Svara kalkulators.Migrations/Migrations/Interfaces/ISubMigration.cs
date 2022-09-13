using FluentMigrator;

namespace Svara_kalkulators.Migrations.Migrations.Interfaces
{
    public interface ISubMigration
    {
        void Up(Migration migration);
        void Down(Migration migration);
        
    }
}
