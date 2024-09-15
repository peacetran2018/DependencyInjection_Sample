using ServiceContracts;

namespace Services;
public class CitiesService : ICitiesService
{
    private List<string> _cities;
    private Guid _serviceIntanceId;

    public Guid ServiceInstance {
        get{
            return _serviceIntanceId;
        }
    }

    public CitiesService(){
        _serviceIntanceId = Guid.NewGuid();
        _cities = new List<string>(){
            "Vietnam",
            "Singapore",
            "Australia",
            "Japan",
            "USA"
        };
    }

    public List<string> GetCities(){
        return _cities;
    }
}
