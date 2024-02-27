using SQLite;

namespace MyFirstMobileApp.Models.Entities
{
    public class ArknightsSQLite
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }
        //[MaxLength(250), Unique]
        public string OperatorName { get; set; }
        public string OperatorOrigin { get; set; }
        public int OperatorOwned { get; set; } = 0;
    }
}
