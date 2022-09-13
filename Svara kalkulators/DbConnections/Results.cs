using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara_kalkulators.DbConnections
{
    [Dapper.Contrib.Extensions.Table("Results")]
    public sealed record Results {

        [ExplicitKey]
        public int Id { get; set; }
        public string Barcode { get; set; }
        public decimal Weight { get; set; }
        public DateTime DateTime { get; set; }
    }
}
