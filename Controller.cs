using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dane
{
    class Controller
    {
        public Controller()
        {

        }

        public string[] LinesCSV()
        {
            return File.ReadAllLines("./data/data.csv");
        }
    }
}
