using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CSIWebApp1.Models
{
    public class RequestMetric
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None), Key]
        public int RequestMetricId { get; set; }
        public DateTime Timestamp { get; set; }
        public string SourceIp { get; set; }
        public int SourcePort { get; set; }
        public string URI { get; set; }
        public string Verb { get; set; }
        public string RequestBody { get; set; }
        public string ReasonPhrase { get; set; }
        public string ResponseBody { get; set; }
        public string ResponseCode { get; set; }
        public string Duration { get; set; }
        public string Channel { get; set; }
        public string APIVersion { get; set; }
        public string APIController { get; set; }
        public string APIMethod { get; set; }
        public string BankNumber { get; set; }
        public string ServerName { get; set; }
        public int UserID { get; set; }
        public int EmpID { get; set; }
        public int SessionID { get; set; }
        public string RequestCert { get; set; }
        public string PartnerKey { get; set; }
    }
}
