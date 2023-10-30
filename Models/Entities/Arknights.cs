using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.Models.Entities
{
    public class Arknights
    {
        public string NameOfOperator { get; set; }

        public ImageSource EditButton { get; } = Buttons.ButtonEdit;
        public ImageSource DeleteButton { get; } = Buttons.ButtonDelete;

        public Arknights() { }

        public Arknights(string name) 
        {
            NameOfOperator = name;
        }

        public static List<Arknights> GetOperators()
        {
            return new List<Arknights>
            {
                new Arknights("Amiya"),
                new Arknights("Eunectus"),
                new Arknights("Exusiai"),
                new Arknights("Eyjafjalla"),
                new Arknights("Goldenglow"),
                new Arknights("Mizuki"),
                new Arknights("Pallas"),
                new Arknights("Shining")
            };
        }
    }
}
