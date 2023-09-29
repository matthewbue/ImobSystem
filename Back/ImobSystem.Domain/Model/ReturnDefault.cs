using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImobSystem.Domain.Model
{
    public  class ReturnDefault
    {
        public string message { get; set; }
        public object data { get; set; }

        public int totalPagina { get; set; }
        public int totalDados { get; set; }

        public ReturnDefault(string message, object data)
        {
            this.data = data;
            this.message = message;
        }
    }
}
