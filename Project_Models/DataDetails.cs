using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Models
{
    public class DataDetails
    {
        [Required]
        [MinLength(4,ErrorMessage ="Token is Too Short")]
        [MaxLength(100, ErrorMessage = "Token is Too Long")]
        public string TokenKey { get; set; } = "A12F7A58-842D-4111-A44D-5F8C4E1AA521";


        [Required(ErrorMessage = "Please Enter Device Type..")]
        public string DevType { get; set; } = string.Empty;

        [Required]
        [MinLength(2, ErrorMessage = "Device Type Other Name is Too Short")]
        [MaxLength(10, ErrorMessage = "Device Type Other Name is Too Long")]
        public string? DevTypeOther { get; set; }


        [Required]
        [MinLength(2, ErrorMessage = "Device Make Name is Too Short")]
        [MaxLength(10, ErrorMessage = "Device Make Name is Too Long")]
        public string? Make { get; set; }


        [Required]
        [MinLength(2, ErrorMessage = "Device Model Name is Too Short")]
        [MaxLength(10,ErrorMessage = "Device Model Name is Too Long")]
        public string? Model { get; set; }


        [Required]
        [MinLength(2, ErrorMessage = "Device Owner Name is Too Short")]
        [MaxLength(40, ErrorMessage = "Device Owner Name is Too Long")]
        public string? Owner { get; set; }


        [Required]
        [MinLength(2, ErrorMessage = "Device Location is Too Short")]
        [MaxLength(20, ErrorMessage = "Device Location is Too Long")]
        public string? Location { get; set; }


        [Required]
        [MinLength(2, ErrorMessage = "Device Serial is Too Short")]
        [MaxLength(40, ErrorMessage = "Device Serial is Too Long")]
        public string Serial { get; set; }

        [Required(ErrorMessage = "Please Enter Device Purchase Date Expiry Date..")]
        public DateTime PurchaseDate { get; set; }


        [Required(ErrorMessage = "Please Enter Device Warranty Expiry Date..")]
        public DateTime WarrantyExpDate { get; set; }


        [Required(ErrorMessage = "Please Enter Device Service Expiry Date..")]
        public DateTime ServiceExpDate { get; set; }


        [Required]
        [MinLength(1, ErrorMessage = "Device Value is Too Short")]
        [MaxLength(40, ErrorMessage = "Device Value is Too Long")]
        public string? Value { get; set; }


        [Required]
        [MinLength(1, ErrorMessage = "Device Size is Too Short")]
        [MaxLength(40, ErrorMessage = "Device Size is Too Long")]
        public string Size { get; set; }


        [Required]
        [MinLength(1, ErrorMessage = "Device Toner is Too Short")]
        [MaxLength(40, ErrorMessage = "Device Toner is Too Long")]
        public string Toner { get; set; }


        [Required]
        [MinLength(1, ErrorMessage = "Device MAC Address is Too Short")]
        [MaxLength(40, ErrorMessage = "Device MAC Address is Too Long")]
        public string MacAddress { get; set; }


        [Required]
        [MinLength(1, ErrorMessage = "Device IP Address is Too Short")]
        [MaxLength(40, ErrorMessage = "Device IP Address is Too Long")]
        public string IPAddress { get; set; }

        [Phone]
        [Required(ErrorMessage = "Please Enter Device CellPhone Number...")]
        public string CellNumber { get; set; }
       
        public int DevId { get; set; }

    }

}
