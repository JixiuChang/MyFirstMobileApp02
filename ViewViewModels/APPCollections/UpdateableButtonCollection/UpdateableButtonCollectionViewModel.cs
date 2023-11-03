using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.CollectionsUpdatable.AddEdit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.APPCollections.UpdateableButtonCollection
{
    public class UpdateableButtonCollectionViewModel : BaseViewModel
    {
        public ObservableCollection<Arknights> ArknightsCollection { get; set; }

        public UpdateableButtonCollectionViewModel()
        {
            Title = TitleAPPCollections.myUpdateableButtonTitle;

            ArknightsCollection = new ObservableCollection<Arknights>();

            LoadArknights();
        }

        private void LoadArknights()
        {
            IsBusy = true;

            try
            {
                ArknightsCollection.Clear();

                var myOperators = Arknights.GetOperators();
                foreach (var op in myOperators)
                {
                    ArknightsCollection.Add(op);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        #pragma warning disable CA1416
        public ICommand AddCommand => new Command(async () =>
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AddCollectionView());           
            MessagingCenter.Subscribe<Arknights>(this, "AddOperator", async (data) =>
            {
                ArknightsCollection.Add(data);

                MessagingCenter.Unsubscribe<Arknights>(this, "AddOperator");
            });
        });

        public ICommand UpdateCommand => new Command<Arknights>(async thisOperator =>
        {
            var index = ArknightsCollection.IndexOf(thisOperator);

            await Application.Current.MainPage.Navigation.PushAsync(new EditCollectionView(thisOperator));
            
            MessagingCenter.Subscribe<Arknights>(this, "UpdateOperator", updatedOperator =>
            {
                ArknightsCollection[index] = updatedOperator;
            });
        });

        public ICommand DeleteCommand => new Command<Arknights>(thisOperator =>
        {
            //Remove the selected movie from the collection
            ArknightsCollection.Remove(thisOperator);
        });
        #pragma warning restore CA1416
    }
}
