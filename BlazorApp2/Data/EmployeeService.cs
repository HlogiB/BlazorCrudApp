namespace BlazorApp2.Data
{
    public class EmployeeService : IEmployeeService
    {

        private List<Employee> employees = new List<Employee>
        {
            new Employee { Id = Guid.NewGuid(),
            Name= "Emplle",
            Contact="0978484",
            Address="Santon"},
            new Employee { Id = Guid.NewGuid(),
            Name= "Employee ",
            Contact="0978484",
            Address="Sandton"}
        };

        public void AddEmployee(Employee employee)
        {
            var id = Guid.NewGuid();
            employee.Id= id;
            employees.Add(employee);
        }

        public void DeleteEmployee(Guid id)
        {
            var employee= GetEmployee(id);
            employees.Remove(employee);
        }

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void UpdateEmployee(Employee employee)
        {
            var getOldEmployee = GetEmployee(employee.Id);
            getOldEmployee.Name = employee.Name;
        }
    }
}
