using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SteamBulkActivator
{
    class UpdateCheck
    {
        public class DataHolder
        {
            public string Version { get; set; }

            public string Info { get; set; }

            public bool UpdateAvailable { get; set; }
        }

        public DataHolder GetVersionData(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            try
            {
                var data = JsonConvert.DeserializeObject<DataHolder>(response.Content);

                var availableVersion = new Version(data.Version);
                var versionCurrent = new Version(Application.ProductVersion);

                data.UpdateAvailable = versionCurrent.CompareTo(availableVersion) < 0;

                return data;
            }
            catch
            {
                return null;
            }
        }
    }
}
