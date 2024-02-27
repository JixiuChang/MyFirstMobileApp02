using MyFirstMobileApp.Models.DataAccess;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.SQLite;
using System.Collections.ObjectModel;

namespace MyFirstMobileApp.ViewViewModels.SQLite
{
    //ViewModel for managing Vacation data
    public class ArknightViewModel : BaseViewModel
    {
        private readonly SQLiteImplementation _sqliteService = new SQLiteImplementation();

        //Collection to hold vacation data for the UI
        private ObservableCollection<ArknightsSQLite> _arknightsCollection;

        //Property to expose the vacation collection to the UI
        public ObservableCollection<ArknightsSQLite> ArknightsCollection
        {
            get { return _arknightsCollection; }
            set
            {
                _arknightsCollection = value;
                OnPropertyChanged();
                //Debug.WriteLine($"VacationCollection Count: {_vacationCollection?.Count}");
            }
        }

        //Constructor to initialize the ViewModel
        public ArknightViewModel()
        {
            Title = TitleSQLite.myArknightSQLiteTitle;

            //Initialize the vacation collection
            ArknightsCollection = new ObservableCollection<ArknightsSQLite>();

            //Trigger an asynchronous refresh of the vacation list data
            Task.Run(async () => await RefreshArknightsListData());

            _ = RefreshArknightsListData();
        }

        public async Task RefreshArknightsListData()
        {
            // Retrieve vacation data from the SQLite database
            var arknight = await _sqliteService.GetArknight();

            // Update the ViewModel's vacation collection with the new data
            ArknightsCollection = new ObservableCollection<ArknightsSQLite>(arknight);
        }

        //Command to navigate to the VacationMgmtView and handle Adds
        public Command AddCommand
        {
            get
            {
                return new Command<ArknightsSQLite>((ArknightsSQLite arknight) =>
                {
                    //Unsubscribe from events - precautionary step to ensure that there are no existing subscriptions for the specified events
                    MessagingCenter.Unsubscribe<ArknightsSQLite>(this, "AddOperator");

                    //Navigate to the VacationAddView, passing a vacation if available
                    Application.Current.MainPage.Navigation.PushAsync(new ArknightMgmtView(arknight));

                    //Subscribe to a MessagingCenter event for refreshing data when a new vacation is added
                    MessagingCenter.Subscribe<ArknightsSQLite>(this, "AddOperator", async (data) =>
                    {
                        //Refresh the vacation list data asynchronously
                        await RefreshArknightsListData();
                        //Unsubscribe from the MessagingCenter event after refreshing data
                        MessagingCenter.Unsubscribe<ArknightsSQLite>(this, "AddOperator");
                    });
                });
            }
        }

        //Command to navigate to the VacationMgmtView and handle Updates
        public Command UpdateCommand
        {
            get
            {
                return new Command<ArknightsSQLite>((ArknightsSQLite arknight) =>
                {
                    //Unsubscribe from events - precautionary step to ensure that there are no existing subscriptions for the specified events
                    MessagingCenter.Unsubscribe<ArknightsSQLite>(this, "UpdateOperator");

                    //Navigate to the VacationAddView, passing a vacation if available
                    Application.Current.MainPage.Navigation.PushAsync(new ArknightMgmtView(arknight));

                    //Subscribe to a MessagingCenter event for refreshing data when a new vacation is updated
                    MessagingCenter.Subscribe<ArknightsSQLite>(this, "UpdateOperator", async (data) =>
                    {
                        // Refresh the vacation list data asynchronously
                        await RefreshArknightsListData();
                        // Unsubscribe from the MessagingCenter event after refreshing data
                        MessagingCenter.Unsubscribe<ArknightsSQLite>(this, "UpdateOperator");
                    });
                });
            }
        }

        //Command to delete a vacation and update the collection
        public Command<ArknightsSQLite> DeleteCommand
        {
            get
            {
                return new Command<ArknightsSQLite>((ArknightsSQLite arknight) =>
                {
                    //Delete the vacation from the SQLite database
                    _ = _sqliteService.DeleteArknight(arknight.Id);

                    //Remove the vacation from the ViewModel's collection
                    ArknightsCollection.Remove(arknight);
                });
            }
        }
    }
}


/*
                     //Subscribe to a MessagingCenter event for refreshing data when a new vacation is added
                    //MessagingCenter.Subscribe<VacationAddViewModel, Vacation>(this, "AddVacation", async (sender, addedVacation) =>
                    MessagingCenter.Subscribe<Vacation>(this, "AddVacation", async (data) =>
                    {
                        //Refresh the vacation list data asynchronously
                        await RefreshVacationListData();

                        //Unsubscribe from the MessagingCenter event after refreshing data
                        MessagingCenter.Unsubscribe<Vacation>(this, "AddVacation");
                        //MessagingCenter.Unsubscribe<VacationAddViewModel, Vacation>(this, "AddVacation");
                    });
*/