using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace YourNamespace.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
   
    public class LoginCodeController : ControllerBase
    {
        private static readonly Random random = new Random();

        [HttpGet]
        public IEnumerable<StationLogin> Get()
        {
            var stations = new List<StationLogin>();

            for (int i = 1; i <= 10; i++)
            {
                var station = new StationLogin
                {
                    StationName = $"Station {i}",
                    LoginId = GenerateRandomString(8),
                    LoginCode = GenerateRandomNumber(8)
                };

                stations.Add(station);
            }

            return stations;
        }

        private static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static string GenerateRandomNumber(int length)
        {
            const string numbers = "0123456789";
            return new string(Enumerable.Repeat(numbers, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

