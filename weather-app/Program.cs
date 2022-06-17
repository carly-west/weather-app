using System;
using System.Text.Json;
using System.Text.Json.Serialization;



namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting up data
            Dictionary<string, Dictionary<string, string>> weatherDictionary =
            new Dictionary<string, Dictionary<string, string>>
                {
                    {
                        "Monday",
                        new Dictionary<string, string>
                        {
                            {"high", "70"},
                            {"low", "45"},
                            {"wind", "14"},
                            {"precipitation", "20"},
                            {"humidity", "36"}
                        }
                    },
                    {
                        "Tuesday",
                        new Dictionary<string, string>
                        {
                            {"high", "76"},
                            {"low", "48"},
                            {"wind", "11"},
                            {"precipitation", "10"},
                            {"humidity", "29"}
                        }
                    },
                    {
                        "Wednesday",
                        new Dictionary<string, string>
                        {
                            {"high", "68"},
                            {"low", "40"},
                            {"wind", "13"},
                            {"precipitation", "0"},
                            {"humidity", "34"}
                        }
                    },
                    {
                        "Thursday",
                        new Dictionary<string, string>
                        {
                            {"high", "87"},
                            {"low", "58"},
                            {"wind", "14"},
                            {"precipitation", "0"},
                            {"humidity", "27"}
                        }
                    },
                    {
                        "Friday",
                        new Dictionary<string, string>
                        {
                            {"high", "89"},
                            {"low", "56"},
                            {"wind", "19"},
                            {"precipitation", "20"},
                            {"humidity", "24"}
                        }
                    },
                    {
                        "Satday",
                        new Dictionary<string, string>
                        {
                            {"high", "84"},
                            {"low", "56"},
                            {"wind", "16"},
                            {"precipitation", "20"},
                            {"humidity", "30"}
                        }
                    },
                    {
                        "Sunday",
                        new Dictionary<string, string>
                        {
                            {"high", "72"},
                            {"low", "45"},
                            {"wind", "17"},
                            {"precipitation", "20"},
                            {"humidity", "34"}
                        }
                    }

          };
            Console.WriteLine("Hello World");

            Console.WriteLine("Welcome to the Weather App! Input any other letter or number to exit.");

            var continueApp = true;
            while (continueApp == true) {
                Console.WriteLine("What day would you like to learn about?");
                Console.WriteLine("1- Monday");
                Console.WriteLine("2- Tuesday");
                Console.WriteLine("3- Wednesday");
                Console.WriteLine("4- Thursday");
                Console.WriteLine("5- Friday");
                Console.WriteLine("6- Saturday");
                Console.WriteLine("7- Sunday");
              
                var dayChoiceNum = Console.ReadLine();
                string dayChoice = "Mon";

                switch(dayChoiceNum)
                {
                    case "1":
                        dayChoice = "Monday";
                        break;
                    case "2":
                        dayChoice = "Tuesday";
                        break;
                    case "3":
                        dayChoice = "Wednesday";
                        break;
                    case "4":
                        dayChoice = "Thursday";
                        break;
                    case "5":
                        dayChoice = "Friday";
                        break;
                    case "6":
                        dayChoice = "Satday";
                        break;
                    case "7":
                        dayChoice = "Sunday";
                        break;
                    default:
                        continueApp = false;
                        break;
                }

                if (continueApp == true) {
                    Console.WriteLine("What would you like to learn about?");
                    Console.WriteLine("1- High");
                    Console.WriteLine("2- Low");
                    Console.WriteLine("3- Wind");
                    Console.WriteLine("4- Precipitation");
                    Console.WriteLine("5- Humidity");

                    var weatherChoiceNum = Console.ReadLine();
                    string weatherChoice = "High";

                    switch (weatherChoiceNum)
                    {
                        case "1":
                            weatherChoice = "high";
                            break;
                        case "2":
                            weatherChoice = "low";
                            break;
                        case "3":
                            weatherChoice = "wind";
                            break;
                        case "4":
                            weatherChoice = "precipitation";
                            break;
                        case "5":
                            weatherChoice = "humidity";
                            break;
                        default:
                            continueApp = false;
                            break;
                    }


                    foreach (KeyValuePair<string, Dictionary<string, string>> day in weatherDictionary)
                    {
             
                        if (day.Key == dayChoice)
                        {
         
                            foreach (KeyValuePair<string, string> weather in day.Value)
                            {

                                if (weather.Key == weatherChoice)
                                {
                                    Console.WriteLine("day.Key = " + day.Key);
                                    Console.WriteLine("day.Value = " +  day.Value);
                                    Console.WriteLine("weather.Key = " +  weather.Key);
                                    Console.WriteLine("weather.Value = " + weather.Value);


                                    string addition = "degrees.";
                                    //Console.WriteLine(day.Key, weather.Value);

                                    switch (weather.Key)
                                    {
                                        case "wind":
                                            addition = "mph.";
                                            break;
                                        case "precipitation":
                                            addition = "percent.";
                                            break;
                                        case "humidity":
                                            addition = "percent.";
                                            break;
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("The " + weather.Key + " for " + day.Key + " is " + weather.Value + " " + addition);
                                    Console.WriteLine();
                                }
                            }
                        }
                       

                    }

                }


            }

        }

        

        
    }

}

