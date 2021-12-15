using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Project3_FinalExam.Services
{
    public class Index : IGetHome
    {
        public async Task<Home> GetAllHome()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/about", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    Home home  = JsonSerializer.Deserialize<Home>(data);
                    List<Home> Hm = new List<Home>();
                 
                    
                    return home;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<Home> Homelist = new List<Home>();
                    return null;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<Home> Homelist = new List<Home>();
                    return null;
                    //return "Exception"; ;
                }
            }
        }
    }
}
