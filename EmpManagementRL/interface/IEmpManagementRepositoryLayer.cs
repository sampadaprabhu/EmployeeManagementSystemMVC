﻿using EmpManagementML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagementRL.implementation
{
    public interface IEmpManagementRepositoryLayer
    {
        bool AddEmployee(EmpManagementModelLayer empManagementModelLayer);

        bool UpdateEmployee(EmpManagementModelLayer empManagementModelLayer);

        bool DeleteEmployee(string EmpID);

        DataSet GetAllEmployee();
    }
}
