using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Context
{
    public class Application
    {
        public int ApplicationId { get; set; }
        public string Name { get; set; }
        public string logoURL { get; set; }
        public string Address { get; set; }
        public string phoneNo { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime? modifiedDate { get; set; }
        public bool isActive { get; set; }
    }
}
