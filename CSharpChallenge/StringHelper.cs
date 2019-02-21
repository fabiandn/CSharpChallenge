using System;

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

            value = value.Replace("%", "");
            var result = 0D;

            if (!double.TryParse(value, out result))
            {
                return false;
            }

            percentage = result/100D;
            return true;
        }
    }
}
