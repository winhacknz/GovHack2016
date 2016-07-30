using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace WinHackNZ.Helper
{
    public class PersonalValues
    {
        public PersonalValues(NameValueCollection dataParameters)
        {
             LifeSatisfaction  = int.Parse(dataParameters["life_sat"]);
             HouseSatisfaction = int.Parse(dataParameters["house_sat"]);
             RegionalCrime     = int.Parse(dataParameters["region_crime"]);
             HealthRating      = int.Parse(dataParameters["health_rating"]);
             EmploymentRate    = int.Parse(dataParameters["employ_rate"]) ;
        }

        public int LifeSatisfaction { get; set; }
        public int HouseSatisfaction { get; set; }
        public int RegionalCrime { get; set; }
        public int HealthRating { get; set; }
        public int EmploymentRate { get; set; }
    }
}