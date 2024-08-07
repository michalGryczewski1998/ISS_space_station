using ISS_space_station.Interfaces;
using ISS_space_station.Models.IIS;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Xml;

namespace ISS_space_station.Services
{
    public class DownloadServices : IDownload
    {
        private readonly string _url = "https://api.wheretheiss.at/v1/satellites/25544";

        public async Task<SpaceStationDetails> GetData()
        {
            HttpResponseMessage message;
            string responseBody = string.Empty;
            SpaceStationDetails details;
            try
            {
                using HttpClient client = new();
                message = await client.GetAsync(this._url);  
                responseBody = await message.Content.ReadAsStringAsync();

                var json = JObject.Parse(responseBody);
                if (message.IsSuccessStatusCode && json != null)
                {
                    details = new()
                    {
                        Name = (string)json["name"],
                        Id = (int)json["id"],
                        Latitude = (double)json["latitude"],
                        Longitude = (double)json["longitude"],
                        Altitude = (double)json["altitude"],
                        Velocity = (double)json["velocity"],
                        Visibility = (string)json["visibility"],
                        Footprint = (double)json["footprint"],
                        Timestamp = (double)json["timestamp"],
                        Daynum = (double)json["daynum"],
                        SolarLat = (double)json["solar_lat"],
                        SolarLong = (double)json["solar_lon"],
                        Units = (string)json["units"],
                    };

                    return details;
                }

            }
            catch(Exception ex) 
            {
                Console.WriteLine("Wystąpił błąd: " + ex.Message);
            }           

            return new SpaceStationDetails();
        }
    }
}
