using System;

namespace ArraySort
{
    public class  User
    {
        public string Name;
         public int Age;
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // sort int array
            int[] intArray = new int[5] { 8, 10, 2, 6, 3 };
            Array.Sort(intArray);
            // write array
            foreach (int i in intArray) Console.Write(i + " ");  // output: 2 3 6 8 10

            Console.WriteLine();

            // sort string array
            string[] stringArray = new string[5] { "X", "B", "Z", "Y", "A" };
            Array.Sort(stringArray);
            // write array

            foreach (string str in stringArray) Console.Write(str + " "); // output: A B X Y Z

             Console.WriteLine();

             // array of custom type
             User[] users = new User[3] { new User("Betty", 23), new User("Susan", 20), new User("Lisa", 25) };

            // sort array by name
            Array.Sort(users, delegate(User user1, User user2) {
                                return user1.Name.CompareTo(user2.Name);
                            });
            // write array (output: Betty23 Lisa25 Susan20)
            foreach (User user in users) Console.Write(user.Name + user.Age + " ");
             Console.WriteLine();

             // sort array by age
            Array.Sort(users, delegate(User user1, User user2) {
                                return user1.Age.CompareTo(user2.Age); // (user1.Age - user2.Age)
                            });
            // write array (output: Susan20 Betty23 Lisa25)
            foreach (User user in users) Console.Write(user.Name + user.Age + " ");
            Console.WriteLine();

        }
    }
}
