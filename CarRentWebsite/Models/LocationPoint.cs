using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CarRentWebsite.Models
{
    public class LocationPoint : Point
    {
        [JsonConstructor]
        public LocationPoint(double latitude, double longitude, int srid = 4326)
        :base(new Coordinate(longitude, latitude))
        {
            SRID = srid;
        }
    }
}
