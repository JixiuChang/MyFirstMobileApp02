using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.SQLLite
{
    internal class SQLLiteViewModel : BaseViewModel
    {
        public SQLLiteViewModel() 
        {
            Title = TitleMain.mySQLLiteButtonText;
        }
    }
}
