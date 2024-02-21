using MyFirstMobileApp.Models.DataAccess;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;

namespace MyFirstMobileApp.ViewViewModels.SQLite
{
    public class ArknightMgmtViewModel : BaseViewModel
    {
        //Properties to bind to the UI
        public List<ArknightsSQLite> ArknightCollection { get; set; }
        public string OperatorName { get; set; }
        public string OperatorOrigin { get; set; }
        public int OperatorOwned { get; set; }
        public int Id { get; set; }

        //Text for the button based on whether it's an update or save operation
        public string ButtonText { get; set; }

        //Create an instance of the SQLiteImplementation class to handle SQLite database operations,
        //and assign it to the private readonly field _sqliteService for use throughout the class.
        //readonly variable ensures it can only be assigned a value at the time of declaration or in the constructor
        private readonly SQLiteImplementation _sqliteService = new SQLiteImplementation();

        //Constructor to initialize the ViewModel with existing vacation details if provided
        public ArknightMgmtViewModel(ArknightsSQLite myArknight)
        {
            //Initialize the collection
            ArknightCollection = new List<ArknightsSQLite>();

            if (myArknight != null)
            {
                Title = TitleSQLite.myArknightSQLiteUpdateTitle;

                //If vacation exists, populate ViewModel properties
                ArknightCollection.Add(myArknight);
                Id = myArknight.Id;
                OperatorName = myArknight.OperatorName;
                OperatorOrigin = myArknight.OperatorOrigin;
                OperatorOwned = myArknight.OperatorOwned;

                ButtonText = "Update";
            }
            else
            {
                Title = TitleSQLite.myArknightSQLiteAddTitle;

                //If no vacation provided, initialize a new one and set button text to "Save"
                ArknightCollection = new List<ArknightsSQLite>();

                ButtonText = "Save";
            }
        }

        //Command for saving or updating vacation details
        public Command<ArknightsSQLite> PerformSave
        {
            get
            {
                return new Command<ArknightsSQLite>(async (ArknightsSQLite myArknight) =>
                {
                    try
                    {
                        //Check for required data before save or update
                        if (string.IsNullOrEmpty(OperatorName) || string.IsNullOrEmpty(OperatorOrigin))
                        {
                            await Application.Current.MainPage.DisplayAlert("Message", "Name and Origin are required.", "Ok");
                            return;
                        }

                        if (ButtonText == "Save")
                        {
                            //Creating a new Vacation instance with ViewModel properties
                            myArknight = new ArknightsSQLite
                            {
                                Id = Id,
                                OperatorName = OperatorName,
                                OperatorOrigin = OperatorOrigin,
                                OperatorOwned = OperatorOwned
                            };

                            //Save the new vacation
                            string result = await _sqliteService.SaveArknight(myArknight);

                            if (result == string.Empty)
                            {
                                //Send a message to notify about the addition of a new vacation
                                MessagingCenter.Send<ArknightsSQLite>(myArknight, "AddArknight");

                                if (Application.Current.MainPage != null)
                                {
                                    await Application.Current.MainPage.Navigation.PopAsync();
                                }
                            }
                            else
                            {
                                await Application.Current.MainPage.DisplayAlert("Message", result, "Ok");
                            }
                        }
                        else
                        {
                            //Creating a new Vacation instance with ViewModel properties for an update
                            myArknight = new ArknightsSQLite
                            {
                                Id = Id,
                                OperatorName = OperatorName,
                                OperatorOrigin = OperatorOrigin,
                                OperatorOwned = OperatorOwned
                            };

                            //Update the existing vacation details
                            bool result = await _sqliteService.UpdateArknight(myArknight);

                            if (result)
                            {
                                //Send a message to notify about the update of the vacation
                                MessagingCenter.Send<ArknightsSQLite>(myArknight, "UpdateArknight");
                                await Application.Current.MainPage.Navigation.PopAsync();
                            }
                            else
                            {
                                await Application.Current.MainPage.DisplayAlert("Message", "Data Failed To Update", "Ok");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
                    }
                });
            }
        }
    }
}
