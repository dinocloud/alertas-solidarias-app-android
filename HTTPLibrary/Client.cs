using Org.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HTTPLibrary {
    public class Client {

        private HttpClient client;

        public Client() {
            client = new HttpClient();
            client.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Response> get(String url) {
            var responseAsync = await client.GetAsync(url);
            var content = await responseAsync.Content.ReadAsStringAsync();
            var statusCodeNumber = (int)responseAsync.StatusCode;
            var statusCode = responseAsync.StatusCode.ToString();

            return new Response(statusCode, content, statusCodeNumber);
        }

        public async Task<Response> post(String url, Object data) {
            var jsonObject = JsonMarshaller.marshall(data);
            var responseAsync = await client.PostAsync(url, new StringContent(jsonObject, UnicodeEncoding.UTF8, "application/json"));

            var content = await responseAsync.Content.ReadAsStringAsync();
            var statusCodeNumber = (int)responseAsync.StatusCode;
            var statusCode = responseAsync.StatusCode.ToString();

            return new Response(statusCode, content, statusCodeNumber);
        }
    }
}
