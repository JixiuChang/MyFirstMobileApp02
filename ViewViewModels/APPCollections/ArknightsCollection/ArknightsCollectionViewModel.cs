using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.APPCollections.ArknightsCollection
{
    internal class ArknightsCollectionViewModel
    {
        private List<Arknights> _arknights;
        public ObservableCollection<Arknights> ArknightsCollection { get; }
        public string Title { get; set; } = string.Empty;

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
