using System.Linq;

namespace Avanssur.Automation.Utils
{
    public static class StringExtensions
    {
        /// <summary>
        /// Trims unit, replaces commas with dots if there is any and returns only float value . 
        /// Example: for string "123,5 km" it returns float 123.5
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float TrimUnit(this string value)
        {
            return float.Parse(value.Split(' ').First().Replace(',', '.'));
        }
    }
}
