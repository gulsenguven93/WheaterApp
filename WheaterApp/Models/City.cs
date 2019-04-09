using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheaterApp.Models
{
    public class City
    {
        public string title { get; set; }
        public string location_type { get; set; }
        public int woeid { get; set; }
        public string latt_long { get; set; }

        public List<City> getList()
        {
            return new List<City>()
            {
                new City(){title="Istanbul",woeid=2344116 },
                new City(){title="Izmır",woeid=2344117 },
                new City(){title="Ankara",woeid=2343732 },
                new City(){title="Sofia",woeid=839722 },
                new City(){title="London",woeid=44418 }

            };
        }
    }
}
