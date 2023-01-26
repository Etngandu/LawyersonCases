using ENB.Blazor.Lawyer.Models;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace ENB.Blazor.Lawyer.HttpRepository
{
    public class LawyerHttpRepository : ILawyerHttpRepository
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;
      
        public LawyerHttpRepository(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<CreateAndEditLawyer> AddLawyer(CreateAndEditLawyer createAndEditLawyer)
        {
            
            var response = await _client.PostAsJsonAsync("lawyer/createlawyer", createAndEditLawyer);

            return await response.Content.ReadFromJsonAsync<CreateAndEditLawyer>();           

            
        }

    
       
        public  async Task DeleteLawyer(int Id)
        {
            await _client.DeleteAsync($"lawyer/deletelawyer/{Id}");

        }

        public async Task<CreateAndEditLawyer> EditLawyer(CreateAndEditLawyer createAndEditLawyer)
        {
            var response = await _client.PutAsJsonAsync("lawyer/editlawyer", createAndEditLawyer);

            return await response.Content.ReadFromJsonAsync<CreateAndEditLawyer>();
        }

        public async Task<DisplayLawyer> GetLawyer(int Id)
        {
            var response = await _client.GetAsync($"Lawyer/details/{Id}");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var lawyer = JsonSerializer.Deserialize<DisplayLawyer>(content, _options);
            return lawyer;
        }

        public async Task<List<DisplayLawyer>> GetLawyers()
        {
            var response = await _client.GetAsync("lawyer");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var lawyers = JsonSerializer.Deserialize<List<DisplayLawyer>>(content, _options);
            return lawyers;
        }

      public async  Task <CreateAndEditLawyer> Retrievelawyer(int Id)
        {
            var response = await _client.GetAsync($"Lawyer/retrievelawyer/{Id}");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var lawyer = JsonSerializer.Deserialize<CreateAndEditLawyer>(content, _options);
            return lawyer;
        }
    }
}
