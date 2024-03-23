using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LINQ2
{
    class Employee
    {
        public int ID { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Position Position { get; set; }
        public Department Department { get; set; }
        public string Description { get; set; }

        public Employee(int id, string name, int age, Position position, Department department, string description)
        {
            ID = id;
            Name = name;
            Age = age;
            Position = position;
            Department = department;
            Description = description;
        }
    }

    class Department
    {
        public int ID { get; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Department(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }

    class Position
    {
        public int ID { get; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Position(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo các đối tượng Department
            Department department1 = new Department(1,"Phong ban IT","IT");
            Department department2 = new Department(2, "Phong ban Design", "Design");

            // Tạo các đối tượng Position
            Position position1 = new Position(1,"Back-end developer","IT");
            Position position2 = new Position(2,"Animation Designer", "Designer");

            // Tạo các đối tượng Employee
            Employee employee1 = new Employee(1,"Mai Thanh Tung", 25, position1, department1, "Nhiet tinh, sieng nang, thong minh");
            Employee employee2 = new Employee(2,"Nguyen Nhat Tan", 30, position1, department1, "Nhiet tinh, Luoi bieng");
            Employee employee3 = new Employee(3,"Le Van Sy", 35, position1, department1, "Thong minh, tu duy tot, sieng nang");
            Employee employee4 = new Employee(4, "Ngo Van Tuyen", 21, position2, department2, "Sieng nang, cham chi");

            // Tạo danh sách các đối tượng
            List<Department> departments = new List<Department> { department1, department2 };
            List<Position> positions = new List<Position> { position1, position2 };
            List<Employee> employees = new List<Employee> { employee1, employee2, employee3 };

            // Nhập thông tin tìm kiếm từ người dùng
            Console.Write("Tu khoa tim kiem: ");
            string keyword = Console.ReadLine();

            Console.Write("Tuoi tu: ");
            int minAge = int.Parse(Console.ReadLine());

            Console.Write("Den tuoi: ");
            int maxAge = int.Parse(Console.ReadLine());

            Console.Write("Vi tri: ");
            string positionKeyword = Console.ReadLine();

            Console.Write("Phong ban: ");
            string departmentKeyword = Console.ReadLine();

            // Tìm kiếm và in ra kết quả
            Console.WriteLine("Ket qua tim kiem:");
            Console.WriteLine("--------------------");

            foreach (Employee employee in employees)
            {
                bool match = (employee.Name.ToLower().Contains(keyword.ToLower()) || employee.Description.ToLower().Contains(keyword.ToLower()))
                    && employee.Age >= minAge && employee.Age <= maxAge
                    && (employee.Position.Name.Contains(positionKeyword) || employee.Position.Description.Contains(positionKeyword))
                    && (employee.Department.Name.Contains(departmentKeyword) || employee.Department.Description.Contains(departmentKeyword));

                if (match)
                {
                    Console.WriteLine("ID: " + employee.ID);
                    Console.WriteLine("Ten: " + employee.Name);
                    Console.WriteLine("Tuoi " + employee.Age);
                    Console.WriteLine("Vi tri: " + employee.Position.Name);
                    Console.WriteLine("Phong ban: " + employee.Department.Name);
                    Console.WriteLine("Mo ta: " + employee.Description);
                    Console.WriteLine("--------------------");
                }
            }
            Console.ReadKey();
        }
    }
}
