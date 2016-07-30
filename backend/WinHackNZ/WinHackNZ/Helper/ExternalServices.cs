using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WinHackNZ.Helper
{
    public class ExternalServices
    {
        public static string GetRentalData()
        {
            var endPoint    = @"https://api.tmsandbox.co.nz/v1/Search/Property/Rental.json";
            var oAuthHeader = @"Authorization: OAuth oauth_consumer_key=32038210D256885F3FC11DF0A42DBA89, oauth_signature_method=PLAINTEXT, oauth_signature=89F5A44725D07B153C1163BC1149E932&";
            var headers     = new WebHeaderCollection();
            headers.Add(oAuthHeader);          
            var client      = new RestClient(endPoint);
            client.Headers  = headers;
            
            var json = client.MakeRequest();

            return json;
        }
    }
}
