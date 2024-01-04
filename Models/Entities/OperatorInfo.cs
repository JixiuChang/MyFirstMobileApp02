using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.Models.Entities
{
    public class OperatorInfo
    {
        public string OperatorName { get; set; } = string.Empty;
        public ImageSource OperatorImage { get; set; } = null;
        public string OperatorOrigin { get; set; } = string.Empty;

        public OperatorInfo()
        {
            //Base Constructor
        }

        public OperatorInfo(string operatorName, ImageSource operatorImage, string operatorOrigin)
        {
            OperatorName = operatorName;
            OperatorImage = operatorImage;
            OperatorOrigin = operatorOrigin;
        }

        public static List<OperatorInfo> GetSampleOperatorData()
        {
            var actors = new List<OperatorInfo>
            {
                new OperatorInfo("Eyjafjalla", ImageSource.FromFile("Images/eyjafjalla_splashart.jpg"), "Leithania"),
                new OperatorInfo("SilverAsh", ImageSource.FromFile("Images/silverash_splashart.jpg"), "Karlan"),
                new OperatorInfo("Thorn", ImageSource.FromFile("Images/thorn_splashart.jpg"), "Iberia"),
                new OperatorInfo("Skadi", ImageSource.FromFile("Images/skadi_splashart.jpg"), "Abyss"),
                new OperatorInfo("Exusiai", ImageSource.FromFile("Images/exusiai_splashart.jpg"), "Laterano"),
                new OperatorInfo("Eyjafjalla, The Hvít Aska", ImageSource.FromFile("Images/eyjafjalla_alt_splashart.jpg"), "Leithania")
            };

            return actors;
        }

        public static List<string> GetOperatorNames()
        {
            var sampleData = GetSampleOperatorData();

            return sampleData.Select(info => info.OperatorName).ToList();
        }
    }
}
