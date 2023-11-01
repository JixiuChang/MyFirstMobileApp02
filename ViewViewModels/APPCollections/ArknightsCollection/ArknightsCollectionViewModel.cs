using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.APPCollections.ArknightsCollection
{
    internal class ArknightsCollectionViewModel : BaseViewModel
    {
        private List<Arknights> _arknights;
        public ObservableCollection<Arknights> ArknightsCollection { get; }

        public ArknightsCollectionViewModel() {
            Title = TitleAPPCollections.myArknightsCollectionTitle;

            ArknightsCollection = new ObservableCollection<Arknights>();

            _arknights = Arknights.GetOperators();
            this.LoadOperator();
        }

        private void LoadOperator()
        {
            try
            {
                ArknightsCollection.Clear();

                foreach (var x in _arknights)
                {
                    ArknightsCollection.Add(new Arknights { NameOfOperator = x.NameOfOperator});
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
