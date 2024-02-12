namespace BlazorProject.Models.Interfaces
{
    public interface ICountryService
    {
        Task<List<Country>> GetAllCountriesAsync();
        Task<List<Country>> GetCountriesByPopulationAsync(int minPopulation, int maxPopulation);
        Task<List<Country>> SearchCountriesByNameAsync(string name);
    }
}
