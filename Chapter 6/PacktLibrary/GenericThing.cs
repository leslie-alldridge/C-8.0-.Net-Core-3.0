using System;

namespace Packt.Shared
{
    public class GenericThing<T> where T : IComparable
        /* 
        GenericThing has a generic type parameter named T, which
        can be any type that implements IComparable, so it must have a
        method named CompareTo that returns 0 if two objects are equal.
        By convention, name the type parameter T if there is only one type
        parameter.

        GenericThing has a T field named Data.

        GenericThing has a method named Process that accepts a T input
        parameter, and returns a string value.

        */
    {
        public T Data = default(T);
        public string Process(T input)
        {
            if (Data.CompareTo(input) == 0)
            {
                return "Data and input are the same";
            }
            else
            {
                return "Data and input are NOT the same";
            }
        }
    }
}