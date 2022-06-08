using ChargingPointFinder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ChargingPointFinder.Services
{
    public class BatteryService
    {
        HttpClient client; 
        public BatteryService()
        {
            client = new HttpClient(); 
        }


        List<Model.BatteryModel> Batteries = new();
        public async Task<List<Model.BatteryModel>> GetBatteries()
        {
            if(Batteries?.Count > 0)
                return Batteries;

            var url = "";

            var response = await client.GetAsync(url);

            if(response.IsSuccessStatusCode)
            {
                Batteries = await response.Content.ReadFromJsonAsync<List<Model.BatteryModel>>();
            }

            //using var stream = await FileSystem.OpenAppPackageFileAsync("")


            return Batteries; 
        }
    }
}
