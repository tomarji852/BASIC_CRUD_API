namespace HelperProject
{
    public class UtilityConstant
    {
        public const string SelectQueryString = "SELECT *FROM Employee_Table WHERE EmpId = {0}";

        public const string InsertQueryString = "INSERT INTO Employee_Table (FirstName, LastName, Department, Salary) VALUES ('{0}', '{1}', '{2}', {3})";

        public const string UpdateQueryString = "UPDATE Employee_Table set FirstName = '{0}' , LastName = '{1}', Department = '{2}', Salary = {3}  WHERE EmpId = {4}";

        public const string DeleteQueryString = "DELETE FROM Employee_Table WHERE EmpId = {0}";

        public const string InsertSuccessMsg = "Inserted Successfully Please check in mySql database";

        public const string UpdateSuccessMsg = "Updated Successfully Please check in mySql database";

        public const string DeletSuccessMsg = "Deleted Successfully Please check in mySql database";

        public const string InvalidMsg = "Invalid input or id does not exist. Please enter a valid input";

    }
}
