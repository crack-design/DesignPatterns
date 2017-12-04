using System;
using System.Collections.Generic;

namespace FuncAndActionDelegates
{
    class ArrSort
    {
        //Generic Sort method
        public static void Sort<T>(IList<T> sortArray, Func<T, T, bool> res)
        {
            bool mySort = true;
            do
            {
                mySort = false;
                for (int i = 0; i < sortArray.Count - 1; i++)
                {
                    if (res(sortArray[i + 1], sortArray[i]))
                    {
                        T j = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = j;
                        mySort = true;
                    }
                }
            } while (mySort);
        }
    }

    class UserInfo
    {
        public string Name { get; private set; }
        public string Family { get; private set; }
        public decimal Salary { get; private set; }

        public UserInfo(string Name, string Family, decimal Salary)
        {
            this.Name = Name;
            this.Family = Family;
            this.Salary = Salary;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, {2:C}", Name, Family, Salary);
        }

        public static bool UserSalary(UserInfo obj1, UserInfo obj2)
        {
            return obj1.Salary < obj2.Salary;
        }

        public static bool FamilyNameLength(UserInfo obj1, UserInfo obj2)
        {
            return obj1.Family.Length < obj2.Family.Length;
        }
    }

    class Program
    {
        static void Main()
        {
            UserInfo[] userinfo = { new UserInfo("Johm","Smith",50000000000),
                                  new UserInfo("Alex","Smith",100),
                                  new UserInfo("Jill","Salt",40000),
                                  new UserInfo("William","Saskachevan",1000000)};

            ArrSort.Sort(userinfo, UserInfo.UserSalary);

            Console.WriteLine("Sort by salary: \n" +
                "-------------------------------------\n");
            foreach (var ui in userinfo)
                Console.WriteLine(ui);

            ArrSort.Sort(userinfo, UserInfo.FamilyNameLength);
            Console.WriteLine("Sort by lastname: \n" +
                "-------------------------------------\n");

            foreach (var ui in userinfo)
                Console.WriteLine(ui);

            Console.ReadLine();
        }
    }
}