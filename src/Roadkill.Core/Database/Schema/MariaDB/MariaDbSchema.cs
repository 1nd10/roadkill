using System.Collections.Generic;

namespace Roadkill.Core.Database.Schema
{
    public class MariaDbSchema : SchemaBase
    {
        protected override IEnumerable<string> GetCreateStatements()
        {
            var sql = LoadFromResource("Roadkill.Core.Database.Schema.MariaDB.Create.sql");
            return new [] {sql};
        }

        protected override IEnumerable<string> GetDropStatements()
        {
            var sql = LoadFromResource("Roadkill.Core.Database.Schema.MariaDB.Drop.sql");
            return new [] {sql};
        }

        protected override IEnumerable<string> GetUpgradeStatements()
        {
            var sql = LoadFromResource("Roadkill.Core.Database.Schema.MariaDB.Upgrade.sql");
            return new [] {sql};
        }
    }
}