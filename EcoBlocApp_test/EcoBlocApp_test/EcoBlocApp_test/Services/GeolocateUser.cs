using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace EcoBlocApp_test.Services
{
    public class GeolocateUser
    {
        double[] temp = { -34.031310, 18.589430 };
        CancellationTokenSource cts;



        public async Task<double[]> GetCurrentLocation()
        {
           // try
           // {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                cts = new CancellationTokenSource();
                var location = await Geolocation.GetLocationAsync(request, cts.Token);

                if (location != null)
                {
                temp[0] = location.Latitude;
                temp[1] = location.Longitude;
                    return temp;
                }
            return temp;
            //}
            //catch (FeatureNotSupportedException fnsEx)
           // {
                // Handle not supported on device exception
            //}
           // catch (FeatureNotEnabledException fneEx)
            //{
            //    // Handle not enabled on device exception
            //}
            //catch (PermissionException pEx)
            //{
            //    // Handle permission exception
            //}
            //catch (Exception ex)
           // {
           //    // Unable to get location
           // }
        }


    }
}
