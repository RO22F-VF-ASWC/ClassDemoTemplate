using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    /// <summary>
    /// Silly class with only one method
    /// </summary>
    public class SomeClass
    {
        /// <summary>
        /// Silly method to mulitply a number with a number value in a string
        /// </summary>
        /// <param name="x">the value to be multiplied</param>
        /// <param name="n">a string which must be '2' or '3'</param>
        /// <returns>the value of n multiplied by the value of n</returns>
        /// <exception cref="ArgumentNullException">If the n is null or empty</exception>
        /// <exception cref="ArgumentException">if the n is not either '2' or '3' </exception>
        public int SomeMethod(int x, String n)
        {
            if (string.IsNullOrWhiteSpace(n)) throw new ArgumentNullException("n must have a value but was null or empty");
            if (!(n == "2" || n == "3")) throw new ArgumentException("Only '2' or '3' is supported but was " + n);

            switch (n)
            {
                case "2": return x * 2;
                case "3": return x * 3;
            }

            return -1;
        }
    }
}
