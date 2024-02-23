namespace StudentAdministrasjon
{
    class Student
    {
        private int _id;
        private string _name;
        private int _age;
        private Course[] _courses;

        public Student(int id, string name, int age, Course[] courses)
        {
            this._id = id;
            this._name = name;
            this._age = age;
            this._courses = courses;
        }

        public string getName()
        {
            return this._name;
        }

        public string printCourses()
        {
            string courses = "";
            for (int i = 0; i < _courses.Length; i++)
            {
                courses += _courses[i].getName();
                if (i < _courses.Length - 1)
                {
                    courses += ", ";
                }
            }
            return courses;
        }

        public int getStudyPoints()
        {
            int points = 0;
            for (int i = 0; i < _courses.Length; i++)
            {
                points += _courses[i].getPoints();
            }
            return points;
        }

        public void print()
        {
            Console.WriteLine($"ID: {_id}, Name: {_name}, Age: {_age}, Courses: {printCourses()}");
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

        public int getPoints()
        {
            return this._points;
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

        static Course[] _courses;

        static Grade _grade1;
        static Grade _grade2;
        static Grade _grade3;
        static Grade _grade4;
        static Grade _grade5;
        static Grade _grade6;

        static Program()
        {
            _courses = new Course[] {
                                new Course(1, "Math", 10),
                                new Course(2, "Science", 5),
                                new Course(3, "English", 15),
                        };

            _student1 = new Student(1, "John", 20, _courses);
            _student2 = new Student(2, "Jane", 21, _courses);

            _grade1 = new Grade(_student1, _courses[0], 3);
            _grade2 = new Grade(_student1, _courses[1], 6);
            _grade3 = new Grade(_student1, _courses[2], 4);
            _grade4 = new Grade(_student2, _courses[0], 2);
            _grade5 = new Grade(_student2, _courses[1], 4);
            _grade6 = new Grade(_student2, _courses[2], 5);
        }

        static void Main(string[] args)
        {
            _student1.print();
            _student2.print();
            _grade1.print();
            _grade2.print();
        }
    }
}
