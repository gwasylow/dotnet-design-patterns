using Behavioral.Visitor.ConcreteElement;
using Behavioral.Visitor.InterfaceVisitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Visitor.ObjectStructure
{
    /// <summary>
    /// The 'ObjectStructure' class
    /// </summary>
    public class Employees
    {
        private List<Employee> _employees = new List<Employee>();

        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            _employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Employee emp in _employees)
                emp.Accept(visitor);

            Console.WriteLine();
        }
    }
}
