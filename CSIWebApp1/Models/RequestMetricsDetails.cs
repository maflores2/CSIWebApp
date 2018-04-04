using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSIWebApp1.Models
{
    public class RequestMetricsDetails
    {
        public int RequestMetricsDetailsID { get; set; }
        public int RequestMetricId { get; set; }
        public string RequestType { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string RequestTime { get; set; }
        public string RequestDetail { get; set; }
        public string IsError { get; set; }
        public string RequestMetricsExtID { get; set; }
    }
}
