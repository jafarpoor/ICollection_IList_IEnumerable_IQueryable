using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollection_IList_IEnumerable_IQueryable
{
    /// <summary>
    /// add-remove
    /// </summary>
    public class IListEx
    {

        public void CheckList()
        {
            //without toList
            var items = new List<string> { "aa", "bbb", "cc", "dddd" };
            var moreItems = items.Where(p => p.Length > 3);
            items[0] = "aaa";
           // items.Add("ff");
            foreach (var item in moreItems)
            {
                Console.WriteLine(item);
                //output=> aaaa , bbbb , dddd
            }

            //


            //toList
            var items1 = new List<string> { "aa", "bbb", "cc", "dddd" };
            var moreItems1 = items.Where(p => p.Length > 3).ToList();
            items[0] = "aaa";
            foreach (var item in moreItems1)
            {
                Console.WriteLine(item);
                //output=> bbbb , dddd
            }
        }
    }
}
