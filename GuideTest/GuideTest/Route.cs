using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideTest
{
    public class Route
    {
        private string routeName;

        public string RouteName
        {
            get { return routeName; }
            set { routeName = value; }
        }

        private string routeNum;

        public string RouteNum
        {
            get { return routeNum; }
            set { routeNum = value; }
        }

        private string grade;

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        private string rating;

        public string Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        private string routelength;

        public string Routelength
        {
            get { return routelength; }
            set { routelength = value; }
        }

        public Route()
        {
            routeName = "";
            routeNum = "";
            grade = "";
            rating = "";
            routelength = "";
            
        }

        public Route(string routeName, string routeNum, string grade)
        {
            this.routeName = routeName;
            this.routeNum = routeNum;
            this.grade = grade;
        }
        
        public Route(string line)
        {
            string[] fields = line.Split(',');
            routeNum = fields[0];
            routeName = fields[1];
            grade = fields[2];
            
        }
        


        public override string ToString()
        {
            return routeNum + "\t" + routeName + "\t" + grade;
        }
    }
}
