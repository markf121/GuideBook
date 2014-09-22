using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideTest
{
    class Program
    {
        static List<Route> gb = new List<Route>();

        static void PrintRoutes()
        {
            foreach (Route r in gb)
            {
                 Console.WriteLine(r);

            }
        }

        static void LoadRoutes(string filename)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            


            for( int i = 0; i < lines.Count(); i++)
            {
                string line = lines[i];

                Route route = new Route(line);
                gb.Add(route);

            }
            
        }

        static void Main(string[] args)
        {
            string fname;
            fname = "quarrylist.txt";
            LoadRoutes(fname);
            PrintRoutes();
        }

          
    }

}

