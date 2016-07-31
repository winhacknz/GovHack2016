using Newtonsoft.Json.Linq;
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
        public static JObject GetRentalData()
        {
            var endPoint    = @"https://api.tmsandbox.co.nz/v1/Search/Property/Rental.json";
            var oAuthHeader = @"Authorization: OAuth oauth_consumer_key=32038210D256885F3FC11DF0A42DBA89, oauth_signature_method=PLAINTEXT, oauth_signature=89F5A44725D07B153C1163BC1149E932&";
            var headers     = new WebHeaderCollection();
            headers.Add(oAuthHeader);          
            var client      = new RestClient(endPoint);
            client.Headers  = headers;
            
            var json = client.MakeRequest();

            return JObject.Parse(json);
        }

        public static JObject GetBadCityNew(string cityName)
        {
            var endPoint = @"https://access.alchemyapi.com/calls/data/GetNews?apikey=f29c6c4716f07c183dbb75aeb46fae77f98860d5&return=enriched.url.title&start=1469232000&end=1469919600&q.enriched.url.enrichedTitle.entities.entity=|text=" + cityName + @",type=city|&q.enriched.url.enrichedTitle.docSentiment.type=$sentiment&count=25&outputMode=json";
            var client = new RestClient(endPoint);
            var json = client.MakeRequest();

            return JObject.Parse(json);
        }

        public static JObject GetRegionData()
        {             
            var endPoint = @"https://4ab786da-1405-4cc7-8b8b-e53b5def3a2a-bluemix.cloudant.com/regionstats/_all_docs?include_docs=true&conflicts=true";
            var basicAuth = @"Authorization:Basic NGFiNzg2ZGEtMTQwNS00Y2M3LThiOGItZTUzYjVkZWYzYTJhLWJsdWVtaXg6YTUxODEyOTU2N2I5ZmJkOTE3ZjhiMmRlM2NlMDM1MzBlN2E2YTYxODU5MzY1M2Y0Y2Y1NmJkOTBkNGNjZTUzMw==";
            var headers = new WebHeaderCollection();
            headers.Add(basicAuth);
            var client = new RestClient(endPoint);
            client.Headers = headers;

            var json = client.MakeRequest();
            

            return JObject.Parse(json);
        }
    }
}
