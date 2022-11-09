using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Code
{
    public static class PetCode
    {

        public static List<PetsViewModel> GetPets(string entidadUri)
        {
            string _urlApi = ConfigurationManager.AppSettings["UrlApi"].ToString() + entidadUri;
            HttpClient client = new HttpClient();

            string _jsonResponse = client.GetAsync(_urlApi).Result.Content.ReadAsStringAsync().Result;
            var _petList = JsonConvert.DeserializeObject<List<PetsViewModel>>(_jsonResponse);

            return _petList;
        }
    }
}