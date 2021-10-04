using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using EducationApplication.Service.Services.Interfaces.School;
using EducationApplication.ViewModel.ViewModels.School;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EducationApplication.Service.Services.School
{
    public class SchoolFromAPIService: ISchoolFromAPIService
    {
        static HttpClient client = new HttpClient();
        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:64195/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
      
        public async Task<string> GetSchoolsAsync()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync("https://cityadministration20210925021624.azurewebsites.net/api/building/GetBuildingsByType?typeId=3");
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        public List<SchoolVM> GetJsonToObject()
        {
            var result = GetSchoolsAsync();
            var final = JsonConvert.DeserializeObject<List<SchoolVM>>(result.Result);
            return final;
        }

        public SchoolVM GetJsonToObjectById(int id)
        {
            var result = GetSchoolsAsync();
            var final = JsonConvert.DeserializeObject<List<SchoolVM>>(result.Result).Where(m => Convert.ToInt16(m.Id) == id).FirstOrDefault();
            return final;
        }

        public List<SelectListItem> getSelectedListItems(int selected = 0)
        {
            var result = GetSchoolsAsync();
            var final = JsonConvert.DeserializeObject<List<SchoolVM>>(result.Result).Select(item => new SelectListItem()
            {
                Value = item.Id.ToString(),
                Text = item.Name.ToString(),
                Selected = (Convert.ToInt16(item.Id) == selected) ? true : false
            }).ToList();

            return final;
        }

    }
}
