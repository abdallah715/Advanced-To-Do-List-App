using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Diagnostics.SymbolStore;
using System.Runtime.CompilerServices;

namespace ToDoListDataAccessLayer
{
    public class clsToDoListDataAccess
    {
        static public DataTable GetAllTasks()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionSetting);
            string query = @"SELECT 
                    todo_List.Id, 
                    todo_List.IsDone AS ClickDone, 
                    todo_List.Description, 
                    Categories.CategoryName, 
                    FORMAT(todo_List.StartDate, 'dd-MM-yyyy') AS StartDate, 
                    FORMAT(todo_List.EndDate, 'dd-MM-yyyy') AS EndDate, 
                    todo_List.Status
                 FROM 
                    Categories 
                 INNER JOIN 
                    todo_List ON Categories.ID = todo_List.CategoryID";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }
        static public DataTable GetAllTasks(DateTime StartDate )
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionSetting);
            string query = @"
           SELECT todo_List.ID, 
           todo_List.IsDone as ClickDone, 
           todo_List.Description, 
           Categories.CategoryName, 
           FORMAT(StartDate, 'dd-MM-yyyy') AS StartDate, 
           FORMAT(EndDate, 'dd-MM-yyyy') AS EndDate, 
           todo_List.Status
     FROM Categories 
     INNER JOIN todo_List ON Categories.ID = todo_List.CategoryID
       WHERE CONVERT(date, StartDate) = CONVERT(date, @StartDate)";
            SqlCommand command = new SqlCommand(query, connection);
            StartDate = (StartDate == null)?DateTime.Now.Date : StartDate;
            command.Parameters.AddWithValue("@StartDate", StartDate);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    dt.Load(reader);
                }
                else dt = null;
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }
        static public DataTable GetAllPendingTasks()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionSetting);
            string query = @"SELECT 
         todo_List.Id, 
         todo_List.IsDone AS ClickDone, 
         todo_List.Description, 
         Categories.CategoryName, 
         FORMAT(todo_List.StartDate, 'dd-MM-yyyy') AS StartDate, 
         FORMAT(todo_List.EndDate, 'dd-MM-yyyy') AS EndDate, 
         todo_List.Status
      FROM 
         Categories 
      INNER JOIN 
         todo_List ON Categories.ID = todo_List.CategoryID 
      WHERE 
         todo_List.Status = 'Pending'
         AND CAST(todo_List.StartDate AS DATE) = CAST(GETDATE() AS DATE)";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }
        static public DataTable GetAllCompleteTasks()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionSetting);
            string query = @"
             SELECT 
              todo_List.Id, 
               todo_List.IsDone AS ClickDone, 
                todo_List.Description, 
               Categories.CategoryName, 
            FORMAT(todo_List.StartDate, 'dd-MM-yyyy') AS StartDate, 
             FORMAT(todo_List.EndDate, 'dd-MM-yyyy') AS EndDate, 
               todo_List.Status
                  FROM 
                Categories 
              INNER JOIN 
              todo_List ON Categories.ID = todo_List.CategoryID 
              WHERE 
                 todo_List.Status = 'Complete' 
                 AND CAST(todo_List.StartDate AS DATE) = CAST(GETDATE() AS DATE)";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }

        static public DataTable GetAllCategories()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionSetting);
            string query = "select * from Categories";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
        }
        static public bool AddNewCategory(string CategoryName)
        {
            int CategoryID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionSetting);
            string query = @"INSERT INTO Categories(CategoryName) VALUES (@CategoryName);
                                SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryName", CategoryName);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                connection.Close();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    CategoryID = insertedID;
                }
            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }
            return (CategoryID > 0);

        }
        static public bool DeleteCategory(string CategoryName)
        {
            int CategoryID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionSetting);
            string query = @"Delete From Categories 
                where CategoryName = @CategoryName;
                ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryName", CategoryName);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                connection.Close();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    CategoryID = insertedID;
                }
            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }
            return (CategoryID > 0);

        }
        static public int AddNewTask(string Description, int CategoryID, DateTime StartDate, DateTime EndDate, string Status, bool IsDone)
        {
            int TaskID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionSetting);

            string query = @"INSERT INTO todo_List (Description, CategoryID, StartDate, EndDate, Status, IsDone)
                            Values (@Description, @CategoryID, @StartDate, @EndDate, @Status, @IsDone);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);
            command.Parameters.AddWithValue("@StartDate", StartDate.Date);
            command.Parameters.AddWithValue("@EndDate", EndDate.Date);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@IsDone", IsDone);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                connection.Close();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    TaskID = insertedID;
                }

            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }
            return TaskID;




        }
        static public bool DeleteTaskById(int TaskID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionSetting);

            string query = @"Delete From todo_List 
                where Id = @ContactID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ContactID", TaskID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                return false;
            }
            finally { connection.Close(); }
            return (RowsAffected > 0);
        }
        static public bool UpdateDescription(int TaskID, string Description)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionSetting);
            string query = "UPDATE todo_List SET Description = @Description WHERE Id = @id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", TaskID);
            command.Parameters.AddWithValue("@Description", Description);


            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }
            return (RowsAffected > 0);
        }

        static public bool UpdateIsDone(int TaskID, bool isDone)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionSetting);
            string query = "UPDATE todo_List SET IsDone = @isDone, Status = @status WHERE Id = @id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", TaskID);
            command.Parameters.AddWithValue("@isDone", isDone); // Pass the boolean value directly

            // Set the status based on the checkbox value
            string status = isDone ? "Complete" : "Pending"; // or keep the existing status
            command.Parameters.AddWithValue("@status", status);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }
            return (RowsAffected > 0);
        }
    }
}
    


