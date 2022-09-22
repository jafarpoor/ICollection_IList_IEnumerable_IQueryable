using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollection_IList_IEnumerable_IQueryable
{
   public class IDictionaryEX
    {
        public void CheckDictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "one");
            dict.Add(2, "Two");


            foreach (var item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

        }
    }
}
