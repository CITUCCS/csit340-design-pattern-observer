
using WeatherObserver;

var weatherStation = new WeatherStation();
var phone = new PhoneDisplay(weatherStation);
var tv = new TvDisplay(weatherStation);

weatherStation.Add(phone);
weatherStation.Add(tv);

weatherStation.Temperature = 61;
weatherStation.Temperature = 62;
weatherStation.Temperature = 63;
weatherStation.Temperature = 64;
