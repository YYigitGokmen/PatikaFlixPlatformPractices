using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaflixSeriesPlatformPractice
{
    
    public class Series
    {
        public string seriesName { get; set; }
        public int productionYear { get; set; }
        public string type { get; set; }
        public int startDate { get; set; }
        public string directors { get; set; }
        public string firstPlatformPublished { get; set; }

    }
    

    public class ComedySerie
    {

        public string seriesName { get; set; }

        public string type { get; set; }

        public string directors { get; set; }


    }
}
