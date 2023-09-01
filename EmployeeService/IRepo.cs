using CodeFirstApproach.Models;

namespace CodeFirstApproach
{
    public interface IRepo
    {
        List<Employee> Get();
        Employee GetEmployee(int id);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(int id, Employee employee); 
        int DeleteEmployee(int id);
    }
}
