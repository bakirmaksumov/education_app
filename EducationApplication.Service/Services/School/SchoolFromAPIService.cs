using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using EducationApplication.Service.Services.Interfaces.School;
using EducationApplication.ViewModel.ViewModels.School;

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
            public async Task<SchoolVM> GetSchoolsAsync()
        {
            string path = "https://cityadministration20210925021624.azurewebsites.net/api/building/ReserveBuilding?id=6&newBuildingType=3";
            SchoolVM product = null;
            HttpResponseMessage response = await client.GetAsync(path);
         
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<SchoolVM>();
            }
            return product;
        }
    
    }
}
