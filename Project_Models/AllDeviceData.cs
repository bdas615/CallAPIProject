 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Models
{
    public class AllDeviceData
    {
        public string msg { get; set; }
        public string total { get; set; }
        public List<DerivedClass> data { get; set; }

    }

   /* public class TokenClass 
    {
        public string token { get; set; }
        public TokenClass(string token)
        {
            this.token = token;
        }  
    }*/

    public class DerivedClass 
    {
        public string DevId { get; set; } = string.Empty;
        public string DevType { get; set; } = string.Empty;
        public string? DevTypeOther { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Owner { get; set; }
        public string? Location { get; set; }
        public string Serial { get; set; } = string.Empty;
        public string PurchaseDate { get; set; } = string.Empty;
        public string WarrantyExpDate { get; set; } = string.Empty;
        public string ServiceExpDate { get; set; } = string.Empty;
        public string? Value { get; set; }
        public string Size { get; set; } = string.Empty;
        public string Toner { get; set; } = string.Empty;
        public string MacAddress { get; set; } = string.Empty;
        public string IPAddress { get; set; } = string.Empty;
        public string CellNumber { get; set; } = string.Empty;
        public string UpdDate { get; set; } = string.Empty;
        public string DevStatus { get; set; } = string.Empty;

    }
}
