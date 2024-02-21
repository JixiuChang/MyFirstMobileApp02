using MyFirstMobileApp.Models.Entities;

namespace MyFirstMobileApp.ViewViewModels.SQLite;

public partial class ArknightMgmtView : ContentPage
{
    public ArknightMgmtView(ArknightsSQLite myArknight)
    {
        InitializeComponent();
        BindingContext = new ArknightMgmtViewModel(myArknight);
    }
}