using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using Project_Assesment.Models;

namespace Project_Assesment.Repositories
{
    public class ProjectRepository
    {
        private static string API_URL = "http://projectservice.staging.tangentmicroservices.com:80/api/v1/projects/";

        public static IEnumerable<Project> GetAll(string Token)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(API_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("Authorization :" + Token));
                HttpResponseMessage response = client.GetAsync("project").Result;

                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsAsync<IEnumerable<Project>>().Result;
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
        public static bool Delete(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(API_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.DeleteAsync("project/" + id).Result;
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }

        }


        public static Project FindOne(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(API_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("order/" + id).Result;

                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsAsync<Project>().Result;
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
        public static bool EditOne(Project model)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(API_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PutAsJsonAsync("order/" + model.pk, model).Result;

                return response.IsSuccessStatusCode;

            }
            catch
            {
                return false;
            }

        }


        public static bool Create(Project model)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(API_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PutAsJsonAsync("order/", model).Result;

                return response.IsSuccessStatusCode;

            }
            catch
            {
                return false;
            }

        }
    }
}
