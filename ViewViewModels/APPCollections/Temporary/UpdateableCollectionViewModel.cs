using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.CollectionsUpdatable.AddEdit;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.CollectionsUpdatable
{
    public class UpdateableCollectionViewModel : BaseViewModel
    {
        public ObservableCollection<MarvelMovies> MovieCollection { get; set; }

        public UpdateableCollectionViewModel()
        {
            //Set the title for this view
            Title = TitleCollections.CollectionTitle;

            //Create a new ObservableCollection to store movies
            MovieCollection = new ObservableCollection<MarvelMovies>();

            //Load movies from the data source
            LoadMovies();
        }

        //Method to load movies from a data source
        private void LoadMovies()
        {
            IsBusy = true;

            try
            {
                //Clear the existing collection
                MovieCollection.Clear();

                //Get a list of Marvel movies and add them to the collection
                var marvelMovies = MarvelMovies.GetMovies();
                foreach (var movie in marvelMovies)
                {
                    MovieCollection.Add(movie);
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

        #pragma warning disable CA1416 // Validate platform compatibility
        //Command to add a new movie
        public ICommand AddCommand => new Command(async () =>
        {
            //Navigate to the AddCollectionView when the "Add" button is clicked

            await Application.Current.MainPage.Navigation.PushAsync(new AddCollectionView());

            //****************************************************************************************
            // A messaging event is a way for different parts of your app to communicate.
            // It's like a message sent from one part to another to share data or trigger actions.
            // MessagingCenter helps subscribe to and send these events.
            // In this code, when you add a movie in AddCollectionView, it sends an "AddMovies" event.
            // UpdateableCollectionWButtonsViewModel listens for this event and updates the movie list.
            //****************************************************************************************
            //Subscribe to the "AddMovies" messaging event to receive updated data from AddCollectionView            
            MessagingCenter.Subscribe<MarvelMovies>(this, "AddMovies", async (data) =>
            {
                //Add the new movie data to the collection
                MovieCollection.Add(data);

                //Unsubscribe from the messaging event
                MessagingCenter.Unsubscribe<MarvelMovies>(this, "AddMovies");
            });
        });

        //Command to update a movie
        public ICommand UpdateCommand => new Command<MarvelMovies>(async movie =>
        {
            //Get the index of the selected movie in the collection
            var index = MovieCollection.IndexOf(movie);

            //Navigate to the EditCollectionView to edit the selected movie when the Update Button is Clicked
            await Application.Current.MainPage.Navigation.PushAsync(new EditCollectionView(movie));

            //****************************************************************************************
            // A messaging event is a way for different parts of your app to communicate.
            // It's like a message sent from one part to another to share data or trigger actions.
            // MessagingCenter helps subscribe to and send these events.
            // In this code, when you update a movie in EditCollectionView, it sends an "UpdateMovies" event.
            // UpdateableCollectionWButtonsViewModel listens for this event and updates the movie list.
            //****************************************************************************************
            //Subscribe to the "UpdateMovies" messaging event to receive updated data from EditCollectionView            
            MessagingCenter.Subscribe<MarvelMovies>(this, "UpdateMovies", updatedMovie =>
            {
                //Update the movie in the collection with the edited data
                MovieCollection[index] = updatedMovie;
            });
        });

        //Command to delete a movie
        public ICommand DeleteCommand => new Command<MarvelMovies>(movie =>
        {
            //Remove the selected movie from the collection
            MovieCollection.Remove(movie);
        });
        #pragma warning restore CA1416 // Validate platform compatibility

    }
}
