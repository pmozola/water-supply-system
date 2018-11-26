using System.Threading.Tasks;
using WaterSystemAPI.Controllers;

namespace WaterSystemAPI.Hubs
{
    public interface ITypedHubClient
    {
        Task BroadcastMessage(Measurement currentTemperature);
    }
}