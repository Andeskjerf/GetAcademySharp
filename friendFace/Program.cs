namespace FriendFace
{
    class User
    {
        private string _name;
        private List<User> _friends;

        public User(string name)
        {
            _name = name;
            _friends = new List<User>();
        }

        public void addFriend(User friend)
        {
            _friends.Add(friend);
        }

        public void removeFriend(User friend)
        {
            _friends.Remove(friend);
        }

        public List<User> getFriends()
        {
            return _friends;
        }

        public string getName()
        {
            return _name;
        }
    }

    class Program
    {
        static List<User> users = new List<User>();
        static User mainUser = new User("root");

        static string[] options = {
                    "Add friend",
                    "View friends",
                    "Remove friend",
                    "Exit"
                };

        static Program()
        {
            users.Add(new User("Kåre"));
            users.Add(new User("Bernt"));
            users.Add(new User("Kari"));
            users.Add(new User("Bernard"));
            users.Add(new User("Karl"));
            users.Add(new User("Anders"));
            users.Add(new User("Julie"));
            users.Add(new User("Åshild"));
            users.Add(new User("Marie"));
            users.Add(new User("Håkon"));
            users.Add(new User("Simen"));
        }

        static void printOptions()
        {
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + options[i]);
            }
        }

        static void printUsers(List<User> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + users[i].getName());
            }
        }

        static int getOption()
        {
            int option = Convert.ToInt32(Console.ReadLine());
            if (option > options.Length || option < 1)
            {
                Console.WriteLine("Invalid option");
                return -1;
            }
            return option;
        }

        static void addFriend()
        {
            printUsers(users);
            int option = getOption();
            if (option == -1) return;
            mainUser.addFriend(users[option - 1]);
        }

        static void removeFriend()
        {
            printUsers(mainUser.getFriends());
            int option = getOption();
            if (option == -1) return;
            mainUser.removeFriend(mainUser.getFriends()[option - 1]);
        }

        static void showFriends()
        {
            List<User> friends = mainUser.getFriends();
            for (int i = 0; i < friends.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + friends[i].getName());
            }
        }

        static void Main()
        {
            while (true)
            {
                printOptions();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addFriend();
                        break;
                    case 2:
                        showFriends();
                        break;
                    case 3:
                        removeFriend();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
