using MyFirstMobileApp.Models.Entities;
using SQLite;

namespace MyFirstMobileApp.Models.DataAccess
{
    public interface ISQLite2
    {
        //SQLiteConnection InitializeDatabase();

        List<ArknightsSQLite> GetVacation();

        bool SaveVacation(ArknightsSQLite arknight);

        bool UpdateVacation(ArknightsSQLite arknight);

        void DeleteVacation(int Id);
    }
}
