using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class Demo
    {
        public void x1()

        {
            Dictionary<string, object> s = new Dictionary<string, object>();

            s.Add("mahesh", 554433d);

            s.Add("sureah", "ramya");

            foreach (string m in s.Keys) 

            Console.WriteLine(m + "=="+s[m]);









        }

    }

}


