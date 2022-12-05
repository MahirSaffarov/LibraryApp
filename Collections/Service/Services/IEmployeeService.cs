using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public interface IEmployeeService
    {
        int GetFilteredEmployeesCount(DateTime start, DateTime end, double salary);
    }
}
