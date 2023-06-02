using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCase_Cleverence_DS
{
    internal static class Task3Server
    {
        static private int count;

        static private object locker = new object();

        static public int GetCount()
        {
            lock(locker)
            {
                return count;
            }
        }

        static public void AddCount(int value)
        {
            lock(locker)
            {
                count += value;
            }
        }

    }
}
