using static System.Console;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            // Compare the name lengths
            int result = x.Name.Length.CompareTo(y.Name.Length);

            // if they are equal length
            if (result == 0)
            {
                // compare by the names
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                // otherwise compare lengths
                return result;
            }
        }
    }
}