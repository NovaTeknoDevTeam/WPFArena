namespace ValueConverter;

public class Forecast
{
    public enum GeneralForecast
    {
        Sunny,
        Rainy,
        Snowy,
        Cloudy,
        Dry
    }
    
    public GeneralForecast generalForecast { get; set; }
    public double temperatureHigh { get; set; }
    public double temperatureLow { get; set; }
    public double precipitation { get; set; }
}