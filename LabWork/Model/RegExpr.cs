using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LabWork.Model
{
    public static class RegExpr
    {
        public static bool IsNameVld(string name)
        {
            
            if (string.IsNullOrEmpty(name) || name.Length > 20) { return false; }
            return true;
        }
        public static bool IsPriceVld(double? price)
        {
            if (price == null || price <= 0) {return false; }
            return true;
        }
        public static bool IsDescVld(string desc)
        {
            if(string.IsNullOrEmpty(desc) || desc.Length > 20) { return false; }
            return true;
        }
    }
}
