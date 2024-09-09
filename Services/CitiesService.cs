namespace Serivces;
public class CitiesService
{
    private List<string> _cities;

    public CitiesService(){
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
