using ENB.Blazor.Lawyer.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace ENB.Blazor.Lawyer.HttpRepository
{
    public class CaseHttpRepository : ICaseHttpRepository
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;
      
        public CaseHttpRepository(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }
        public async Task<CreateAndEditCase> AddCase(CreateAndEditCase createAndEditCase)
        {
            var response = await _client.PostAsJsonAsync("cases/createcase", createAndEditCase);

            return await response.Content.ReadFromJsonAsync<CreateAndEditCase>();
        }

        Task ICaseHttpRepository.DeleteCase(int Id)
        {
            throw new System.NotImplementedException();
        }

     public async   Task<CreateAndEditCase> RetrieveCase(int Id)
        {
            var response = await _client.GetAsync($"cases/displaycase/{Id}");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var vcase = JsonSerializer.Deserialize<CreateAndEditCase>(content, _options);
            return vcase;
        }

      public async  Task<CreateAndEditCase> EditCase(CreateAndEditCase createAndEditCase)
        {
            var response = await _client.PutAsJsonAsync("cases/editcase", createAndEditCase);

            return await response.Content.ReadFromJsonAsync<CreateAndEditCase>();
        }

      public async  Task<DisplayCase> GetCase(int Id)
        {
            var response = await _client.GetAsync($"cases/detailscase/{Id}");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var vcase = JsonSerializer.Deserialize<DisplayCase>(content, _options);
            return vcase;
        }

      public async  Task<List<DisplayCase>> GetCases()
        {
            var response = await _client.GetAsync("cases");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var cases = JsonSerializer.Deserialize<List<DisplayCase>>(content, _options);
            return cases;
        }

       
    }
}
