using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Lab13.Models
{
    public static class StringExtension
    {
        public static string Slug(this string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                if (!char.IsPunctuation(c) || c = '-')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString().Replace(' ', '-').ToLower();
        }

        public static int ToInt(this string s)
        {
            int.TryParse(s, out int id);
            return id;
        }
    }
}