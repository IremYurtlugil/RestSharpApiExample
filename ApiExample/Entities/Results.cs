using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExample.Entities
{
    public class Results
    {
        public string _id { get; set; }
        public string image { get; set; }
        public string title { get; set; }
        public string rating { get; set; }
        public string year { get; set; }
        public string titleOriginal { get; set; }
        public string uuid { get; set; }
        public string description { get; set; }
        public List<object> genres { get; set; }
        public List<object> countries { get; set; }
        public string release { get; set; }
        public List<object> embedUrls { get; set; }
        public int index { get; set; }
        public List<object> episodes { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
    }
}
//Diğer sınıflarla ilişkilendirilecek.