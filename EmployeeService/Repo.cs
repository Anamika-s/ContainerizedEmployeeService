using CodeFirstApproach.Context;
using CodeFirstApproach.Models;

namespace CodeFirstApproach
{
    public class Repo : IRepo
    {
        private EmpDbContext _context;
        public Repo(EmpDbContext context)
        {
            _context = context;
        }
        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public int DeleteEmployee(int id)
        {
            var obj = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (obj != null)
            {
                _context.Employees.Remove(obj);
                _context.SaveChanges();
                }
                return id;
        }
        public List<Employee> Get()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.FirstOrDefault(x => x.Id == id);
        }

        public Employee UpdateEmployee(int id, Employee employee)
        {
            var obj = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (obj != null)
            {
                foreach (Employee emp in _context.Employees)
                {
                    if (emp.Id == id)
                    {
                        emp.Address = employee.Address;
                        emp.Age = employee.Age;
                    
                    }
                    _context.SaveChanges();
                }
            }
            return obj;
        }
    }
}
