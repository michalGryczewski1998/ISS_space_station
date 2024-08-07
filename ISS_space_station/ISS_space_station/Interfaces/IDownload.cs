using ISS_space_station.Models.IIS;

namespace ISS_space_station.Interfaces
{
    public interface IDownload
    {
        Task<SpaceStationDetails> GetData();
    }
}
