// See https://aka.ms/new-console-template for more information
using Data_Munging;

//1. Weather Data
//Weather weather = new Weather();
//Console.WriteLine("1. Day with smallest temperature spread : "+weather.WeatherDayMin());

//2. Football Data
//Soccer soccer = new Soccer();
//Console.WriteLine("2. Team with the smallest difference in goals : " + soccer.TeamWithSmallDiff());

//3. Dry Fusion
string path = Path.GetFullPath(@"S:\New folder\");

Console.WriteLine("Day: " + ProcessData.FindLowestData(path + "weather.dat", 1, 2, 0));
Console.WriteLine("Team: " + ProcessData.FindLowestData(path + "football.dat", 6, 8, 1));