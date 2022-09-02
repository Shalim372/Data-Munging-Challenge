// See https://aka.ms/new-console-template for more information
using Data_Munging;

//1. Weather Data
Weather weather = new Weather();
Console.WriteLine("1. Day with smallest temperature spread : "+weather.WeatherDayMin());

//2. Football Data
Soccer soccer = new Soccer();
Console.WriteLine("2. Team with the smallest difference in goals : " + soccer.TeamWithSmallDiff());