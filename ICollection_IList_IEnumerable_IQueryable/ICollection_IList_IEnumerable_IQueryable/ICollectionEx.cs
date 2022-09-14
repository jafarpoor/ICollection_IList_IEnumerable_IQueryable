using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ICollection_IList_IEnumerable_IQueryable
{
    //ICollection
    //Collection<T>
    //IEnumerable is that ICollection is a write operation and IEnumerable is a read-only operation only meant for iteration
    internal class ICollectionEx
    {
        public static void CheckCollection()
        {
            List<string> monthsofYear = new List<string>
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            //casted to ICollection    
            ICollection<string> collection = monthsofYear;
            Console.WriteLine(collection.Count);
        } 
    }
}
