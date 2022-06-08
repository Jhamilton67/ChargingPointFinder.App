using ChargingPointFinder.Model;
using ChargingPointFinder.Services;
using ChargingPointFinder.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargingPointFinder.ViewModel
{
    public partial  class BatteryViewModel : BaseViewModel
    {
        /// <summary>
        ///  Need to fix this error, This is because the data model has static data types. 
        /// </summary>
        public ObservableCollection<BatteryModel> Collection { get; } = new();

        BatteryService service;
        IConnectivity connectivity;
        IGeolocation geolocation;

        public BatteryViewModel(BatteryService service, IConnectivity connectivity, IGeolocation geolocation)
        {
            Title = "Battery Finder";
            this.service = service;
            this.connectivity = connectivity;
            this.geolocation = geolocation;
        }
        /// <summary>
        /// Need to fix this error, This is because the data model has static data types. 
        /// </summary>
        /// <param name="battery"></param>
        /// <returns></returns>
        async Task GoToDetails(BatteryModel battery)
        {
            if (battery == null)
            {
                return;
            }
            await Shell.Current.GoToAsync(nameof(DetailsPage), true, new Dictionary<string, object>
            {
                {"Battery", battery }
            });
        }


    }
}
