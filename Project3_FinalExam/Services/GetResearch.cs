using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Project3_FinalExam.Services
{
    public class GetResearch : IGetResearch
    {
        public async Task<List<Research>> GetAllResearch()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/research/byInterestArea", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<Research>>>(data);

                    List<Research> facultyList = new List<Research>();
                    Research faculty = new Research();

                    foreach (KeyValuePair<string, List<Research>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            facultyList.Add(item);
                        }
                    }

                    return facultyList;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<Research> facultyList = new List<Research>();
                    return facultyList;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<Research> facultyList = new List<Research>();
                    return facultyList;
                    //return "Exception"; ;
                }
            }
        }
    }
}
