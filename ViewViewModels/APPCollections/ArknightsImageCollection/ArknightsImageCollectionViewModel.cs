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

namespace MyFirstMobileApp.ViewViewModels.APPCollections.ArknightsImageCollection
{
    public class ArknightsImageCollectionViewModel : BaseViewModel
    {
        public ObservableCollection<OperatorInfo> OperatorsCollection { get; }

        private List<OperatorInfo> _operators;

        public ArknightsImageCollectionViewModel()
        {
            Title = TitleAPPCollections.myArknightsImageCollectionTitle;

            OperatorsCollection = new ObservableCollection<OperatorInfo>();
            _operators = OperatorInfo.GetSampleOperatorData();
            this.LoadOperators();
        }

        private void LoadOperators()
        {
            try
            {
                OperatorsCollection.Clear();
                foreach (var op in _operators)
                {
                    OperatorsCollection.Add(op);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
