using UnitTestingHOPE.DataAccessLayer.Models;

namespace UnitTestingHOPE.DataAccessLayer.Interface
{
    public interface IEmployeeRepository
    {
        IList<Employee> GetEmployees();

        Employee GetEmployeeById(int id);

        bool AddEmployee(Employee employee);
        bool DeleteEmployee(Employee employee);
        bool UpdateEmployee(Employee employee);
    }
}
