using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollection_IList_IEnumerable_IQueryable
{
    public class ISetEX
    {
        public void CheckSet()
        {
            //have not index 
            //value is uniq
            HashSet<int> list = new HashSet<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(2 * i + 1);
            }

            list.Remove(7);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //output
            //1
            //3
            //5
            //9
        }
    }
}
