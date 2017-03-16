using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_Assesment.Models;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Project_Assesment.Repositories
{
    public class UserRepository
    {
    
        private static string API_URL="http://userservice.staging.tangentmicroservices.com:80/api-token-auth/";
        public static UserClienSite  findOne(string username, string password)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(API_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("User/" + username + "&" + password).Result;

                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsAsync<UserClienSite>().Result;
                    return data;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }


        }
    }
}