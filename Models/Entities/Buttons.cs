using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.Models.Entities
{
    public static class Buttons
    {

        //Edit,  Delete & Submit
        public static ImageSource ButtonEdit { get; } = ImageSource.FromFile("Images/ ImageButtons/iconsedit.png");
        public static ImageSource ButtonDelete { get; } = ImageSource.FromFile("Images/ ImageButtons/iconsdelete.png");
        public static ImageSource ButtonSubmit { get; } = ImageSource.FromFile("Images/ ImageButtons/buttonsubmit.png");

        //DatePicker
        public static ImageSource ButtonDatePickerBlue { get; } = ImageSource.FromFile("Images/ ImageButtons/dpbuttonblue.png");
        public static ImageSource ButtonDatePickerRed { get; } = ImageSource.FromFile("Images/ ImageButtons/dpbuttonred.png"); 

        //Picker
        public static ImageSource ButtonPickerBlue { get; } = ImageSource.FromFile("Images/ ImageButtons/buttonblue.png");  
        public static ImageSource ButtonPickerRed { get; } = ImageSource.FromFile("Images/ ImageButtons/buttonred.png"); 
    }
}
