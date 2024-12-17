using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Solid_Principle
{
    internal class FileLogger
    {
        public void Log(string message)
        {
            File.AppendAllText(@"logs/Error.txt", $"{message}\n");

        }
    }
}
