using System;

namespace ArraySortByIcomparable
{
    public class User: IComparable
    {
        public String Name;
        public int Age;

        public int CompareTo(object obj)
        {
            if (obj is User) {
            return this.Name.CompareTo((obj as User).Name);  // compare user names
            }
            throw new ArgumentException("Object is not a User");
        }

        public User(string name,int  age)
        {
            Name = name;
            Age = age;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            // array of custom type
            User[] users = new User[3] { new User("Betty", 23),  // name, age
                             new User("Susan", 20),
                             new User("Lisa", 25) };

            Array.Sort(users);  // sort array of User objects
            foreach (User user in users) Console.Write(user.Name + user.Age + " ");
            
        }
    }
}
