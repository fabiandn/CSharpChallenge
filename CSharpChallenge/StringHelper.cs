using System;
using System.Text.RegularExpressions;

namespace CSharpChallenge
{
    /// <summary>
    /// Define a class helper
    /// </summary>
    public class StringHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool TryParsePercentage(string value, out double percentage) {
            percentage = 0D;
            
            if (value == null)
            {
                return false;
            }

            var match = Regex.Match(value, @"(?<Number>\d+\.\d+)\%");
            if(match.Success && double.TryParse(match.Groups["Number"].Value, out double result)) {
                percentage = result/100D;
                return true;
            }
            
            return false;
        }
    }
}
