using EmpManagementML;
using EmpManagementRL.implementation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagementRL
{
    public class EmpManagementRepositoryLayer : IEmpManagementRepositoryLayer
    {
        static string connect = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        SqlConnection connection = new SqlConnection(connect);

        public bool AddEmployee(EmpManagementModelLayer empManagementModelLayer)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("SPAddEmployeeData", this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", empManagementModelLayer.FirstName);
                    command.Parameters.AddWithValue("@LastName", empManagementModelLayer.LastName);
                    command.Parameters.AddWithValue("@EmailID", empManagementModelLayer.EmailID);
                    command.Parameters.AddWithValue("@PhoneNumber", empManagementModelLayer.PhoneNumber);
                    command.Parameters.AddWithValue("@DepartmentID", empManagementModelLayer.DepartmentID);
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }

        public bool UpdateEmployee(EmpManagementModelLayer empManagementModelLayer)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("SPUpdateEmployeeData", this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmpID", empManagementModelLayer.EmpID);
                    command.Parameters.AddWithValue("@FirstName", empManagementModelLayer.FirstName);
                    command.Parameters.AddWithValue("@LastName", empManagementModelLayer.LastName);
                    command.Parameters.AddWithValue("@EmailID", empManagementModelLayer.EmailID);
                    command.Parameters.AddWithValue("@PhoneNumber", empManagementModelLayer.PhoneNumber);
                    command.Parameters.AddWithValue("@DepartmentID", empManagementModelLayer.DepartmentID);
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool DeleteEmployee(string EmpID)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("SPDeleteEmployeeData", this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmpID", Convert.ToInt32(EmpID));
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
    }
}