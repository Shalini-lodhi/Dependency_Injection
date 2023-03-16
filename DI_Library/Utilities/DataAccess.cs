using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Library.Utilities
{
    internal class DataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading Data");
        }
        public void SaveData(string name)
        {
            Console.WriteLine($"Saving {name}");
        }
    }
}
