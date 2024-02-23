namespace organTransplant
{
    enum KidneyPosition
    {
        Left = 0,
        Right = 1
    }

    class Kidney
    {
        private bool _isWorking;

        public Kidney(bool isWorking)
        {
            _isWorking = isWorking;
        }

        public bool isWorking()
        {
            return _isWorking;
        }
    }

    class Person
    {
        private string _name;
        private bool _alive;
        private Kidney[] _kidneys;

        public Person(string name, Kidney[] kidneys)
        {
            _name = name;
            _kidneys = kidneys;
            _alive = true;
        }

        public bool isAlive()
        {
            return _alive;
        }

        public Kidney? extractKidney(KidneyPosition position)
        {
            if ((int)position >= _kidneys.Length)
            {
                Console.WriteLine("No kidney found at position: " + position);
                return null;
            }
            Kidney kidney = _kidneys[(int)position];
            _kidneys = _kidneys.Where((val, index) => index != (int)position).ToArray();
            Console.WriteLine($"Kidney extracted from {_name}!");
            if (_kidneys.Length <= 0 && _alive)
            {
                Console.WriteLine($"No more kidneys left in {_name}, oh no!! {_name} is dead!");
                _alive = false;
            }
            return kidney;
        }

        public void insertKidney(Kidney kidney)
        {
            _kidneys = _kidneys.Append(kidney).ToArray();
            Console.WriteLine($"Kidney inserted into {_name}!");
            if (_kidneys.Length > 2 && _alive)
            {
                Console.WriteLine($"More than 2 kidneys have been inserted, oh no!! {_name} is dead!");
                _alive = false;
            }
        }
    }

    class Program
    {
        static Person bernt;
        static Person kåre;

        static Program()
        {
            bernt = new Person("Bernt", new Kidney[] { new Kidney(true), new Kidney(false) });
            kåre = new Person("Kåre", new Kidney[] { new Kidney(true), new Kidney(true) });
        }

        static void Main(string[] args)
        {
            bernt.extractKidney(KidneyPosition.Right);
            Kidney kidney = kåre.extractKidney(KidneyPosition.Right);
            bernt.insertKidney(kidney);
        }
    }
}
