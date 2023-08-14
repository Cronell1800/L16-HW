namespace L16_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1
            Rectangle rectangle = new Rectangle();
            rectangle.CalculatePerimeter();
            rectangle.CalculateArea();
            rectangle.CalculateDiagonal();

            Console.WriteLine();

            Rectangle rectangle1 = new Rectangle(3, 4);
            rectangle1.CalculatePerimeter();
            rectangle1.CalculateArea();
            rectangle1.CalculateDiagonal();

            Console.WriteLine();

            Circle circle = new Circle();
            circle.CalculatePerimeter();
            circle.CalculateArea();

            Console.WriteLine();

            Circle circle1 = new Circle(5);
            circle1.CalculatePerimeter();
            circle1.CalculateArea();

            #endregion

            Console.WriteLine();

            #region Task2
            Student student = new Student();
            student.DisplayInfo();
            Console.WriteLine();

            Student student1 = new Student("01", "John Johnson", "+99899 123-45-67", new int[] { 90, 85, 92, 78, 88 });
            student1.DisplayInfo();
            Console.WriteLine();

            Teacher teacher = new Teacher();
            teacher.DisplayInfo();
            Console.WriteLine();

            Teacher teacher1 = new Teacher("01", "John Cena", "+99899 999-99-99", 10.35m);
            teacher1.DisplayInfo();
            Console.WriteLine();

            Employee employee = new Employee();
            employee.DisplayInfo();
            Console.WriteLine();

            Employee employee1 = new Employee("01", "Kevin Bridge", "+99899 777-77-77", 5000);
            employee1.DisplayInfo();
            Console.WriteLine();
            #endregion
        }
    }

    class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Height = 0;
            Width = 0;
        }

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }
        public void CalculatePerimeter()
        {
            Console.WriteLine($"Perimeter of the rectangle: {2*(Height + Width)}");
        }

        public void CalculateArea()
        {
            Console.WriteLine($"Area of the rectangle: {Height * Width}");
        }

        public void CalculateDiagonal()
        {
            Console.WriteLine($"Diagonal of the rectangle: {Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2))}");
        }
    }

    class Circle
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 0;
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public void CalculatePerimeter()
        {
            Console.WriteLine($"Perimeter of the circle: {Radius * (Math.PI) * 2}");
        }

        public void CalculateArea()
        {
            Console.WriteLine($"Area of the circle: {Math.Pow(Radius, 2) * Math.PI}");
        }
    }



    class Person
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public Person()
        {
            Id = "Empty";
            FullName = "Empty";
            PhoneNumber = "Empty";
        }

        public Person(string id, string fullName, string phoneNumber)
        {
            this.Id = id;
            this.FullName = fullName;
            this.PhoneNumber = phoneNumber;
        }
    }
    class Student : Person
    {
        public int[] Marks { get; set; }

        public Student() : base() 
        {
            this.Marks = new int[1] {0};
        }

        public Student(string id, string fullName, string phoneNumber, int[] marks) : base(id, fullName, phoneNumber)
        {
            this.Marks = marks;
        }
        public double AverageGrade()
        {

            if (Marks.Length > 0)
            {
                double counter = 0;
                foreach (int mark in  Marks)
                {
                    counter += mark;
                }

                counter = counter / Marks.Length;
                return counter;
            }
            else
            {
                return 0;
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}" +
                $"\nStudent full name: {FullName}" +
                $"\nPhone number: {PhoneNumber}" +
                $"\nAverage Grade: {AverageGrade()}" +
                $"\nMarks: {string.Join(", ", Marks)}");
        }

    }

    class Teacher : Person
    {
        public decimal HourlyRate { get; set; }

        public Teacher() : base()
        {
            this.HourlyRate = 0;
        }

        public Teacher(string id, string fullName, string phoneNumber, decimal hourlyRate) : base(id, fullName, phoneNumber)
        {
            this.HourlyRate = hourlyRate;
        }

        public decimal CalculateMonthlyIncome()
        {
            return HourlyRate * 24 * 4;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}" +
                $"\nTeacher full name: {FullName}" +
                $"\nPhone number: {PhoneNumber}" +
                $"\nHourly Rate: {HourlyRate}" +
                $"\nMonthly income: {CalculateMonthlyIncome()}");
        }

    }

    class Employee : Person
    {
        public decimal Salary { get; set; }

        public Employee() : base()
        {
            this.Salary = 0;
        }

        public Employee(string id, string fullName, string phoneNumber, decimal salary) : base(id, fullName, phoneNumber)
        {
            this.Salary = salary;
        }

        public decimal CalculateTax()
        {
            return Salary * 0.13m;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}" +
                $"\nEmployee full name: {FullName}" +
                $"\nPhone number: {PhoneNumber}" +
                $"\nSalary: {Salary}" +
                $"\nTax: {CalculateTax()}");
        }

    }
}