using BlazorProject.Models;
using BlazorProject.Models.Interfaces;
using System.Text.Json;

namespace BlazorProject.Services
{
    public class CountryService: ICountryService
    {
        private readonly HttpClient _httpClient;
        private List<Country> _allCountriesCache;

        public CountryService (HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<List<Country>> GetAllCountriesAsync() {

            if (_allCountriesCache != null)
            {
                return _allCountriesCache;
            }       
            var response = await _httpClient.GetAsync("https://restcountries.com/v3.1/all");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,

                };
                _allCountriesCache = JsonSerializer.Deserialize<List<Country>>(content,options);
            }
            else
            {
                Console.WriteLine("There is an error with the API");
            }
            return _allCountriesCache ?? new List<Country>();
        }


        public async Task<List<Country>> GetCountriesByPopulationAsync(int minPopulation=0, int maxPopulation=int.MaxValue)
        {
            var allCountries = await GetAllCountriesAsync();
            return allCountries.Where(country => country.Population >= minPopulation && country.Population <= maxPopulation).ToList();
        }

        public async Task<List<Country>> SearchCountriesByNameAsync(string name)
        {

            var allCountries = await GetAllCountriesAsync();
            return allCountries.Where(country => country.Name.Common.ToLower().Contains(name.ToLower())).ToList();

        }
    }
}
