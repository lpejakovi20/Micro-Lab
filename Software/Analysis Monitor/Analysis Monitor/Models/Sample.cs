using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis_Monitor.Models
{
    public class Sample
    {
        public int IdSample { get; set; }
        public string idPatient { get; set; }
        public DateTime TimeOfReceipt { get; set; }
        public string SampleType { get; set; }
        public string SampleInfo { get; set; }
     
    }
}
