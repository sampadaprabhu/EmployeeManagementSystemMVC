using EmpManagementML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagementBL.implementation
{
    public interface IEmpManagementBusinessLayer
    {
        bool AddEmployee(EmpManagementModelLayer empManagementML);

        bool UpdateEmployee(EmpManagementModelLayer empManagementML);

        bool DeleteEmployee(string EmpID);

        DataSet GetAllEmployee();
    }
}
