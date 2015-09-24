using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Mobile.Service;
using Newtonsoft.Json;

namespace XamarinCRMv2CatalogDataService.DataObjects
{
    public class Order : EntityData
    {
        
       
        public bool IsOpen { get; set; }

        
        public string AccountId { get; set; }

       
        public double Price { get; set; }

       
        public string Item { get; set; }

       
        public DateTime OrderDate { get; set; }

        
        public DateTime DueDate { get; set; }

        
        public DateTime? ClosedDate { get; set; }

        
    }
}