using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_example
{
    class RegexEx
    {
        static void Main(string[] args)
        {
             
            string s = "app360,logixml ";
            Console.WriteLine(IsValidComponentName(s));
        }

        protected const string GetComponentName = @"(^app360$|^app360edatabase$|^ensemble$|^gps$|^logixml$|^service360$|^sts$|^webcrs$|^webcvconfig$)";
        protected const string GetComponentNames = @"(app360|app360edatabase|ensemble|gps|logixml|service360|sts|webcrs|webcvconfig)|(\w)";
        protected static bool IsValidComponentName(string component)
        {
            bool isvalid = true;
            string[] coms = component.Split(new[] { ',' });
            if (coms.Length==1)
            {
                Regex reg = new Regex(GetComponentName);
                isvalid = reg.IsMatch(component.ToLower().Trim());
            }
            else
            {
                Regex reg = new Regex(GetComponentNames);
                MatchCollection matches = reg.Matches(component);
                foreach (Match item in matches)
                {
                    if (item.Success)
                    {
                        if (!string.IsNullOrEmpty(item.Groups[2].Value))
                        {
                            isvalid = false;
                            break;
                        }
                    }
                }
            }

            return isvalid;
        }


        protected const string _RegExGetCharNames = @"     ";
        protected List<string> GetAllChars(string text)
        {
            List<string> result = new List<string>();
             
             
            Regex regex = new Regex(_RegExGetCharNames);

            MatchCollection matches = regex.Matches(text);
            foreach (Match item in matches)
            {
                if (item.Success)
                {
                    if (item.Groups.Count > 1)
                    {
                        string name = item.Groups[1].Value;
                        result.Add(name);
                    }
                }
            }
            return result;
        }
    }
}
