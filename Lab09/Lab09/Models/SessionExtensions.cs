using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Lab09.Models
{
    public static class SessionExtensions
    {
        public static T GetObject<T>(this ISession session, string key)
        {
            string jsonString = session.GetString(key);
            if (string.IsNullOrEmpty(jsonString))
            {
                return default(T);
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(jsonString);
            }
        }

        public static void SetObject<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
    }
}