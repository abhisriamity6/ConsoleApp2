using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerwithoutArrayNS
{
    class IndexerwithoutArray
    {
        int maxpower;
        
        public IndexerwithoutArray(int power)
        {
            maxpower = power;
        }
        public bool IsVaild(int size)
        {
            if(size >= 0 & size < maxpower)
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        public int this[int power]
        {
            get
            {
                int result = 1;
                for(int i =0; i<power;i++)
                {
                    result = result * 2;
                }
                return result;
            }
        }




    }

    class UseIndexerwithoutArray
    {


        static void Main(string[] args)
        {
            IndexerwithoutArray indexerobj = new IndexerwithoutArray(9);
            int PowerOf2;
            for (int i = 0; i < 50; i++)
            {
                if(indexerobj.IsVaild(i))
                {
                    PowerOf2 = indexerobj[i];
                    Console.WriteLine("2 to the Power of {0} = {1} ",i,PowerOf2);
                }

            }

            Console.Read();


        }
    }
}
