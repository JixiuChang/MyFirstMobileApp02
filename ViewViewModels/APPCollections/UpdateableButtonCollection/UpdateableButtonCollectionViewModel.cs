using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.APPCollections.UpdateableButtonCollection
{
    public class UpdateableButtonCollectionViewModel : BaseViewModel
    {
        public ObservableCollection<Arknights> ArknightsCollection { get; set; }

        public UpdateableButtonCollectionViewModel()
        {
            Title = TitleAPPCollections.myUpdateableButtonTitle;

        }
    }
}
