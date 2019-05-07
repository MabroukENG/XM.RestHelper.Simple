using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XMRestAPIClient;

namespace XMRHSimple
{
    [JsonObject()]
    public class VMCustomer
    {
        public VMCustomer()
        {
            Customers = new List<Customer>();
        }
        public MetaData Meta { get; set; }
        [JsonProperty("customers")]
        List<Customer> Customers { get; set; }
    }

    public class Customer : IXMModel<long>
    {
        private long id = -1;
        public long Id
        {
            get => id == -1 ? (id = long.Parse(Customer_url?.Split('/')?.LastOrDefault() ?? "0")) : id;
            set => id = value;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Customer_url { get; set; }
    }

    public class MetaData
    {
        public int Count { get; set; }
        public int Limit { get; set; }
        public int Page { get; set; }
    }

}
