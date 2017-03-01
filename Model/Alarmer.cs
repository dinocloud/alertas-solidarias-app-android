using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Alarmer
    {
        public int id { get; set; }
        public string name { get; set }
        public string last_name { get; set; }
        public string email { get; set; }
        public User user { get; set; }

    }
}
