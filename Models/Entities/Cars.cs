using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.Models.Entities
{
    public class Cars
    {
        public string Car { get; set; }
        public string Image { get; set; }

        public Cars()
        {

        }

        public Cars(string car, string image)
        {
            Car = car;
            Image = image;
        }

        public static List<Cars> GetCars()
        {
            return new List<Cars>
            {
                new Cars("1970 Chevy Corvette",
                         "https://cdn.dealeraccelerate.com/vanguard/1/2112/247008/1920x1440/1970-chevrolet-corvette-lt-1"),
                new Cars("1979 Chevy Camaro",
                         "https://i.pinimg.com/originals/a7/e7/f1/a7e7f1554a45927bbf24b5af4060c126.jpg"),
                new Cars("1970 Chevy Nova",
                         "https://cdn.classicdigest.com/live/carimg/108101_108200/108118_b_ac04c3c344bb2034.jpg"),
                new Cars("1975 Dodge Charger",
                         "https://live.staticflickr.com/65535/29688027142_9dc011b94b.jpg"),
                new Cars("1972 Pontiac GTO",
                         "https://cdn.barrett-jackson.com/staging/carlist/items/Fullsize/Cars/39697/39697_Front_3-4_Web.jpg")
            };
        }
    }
}
