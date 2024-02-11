// See https://aka.ms/new-console-template for more information

// TODO: - C# Observer pattern
//       - weather service integration 

using WeatherStation;

var data = new WeatherData();
var display = new DisplayCurrentConditions(data);

data.SetMeasurements(-10,65,29.2f);