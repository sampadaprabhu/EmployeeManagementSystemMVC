using EmpManagementBL.implementation;
using EmpManagementML;
using EmpManagementRL;
using EmpManagementRL.implementation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagementBL
{
    public class EmpManagementBusinessLayer : IEmpManagementBusinessLayer
    {
        private readonly IEmpManagementRepositoryLayer empManagementRepositoryLayer=new EmpManagementRepositoryLayer();
        public bool AddEmployee(EmpManagementModelLayer empManagementML)
        {
            try
            {
                return this.empManagementRepositoryLayer.AddEmployee(empManagementML);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool UpdateEmployee(EmpManagementModelLayer empManagementML)
        {
            try
            {
                return this.empManagementRepositoryLayer.UpdateEmployee(empManagementML);
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
                return this.empManagementRepositoryLayer.DeleteEmployee(EmpID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DataSet GetAllEmployee()
        {
            try
            {
                return this.empManagementRepositoryLayer.GetAllEmployee();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
