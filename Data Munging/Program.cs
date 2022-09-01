// See https://aka.ms/new-console-template for more information
using Data_Munging;

//1. Weather Data
Weather weather = new Weather();
Console.WriteLine("Day with smallest temperature spread : "+weather.WeatherDayMin());

//2. Football Data
Football football = new Football();
Console.WriteLine("Team with the smallest difference in goals : " + football.TeamWithSmallDiff());