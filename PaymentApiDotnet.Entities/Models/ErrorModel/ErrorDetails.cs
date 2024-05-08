using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PaymentApiDotnet.Entities.Models.ErrorModel
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; } // can be null

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
    /* ToString overriding
     {
        StatusCode : 200,
        message : "..."
     }
     */
}
