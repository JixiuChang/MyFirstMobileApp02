using MyFirstMobileApp.Models.Entities;
using SQLite;

namespace MyFirstMobileApp.Models.DataAccess
{
    public class SQLiteImplementation
    {
        //SQLiteAsyncConnection: Is a class provided by SQLite-net to facilitate asynchronous database operations.
        //con: This is a variable name chosen to represent the SQLite database connection.
        SQLiteAsyncConnection con;

        public SQLiteImplementation()
        {
            //Initialize and sets up the database. The method is async, as a result
            //we ignore any return value by using the discard symbole "_" which tells
            //the compiler that the result of the method is intentionally being ignored.
            //This can be useful when you have a method that returns a value,
            //but you don't need that value for the current operation.
            _ = InitializeDatabase();
        }

        //Method to get a connection to SQLite database with table creation
        private async Task InitializeDatabase()
        {
            if (con == null)
            {
                //Set the database file name
                string fileName = DbaseNames.ArknightDB;

                //Get the path to the personal folder on the device
                string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

                //Combine the document path and file name to get the complete path
                string path = Path.Combine(documentPath, fileName);

                //Check if the directory exists, create it if it doesn't
                if (!File.Exists(path))
                {
                    //Create the directory if it doesn't exist
                    Directory.CreateDirectory(documentPath);
                }

                //Initialize SQLite connection
                con = new SQLiteAsyncConnection(path);

                //Create 'Vacation' table if it does not exist
                await con.CreateTableAsync<ArknightsSQLite>();
            }
        }

        //Method to retrieve all vacations from the 'Vacation' table
        public async Task<List<ArknightsSQLite>> GetArknight()
        {
            //Use the returned connection from InitializeDatabase
            await InitializeDatabase();

            //SQL query to select all rows from 'Vacation' table
            string sql = "SELECT * FROM ArknightsSQLite";

            //Execute the query and retrieve a list of vacations
            List<ArknightsSQLite> myArknights = await con.QueryAsync<ArknightsSQLite>(sql);

            return myArknights;
        }

        //Method to save a new vacation record
        public async Task<string> SaveArknight(ArknightsSQLite myArknights)
        {
            string result = string.Empty;

            try
            {
                await InitializeDatabase();

                //Check if a record with the same Country and City already exists
                var existingArknights = await con.Table<ArknightsSQLite>()
                      .Where(a => a.OperatorName == myArknights.OperatorName && a.OperatorOrigin == myArknights.OperatorOrigin)
                      .FirstOrDefaultAsync();

                if (existingArknights == null)
                {
                    //Insert the vacation record into the 'Vacation' table
                    await con.InsertAsync(myArknights);
                }
                else
                {
                    //Record with the same Country and City already exists
                    string msg = myArknights.OperatorName + " from " + myArknights.OperatorOrigin + " already exists.";
                    //await Application.Current.MainPage.DisplayAlert("Message", msg, "Ok");

                    result = msg;
                }
            }
            catch (Exception ex)
            {
                result = "ERROR: " + ex.Message;
            }

            return result;
        }

        //Method to update an existing vacation record
        public async Task<bool> UpdateArknight(ArknightsSQLite myArknights)
        {
            bool res = false;

            try
            {
                //Use the returned connection from InitializeDatabase
                await InitializeDatabase();

                //$ is short-hand for String.Format, used with string 
                //interpolations (e.g. {0}).  Used in C# 6.0
                //SQL query to update vacation details based on the provided Id
                string sql = $"UPDATE Arknights " +
                                  $"SET OperatorName = '{myArknights.OperatorName}', " +
                                  $"OperatorOrigin = '{myArknights.OperatorOrigin}', " +
                                  $"OperatorOwned = '{myArknights.OperatorOwned}' " +
                                  $"WHERE Id = {myArknights.Id}";

                //Execute the update query
                await con.QueryAsync<ArknightsSQLite>(sql);
                res = true;
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }

            return res;
        }

        //Method to delete a vacation record based on the provided Id
        public async Task<bool> DeleteArknight(int Id)
        {
            bool res = false;

            try
            {
                //Use the returned connection from InitializeDatabase
                await InitializeDatabase();

                /*****************************************************************************
                 * A SQL query is not the correct usage for deleting records based on their primary key. 
                 * For deleting a record by its primary key, DeleteAsync expects the actual object or 
                 * the primary key value, not an SQL query.
                 ******************************************************************************/
                var arknightToDelete = await con.Table<ArknightsSQLite>().FirstOrDefaultAsync(a => a.Id == Id);

                if (arknightToDelete != null)
                {
                    //Delete the retrieved vacation
                    await con.DeleteAsync(arknightToDelete);
                    res = true;
                }
            }
            catch (Exception ex)
            {
                //Handle exceptions
                res = false;
            }

            return res;
        }
    }
}
