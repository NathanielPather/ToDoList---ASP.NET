using System;
using System.Data.SqlClient;

namespace ToDoList.Helpers
{
    public class DbHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=ToDoList;");
        }
    }
}
