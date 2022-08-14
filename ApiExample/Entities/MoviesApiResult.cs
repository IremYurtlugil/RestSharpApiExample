using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExample.Entities
{
    public class MoviesApiResult
    {
        public int status { get; set; }
        public bool success { get; set; }
        public string messageStatus { get; set; }
        public object[] results { get; set; } //Class oluşturulacak.
        public int total_results { get; set; }
        public int total_pages { get; set; }
    }
}
