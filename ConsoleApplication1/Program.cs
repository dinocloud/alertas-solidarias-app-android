using Org.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTTPLibrary;
using Model;

namespace ConsoleApplication1 {
    class Program {
        static string url = "http://alertassolidarias.azurewebsites.net/api/v1/";
        static Client client = new Client();
        static void Main(string[] args) {
            testPost();
        }

        private static void testPost() {
            User user = new User();
            user.username = "jorgev";
            user.password = "dinocloud";

            Alarmer alarmer = new Alarmer();
            alarmer.user = user;
            alarmer.isOrg = false;
            alarmer.name = "Jorge";
            alarmer.last_name = "Villafuerte";
            alarmer.phone = "353695686";
            alarmer.email = "j.m.v@dino.com";

            Task<Response> response = client.post(url + "alarmers/", alarmer);
            var result = response.Result.content;

            Debug.Print("Se creo?");
        }

        private void testGet() {
            //var status = client.get("http://alertassolidarias.azurewebsites.net/api/v1/alarmers/");
            //int x = 1;

            //Task<Response> result = client.getAsync("http://alertassolidarias.azurewebsites.net/api/v1/alarmers/");
            //var finalResult = result.Result.content;

            //Debug.Print(finalResult);
        }

        private void testMarshaller() {
            User user = new User();
            user.username = "nesanche";
            user.password = "dinocloud";

            Alarmer alarmer = new Alarmer();
            alarmer.user = user;
            alarmer.id = 1;
            alarmer.isOrg = false;
            alarmer.name = "Nicolas";
            alarmer.last_name = "Sanchez";
            alarmer.phone = "353695682";
            alarmer.email = "nico.sanchez@dino.com";

            string result = JsonMarshaller.marshall(alarmer);

            Debug.Print(result);

            Debug.Print("Now unmarshalling json to object");

            var resultAlarmerType = (Alarmer)JsonMarshaller.unmarshall(result, typeof(Alarmer));

            Debug.Print("Json unmarshalled");
        }
    }
}
