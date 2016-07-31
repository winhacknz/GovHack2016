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
             LifeSatisfaction  = float.Parse(dataParameters["life_sat"]);
             HouseSatisfaction = float.Parse(dataParameters["house_sat"]);
             RegionalCrime     = float.Parse(dataParameters["region_crime"]);
             HealthRating      = float.Parse(dataParameters["health_rating"]);
             EmploymentRate    = float.Parse(dataParameters["employ_rate"]) ;
        }

        public PersonalValues() { }

        public float LifeSatisfaction { get; set; }
        public float HouseSatisfaction { get; set; }
        public float RegionalCrime { get; set; }
        public float HealthRating { get; set; }
        public float EmploymentRate { get; set; }        
        public float TotalWeighting { get; internal set; }
    }
}