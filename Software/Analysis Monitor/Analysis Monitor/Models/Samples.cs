using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis_Monitor.Models
{
    public class Samples
    {
        public int SampleId { get; set; }
        public DateTime DatumIvrijemeZaprimanja { get; set; }
        public string VrstaUzorka { get; set; }
        public string OpisUzorka { get; set; }
     
    }
}
