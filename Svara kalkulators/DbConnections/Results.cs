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
    public class Results {

        [ExplicitKey]
        public int Id { get; set; }
        public string Barcode { get; set; }
        public float Weight { get; set; }
        public string DateTime { get; set; }
    }
}
