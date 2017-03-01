using Org.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTTPLibrary;

namespace ConsoleApplication1 {
    class Program {
        static Client client = new Client();
        static void Main(string[] args) {
            //var status = client.get("http://alertassolidarias.azurewebsites.net/api/v1/alarmers/");
            //int x = 1;

            Task<Response> result = client.getAsync("http://alertassolidarias.azurewebsites.net/api/v1/alarmers/");
            var finalResult = result.Result.content;

            Debug.Print(finalResult);
        }
    }
}
