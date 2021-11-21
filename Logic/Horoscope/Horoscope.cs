using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
     public class Horoscope
     {
          private const string k_USCulture = "en-US";

          public string DateRange { get; set; }

          public string CurrentDate { get; set; }

          public string Description { get; set; }

          public string Compatibility { get; set; }

          public string Color { get; set; }

          public string LuckyNumber { get; set; }

          public string LuckyTime { get; set; }

          public string Mood { get; set; }

          public static Horoscope JsonHoroscopeSerializer(string i_Json)
          {
               Horoscope horoscope = new Horoscope();
               string[] horoscopeParams = i_Json.Split('\"', ':');
               string prevParam = "";

               foreach (string param in horoscopeParams)
               {
                    if (param.Equals(":") || param.Equals(", ") || param.Equals("{") || param.Equals("}")
                       || param.Equals(" ") || param.Equals("") || param.Contains("\""))
                    {
                         continue;
                    }

                    setParamInHoroscopeObject(param, prevParam, ref horoscope);
                    Console.WriteLine(horoscope.Description);
                    prevParam = param;
               }

               return horoscope;
          }

          private static void setParamInHoroscopeObject(string i_Param, string i_PrevParam, ref Horoscope i_IoHoroscope)
          {
               if (i_PrevParam.Contains("color"))
               {
                    i_IoHoroscope.Color = i_Param;
               }
               else if (i_PrevParam.Contains("compatibility"))
               {
                    i_IoHoroscope.Compatibility = i_Param;
               }
               else if (i_PrevParam.Contains("current_date"))
               {
                    i_IoHoroscope.CurrentDate = i_Param;
               }
               else if (i_PrevParam.Contains("date_range"))
               {
                    i_IoHoroscope.DateRange = i_Param;
               }
               else if (i_PrevParam.Contains("description"))
               {
                    i_IoHoroscope.Description = i_Param;
               }
               else if (i_PrevParam.Contains("lucky_number"))
               {
                    i_IoHoroscope.LuckyNumber = i_Param;
               }
               else if (i_PrevParam.Contains("lucky_time"))
               {
                    i_IoHoroscope.LuckyTime = i_Param;
               }
               else if (i_PrevParam.Contains("mood"))
               {
                    i_IoHoroscope.Mood = i_Param;
               }
          }

          public override string ToString()
          {
               return $@"Color: {Color}
compatibility: {Compatibility}
current_date: {CurrentDate}
date_range: {DateRange}
description: {Description}
lucky_number: {LuckyNumber}
lucky_time: {LuckyTime}
mood: {Mood}
";
          }

          public static string GetUserSign(string i_UserBirthday)
          {
               string sign;
               DateTime birthDay = DateTime.Parse(i_UserBirthday,
                    new CultureInfo(k_USCulture, false));
               int month = birthDay.Month;
               int day = birthDay.Day;

               if ((day >= 22 && day <= 31 && month == 12) || (day >= 1 && day <= 19 && month == 1))
               {
                    sign = "capricorn";
               }
               else if ((day >= 20 && day <= 31 && month == 1) || (day >= 1 && day <= 18 && month == 2))
               {
                    sign = "aquarius";
               }
               else if ((day >= 19 && day <= 29 && month == 2) || (day >= 1 && day <= 20 && month == 3))
               {
                    sign = "pisces";
               }
               else if ((day >= 21 && day <= 31 && month == 3) || (day >= 1 && day <= 19 && month == 4))
               {
                    sign = "aries";
               }
               else if ((day >= 20 && day <= 30 && month == 4) || (day >= 1 && day <= 20 && month == 5))
               {
                    sign = "taurus";
               }
               else if ((day >= 21 && day <= 31 && month == 5) || (day >= 1 && day <= 21 && month == 6))
               {
                    sign = "gemini";
               }
               else if ((day >= 22 && day <= 30 && month == 6) || (day >= 1 && day <= 22 && month == 7))
               {
                    sign = "cancer";
               }
               else if ((day >= 23 && day <= 31 && month == 7) || (day >= 1 && day <= 22 && month == 8))
               {
                    sign = "leo";
               }
               else if ((day >= 23 && day <= 31 && month == 8) || (day >= 1 && day <= 22 && month == 9))
               {
                    sign = "virgo";
               }
               else if ((day >= 23 && day <= 30 && month == 9) || (day >= 1 && day <= 22 && month == 10))
               {
                    sign = "libra";
               }
               else if ((day >= 23 && day <= 31 && month == 10) || (day >= 1 && day <= 21 && month == 11))
               {
                    sign = "scorpio";
               }
               else if ((day >= 22 && day <= 30 && month == 11) || (day >= 1 && day <= 21 && month == 12))
               {
                    sign = "sagittarius";
               }
               else
               {
                    sign = null;
               }

               return sign;
          }

          public static async Task<Horoscope> GetHoroscopeForUser(string i_Sign, string i_Day)
          {
               Horoscope result;
               string requestUri = string.Format(
                    "https://sameer-kumar-aztro-v1.p.rapidapi.com/?sign={0}&day={1}",
                    i_Sign,
                    i_Day);
               HttpClient client = new HttpClient();
               HttpRequestMessage request = new HttpRequestMessage
               {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(requestUri),
                    Headers =
                                                           {
                                                                {
                                                                     "x-rapidapi-host",
                                                                     "sameer-kumar-aztro-v1.p.rapidapi.com"
                                                                },
                                                                {
                                                                     "x-rapidapi-key",
                                                                     "78ea4d9a4bmsh5e767f4398e08c9p1bd615jsn636a206c0fea"
                                                                },
                                                           },
               };

               using (HttpResponseMessage response = await client.SendAsync(request))
               {
                    response.EnsureSuccessStatusCode();
                    string body = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(body);
                    result = Horoscope.JsonHoroscopeSerializer(body);
               }

               return result;
          }
     }
}
