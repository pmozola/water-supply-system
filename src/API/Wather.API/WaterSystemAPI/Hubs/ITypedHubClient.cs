using System.Threading.Tasks;
using WaterSystemAPI.Models;

namespace WaterSystemAPI.Hubs
{
    public interface ITypedHubClient
    {
        Task BroadcastMessage(Temperature currentTemperature);
    }
}