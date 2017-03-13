using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPLibrary {
    public class Response {
        public string statusCode { get; set; }
        public string content { get; set; }
        public int statusCodeNumber { get; set; }

        public Response() {}

        public Response(string statusCode, string content, int statusCodeNumber) {
            this.statusCode = statusCode;
            this.content = content;
            this.statusCodeNumber = statusCodeNumber;
        }
    }
}
