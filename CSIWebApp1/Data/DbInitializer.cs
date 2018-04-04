using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSIWebApp1.Models;

namespace CSIWebApp1.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            
            if (context.RequestMetric.Any())
            {
                return;   // DB has been seeded
            }

            var requestmetric = new RequestMetric[]
            {
                new RequestMetric(){RequestMetricId=24494, Timestamp=DateTime.Parse("2018-01-02 11:00:31.0000000"), SourceIp = "172.18.3.115", SourcePort = 1999, URI = "http://devapi.myebanking.net/0_3/api/Bank/GetBankSettings?random=1514912431605", Verb = "POST", RequestBody = "HostName : 202.myebanking.net" , ReasonPhrase = "OK", ResponseBody = "DefaultCategories : CategoryID:45", ResponseCode="CategoryName : Transportation", Duration="IsDefault:true", Channel="CategoryID : 46", APIVersion="CategoryName : Bills & Utilities", APIController="IsDefault:true", APIMethod="CategoryID:47", BankNumber="CategoryName:Business", ServerName="200", UserID=5325, EmpID=1, SessionID=0_3, RequestCert="Bank", PartnerKey="GetBankSettings"},
                new RequestMetric(){RequestMetricId=24667, Timestamp=DateTime.Parse("2018-01-02 11:09:53.0000000"), SourceIp = "172.18.9.189", SourcePort = 53110, URI = "http://devapi.myebanking.net/0_3/api/BillPay/BillPayPayeeSearch?random=1514912992198", Verb = "POST", RequestBody = "{}", ReasonPhrase = "OK", ResponseBody = "LstPayees:CallFailed:false", ResponseCode="ErrMsg:null", Duration="PayeeID:20", Channel="ExcludeAddress:false", APIVersion="PayeeAddressIsReadOnly:false", APIController="PayeePhoneIsReadOnly:false", APIMethod="ShowRecurring:false", BankNumber="LstPayeeError:null", ServerName="ErrorType", UserID=200, EmpID=12429, SessionID=1, RequestCert="0_3", PartnerKey="BillPay"}
            };

            foreach (RequestMetric r in requestmetric)
            {
                context.RequestMetric.Add(r);
            }
            context.SaveChanges();

            if (context.RequestMetricsDetails.Any())
            {
                return;
            }

            var requestmetricsdetails = new RequestMetricsDetails[]
            {
                new RequestMetricsDetails(){RequestMetricsDetailsID=8006, RequestMetricId=24667, RequestType="API", BeginTime=DateTime.Parse("2018-01-02 11:09:54.070"), EndTime=DateTime.Parse("2018-01-02 11:10:00.163"), RequestTime="6094", RequestDetail="BilPayChanInqRequest", IsError="jxid=0556accc-b2bd-455d-a933-ab4a39bf6444", RequestMetricsExtID="routing=074976762"},
                new RequestMetricsDetails(){RequestMetricsDetailsID=8010, RequestMetricId=24667, RequestType="API", BeginTime=DateTime.Parse("2018-01-02 11:10:01.883"), EndTime=DateTime.Parse("2018-01-02 11:10:03.993"), RequestTime="2109", RequestDetail="BilPayPayeeSrchRequest", IsError="jxid=646b575d-42fd-4bd7-9e7a-be5644dc180d", RequestMetricsExtID="routing=074976762" }
            };
            foreach (RequestMetricsDetails d in requestmetricsdetails)
            {
                context.RequestMetricsDetails.Add(d);
            }
            context.SaveChanges();

            if (context.RequestMetricsExt.Any())
            {
                return;
            }

            var requestmetricsext = new RequestMetricsExt[]
            {
                
            };
            foreach (RequestMetricsExt e in requestmetricsext)
            {
                context.RequestMetricsExt.Add(e);
            }
            context.SaveChanges();
        }
    }
}
