using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace product__easy_learn_.Models
{
    public class teacher
    {
        public int id { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public string email { get; set; }
        public IFormFile picture { get; set; }
    }
    public class course
    {
        public int id { get; set; }
        public string title { get; set; }
        public string totaltime { get; set; }
        public string descript { get; set; }
        public IFormFile videointro { get; set; }
        public IFormFile picture { get; set; }
        public string pictureurl { get; set; }
        public string videourl { get; set; }
        public string price { get; set; }
        public List<int> teachers { get; set; }

    }
}
