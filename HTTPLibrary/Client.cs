using Org.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HTTPLibrary {
    public class Client {

        HttpClient client = new HttpClient();

        public async Task<Response> get(String url) {
            var responseAsync = await client.GetAsync(url);
            var content = await responseAsync.Content.ReadAsStringAsync();
            var statusCodeNumber = (int)responseAsync.StatusCode;
            var statusCode = responseAsync.StatusCode.ToString();


            Response response = new Response();
            response.statusCode = statusCode;
            response.content = content;
            response.statusCodeNumber = statusCodeNumber;
            return response;
        }

        public void post(String url) {
            
        }
    }
}
