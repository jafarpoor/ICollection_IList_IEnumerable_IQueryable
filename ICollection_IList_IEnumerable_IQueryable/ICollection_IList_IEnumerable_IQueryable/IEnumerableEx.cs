using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollection_IList_IEnumerable_IQueryable
{
    internal class IEnumerableEx
    {
        public void CheckIEnumerable()
        {
            //just readonly
            //System.Collections

            //MyDataContext dc = new MyDataContext();
            //IEnumerable<Employee> list = dc.Employees.Where(p => p.Name.StartsWith("S"));
            //list = list.Take<Employee>(10);


            //  SELECT  [t0].[EmpID], [t0].[EmpName], [t0].[Salary]
            // FROM[Employee] AS[t0]
            //WHERE[t0].[EmpName]
            // LIKE @p0


            //Top 10 excute in client side


            ///////////GetEnumerator
            List<string> myList = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                myList.Add("Item " + i.ToString());
            }

            IEnumerator<string> myEnum = myList.GetEnumerator();

            myEnum.Reset();
            myEnum.MoveNext();
            myEnum.MoveNext();
            myEnum.MoveNext();
            System.Console.WriteLine(myEnum.Current);
            myEnum.MoveNext();
            myEnum.MoveNext();
            System.Console.WriteLine(myEnum.Current);

            myEnum.Reset();

            myEnum.MoveNext();

            System.Console.WriteLine(myEnum.Current);

            //output
            //Item 2
            //Item 4
            //Item 0
        }
        
    }

   
}
