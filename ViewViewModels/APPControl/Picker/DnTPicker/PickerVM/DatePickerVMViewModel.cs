using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.APPControl.Picker.DnTPicker.PickerVM
{
    public class DatePickerVMViewModel : BaseViewModel
    {
        public ImageSource SubmitButton { get; } = "Images/buttonsubmit.png";

        public ICommand SubmitCommand => new Command(OnSubmit);

        private DateTime _startDate;
        private DateTime _minStartDate;
        private DateTime _endDate;
        private DateTime _maxEndDate;

        public DatePickerVMViewModel()
        {
            Title = TitleControl.myDnTPickerVMTitle;

            StartDate = new DateTime(DateTime.Now.Year, 1, 1);
            MinStartDate = new DateTime(DateTime.Now.Year, 1, 1);
            EndDate = new DateTime(DateTime.Now.Year, 12, 31);
            MaxEndDate = new DateTime(DateTime.Now.Year, 12, 31);
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set { SetProperty(ref _startDate, value); }
        }

        public DateTime MinStartDate
        {
            get { return _minStartDate; }
            set { SetProperty(ref _minStartDate, value); }
        }

        public DateTime EndDate
        {
            get { return _endDate; }
            set { SetProperty(ref _endDate, value); }
        }

        public DateTime MaxEndDate
        {
            get { return _maxEndDate; }
            set { SetProperty(ref _maxEndDate, value); }
        }

        private async void OnSubmit()
        {
            string msg = string.Empty;

            if (StartDate.ToShortDateString() == MinStartDate.ToShortDateString() &&
                EndDate.ToShortDateString() == MaxEndDate.ToShortDateString())
            {
                msg = "There was no change made. \n\n" +
                      "Initial Date: " + MinStartDate.ToShortDateString() + "\n" +
                      "Final Date: " + MaxEndDate.ToShortDateString();
            }
            else
            {
                msg = "The dates were changed! \n\n" +
                      "Original date initial selected was: " + MinStartDate.ToShortDateString() + "\n" +
                      "Original date final selected was: " + MaxEndDate.ToShortDateString() + "\n" +
                      "New date initial selected is: " + StartDate.ToShortDateString() + "\n" +
                      "New date final selected is: " + EndDate.ToShortDateString();
            }

            await Application.Current.MainPage.DisplayAlert(TitleControl.myDnTPickerVMTitle, msg, "OK");
        }
    }
}
