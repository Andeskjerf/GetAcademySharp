namespace StudentAdministrasjon
{
    class Student
    {
        private int _id;
        private string _name;
        private int _age;
        private Course _course;

        public Student(int id, string name, int age, Course course)
        {
            this._id = id;
            this._name = name;
            this._age = age;
            this._course = course;
        }

        public string getName()
        {
            return this._name;
        }

        public void print()
        {
            Console.WriteLine($"ID: {_id}, Name: {_name}, Age: {_age}, Course: {_course.getName()}");
        }
    }

    class Course
    {
        private int _code;
        private string _name;
        private int _points;

        public Course(int id, string name, int points)
        {
            this._code = id;
            this._name = name;
            this._points = points;
        }

        public string getName()
        {
            return this._name;
        }

        public void print()
        {
            Console.WriteLine($"Code: {_code}, Name: {_name}, Points: {_points}");
        }

    }

    class Grade
    {
        private Student _student;
        private Course _course;
        private int _points;

        public Grade(Student student, Course course, int points)
        {
            this._student = student;
            this._course = course;
            this._points = points;
        }

        public void print()
        {
            Console.WriteLine($"Student name: {_student.getName()}, Course name: {_course.getName()}, Points: {_points}");
        }

    }

    class Program
    {
        static Student _student1;
        static Student _student2;

        static Course _course1;
        static Course _course2;

        static Grade _grade1;
        static Grade _grade2;

        static Program()
        {
            _course1 = new Course(1, "Math", 10);
            _course2 = new Course(2, "Science", 5);

            _student1 = new Student(1, "John", 20, _course1);
            _student2 = new Student(2, "Jane", 21, _course2);

            _grade1 = new Grade(_student1, _course1, 5);
            _grade2 = new Grade(_student2, _course2, 5);
        }

        static void Main(string[] args)
        {
            _course1.print();
            _course2.print();
            _student1.print();
            _student2.print();
            _grade1.print();
            _grade2.print();
        }
    }
}
