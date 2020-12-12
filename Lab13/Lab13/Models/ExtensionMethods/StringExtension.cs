using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab13.Models

    public static class StringExtension
{
    public static int ToInt(this string s)
    {
        int.TryParse(s, out int id);
        return id;
    }
}
}