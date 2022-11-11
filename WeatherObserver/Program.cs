
using WeatherObserver;

var weatherStation = new WeatherStation();
var phone = new PhoneDisplay();
var tv = new TvDisplay();

// Add delegates to the event handler
weatherStation.WeatherEvent += phone.OnWeatherUpdate;
weatherStation.WeatherEvent += tv.OnWeatherUpdate;

weatherStation.Temperature = 61;
weatherStation.Temperature = 62;
weatherStation.Temperature = 63;
weatherStation.Temperature = 64;
