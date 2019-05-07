using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using XMRestAPIClient;

namespace XMRHSimple
{
    public class CustomersService : XMBaseDataService<Customer, long>
    {
        public override string ApiName => "customers";
        public override string BaseAPIUrl => "https://api.predic8.de:443/";

        public override int ApiVersion => -1;
        public CustomersService() : base()
        {

        }

        /// <summary>
        /// Gets the API URL.
        /// </summary>
        /// <param name="httpMethod">The HTTP method.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="page">The page.</param>
        /// <param name="count">The count.</param>
        /// <param name="apiParams">The API parameters.</param>
        /// <returns></returns>
        public override Uri GetApiUrl(HttpMethod httpMethod, long? id = null, int page = 0, int count = 0, params Tuple<string, string>[] apiParams)
        {
            var uri= new Uri($"{BaseAPIUrl}shop/{ApiName}/");
            return uri;
        }

        
    }
}
