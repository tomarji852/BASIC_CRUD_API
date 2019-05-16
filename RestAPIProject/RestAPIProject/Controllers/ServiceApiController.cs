using HelperProject;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Web.Http;

namespace RestAPIProject.Controllers
{
    [RoutePrefix("api/{controller}/{action}")]
    public class ServiceApiController : ApiController
    {

        /// <summary>
        /// This method get the total rows entries from mySql tables 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>JsonString</returns>
        public string GetSelectedItems(int id)
        {
            var jsonResult = new StringBuilder();
            try
            {
                string selectQuery = string.Format(UtilityConstant.SelectQueryString, id);

                //establishment of connection 
                MySqlConnection mySqlConnection = SqlConnectionProvider.GetConnection();
                MySqlCommand cmd = new MySqlCommand(selectQuery, mySqlConnection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Json parsing of table row 
                var dataTable = new DataTable();
                dataTable.Load(dataReader);
                string JSONString = (dataTable.Rows.Count > 0) ?
                    JsonConvert.SerializeObject(dataTable) : UtilityConstant.InvalidMsg;

                //close connection 
                mySqlConnection.Close();

                return JSONString;

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// This method Insert the entry in mySql db on server 
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>SuccesMessage</returns>
        [DisplayName("Insert_Employee_Details")]
        public string Post(Employee employee)
        {
            try
            {
                //Insert query---
                string insertQuery = string.Format(UtilityConstant.InsertQueryString, employee.FirstName,
                    employee.LastName, employee.Department, employee.Salary);

                //establishment of connection 
                MySqlConnection mySqlConnection = SqlConnectionProvider.GetConnection();
                MySqlCommand cmd = new MySqlCommand(insertQuery, mySqlConnection);
                int numberOfRecords = cmd.ExecuteNonQuery();
                string response = (numberOfRecords > 0) ? UtilityConstant.InsertSuccessMsg : UtilityConstant.InvalidMsg;

                //close connection 
                mySqlConnection.Close();

                return response;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// This method update the existing query in data table on server 
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>SuccessMessage</returns>
        [DisplayName("Update_Employee_Details")]
        public string Put(Employee employee, int id)
        {
            try
            {
                string updateQuery = string.Format(UtilityConstant.UpdateQueryString, employee.FirstName,
                    employee.LastName, employee.Department, employee.Salary, id);

                //establishment of connection 
                MySqlConnection mySqlConnection = SqlConnectionProvider.GetConnection();
                MySqlCommand cmd = new MySqlCommand(updateQuery, mySqlConnection);
                int numberOfRecords = cmd.ExecuteNonQuery();
                string response = (numberOfRecords > 0) ? UtilityConstant.UpdateSuccessMsg : UtilityConstant.InvalidMsg;
                
                //close connection 
                mySqlConnection.Close();

                return response;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// This method delete the entry from the Mysql table on server 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>SuccesMessage</returns>
        [DisplayName("Delete_Employee_Details")]
        public string Delete(int id)
        {
            try
            {
                string deleteQuery = string.Format(UtilityConstant.DeleteQueryString, id);

                //establishment of connection 
                MySqlConnection mySqlConnection = SqlConnectionProvider.GetConnection();
                MySqlCommand cmd = new MySqlCommand(deleteQuery, mySqlConnection);
                int numberOfRecords = cmd.ExecuteNonQuery();
                string response = (numberOfRecords > 0) ? UtilityConstant.DeletSuccessMsg : UtilityConstant.InvalidMsg;
                
                //close connection 
                mySqlConnection.Close();

                
                return response;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
