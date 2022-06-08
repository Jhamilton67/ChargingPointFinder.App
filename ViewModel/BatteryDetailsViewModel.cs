using ChargingPointFinder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChargingPointFinder.ViewModel
{
    [QueryProperty(nameof(BatteryModel), "Battery")]
    public partial class BatteryDetailsViewModel : BaseViewModel
    {
        IMap map;

        public BatteryDetailsViewModel(IMap map)
        {
            this.map = map;
        }

        
        [ICommand]
        async Task OpenMap()
        {
            try
            {
                await map.OpenAsync(BatteryModel.Latiitude, BatteryModel.Longitude, new MapLaunchOptions
                {
                    Name = BatteryModel.Name,
                    NavigationMode = NavigationMode.None

                });
            }
            catch (Exception ex)
            {

            }
        }
    }
}
