using Backend.OneSignal.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity.Migrations;

namespace Backend.OneSignal
{
    public class onesignal
    {
        private static string AuthorizationKey = "NWQxYjE3ZGEtMjIyZS00MmE4LThmMzgtZDJiMzVhMDJjODc0";
        public static void SyncApplications()
        {
            var uriBuilder = new UriBuilder("https://onesignal.com/api/v1/apps");
            var parameters = HttpUtility.ParseQueryString(string.Empty);
            

            uriBuilder.Query = parameters.ToString();
            Uri finalUrl = uriBuilder.Uri;
            var client = new WebClient();
            client.Headers.Add(HttpRequestHeader.Authorization, "Basic " + AuthorizationKey);
            var response = client.DownloadString(finalUrl);
            var responseObject = JsonConvert.DeserializeObject<Backend.EF.App[]>(response);

            var db = new Backend.EF.onesignalDB2();
            foreach (var dr in responseObject)
            {
                dr.synch_at = DateTime.Now;
                db.apps.AddOrUpdate(dr);
            }
            db.SaveChanges();

        }

        public static void CreateApplications(App_Update_Add app)
        {
            var uriBuilder = new UriBuilder("https://onesignal.com/api/v1/apps");
            var parameters = HttpUtility.ParseQueryString(string.Empty);
            uriBuilder.Query = parameters.ToString();
            Uri finalUrl = uriBuilder.Uri;

            var client = new WebClient();
            client.Headers.Add("Content-Type:application/json");
            client.Headers.Add(HttpRequestHeader.Authorization, "Basic "+ AuthorizationKey);

          
            var data = JsonConvert.SerializeObject(app);
            var response = client.UploadString(finalUrl.ToString(), "POST", data);
            var responseObject = JsonConvert.DeserializeObject<Backend.EF.App>(response);

        }

        public static void UpdateApplications(App_Update_Add app)
        {
            var uriBuilder = new UriBuilder("https://onesignal.com/api/v1/apps/"+ app.id);
            var parameters = HttpUtility.ParseQueryString(string.Empty);
            uriBuilder.Query = parameters.ToString();
            Uri finalUrl = uriBuilder.Uri;

            var client = new WebClient();
            client.Headers.Add("Content-Type:application/json");
            client.Headers.Add(HttpRequestHeader.Authorization, "Basic " + AuthorizationKey);

            var data = JsonConvert.SerializeObject(app);
            var response = client.UploadString(finalUrl.ToString(), "PUT", data);
            var responseObject = JsonConvert.DeserializeObject<Backend.EF.App>(response);

        }

    }
}
