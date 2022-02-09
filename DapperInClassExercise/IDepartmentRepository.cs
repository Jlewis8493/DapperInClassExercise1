using System;
using System.Collections.Generic;

namespace DapperInClassExercise
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}
