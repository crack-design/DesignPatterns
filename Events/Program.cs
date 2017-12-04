using System;

namespace Events
{
    delegate void UI();

    class MyEvent
    {
        public event UI UserEvent;

        public void OnUserEvent()
        {
            UserEvent();
        }
    }

    class UserInfo
    {
        string uiName, uiFamily;
        int uiAge;

        public UserInfo(string Name, string Family, int Age)
        {
            this.Name = Name;
            this.Family = Family;
            this.Age = Age;
        }

        public string Name { set { uiName = value; } get { return uiName; } }
        public string Family { set { uiFamily = value; } get { return uiFamily; } }
        public int Age { set { uiAge = value; } get { return uiAge; } }

        public void UserInfoHandler()
        {
            Console.WriteLine("Event was called\n");
            Console.WriteLine("Name: {0}\nLast Name: {1}\nAge: {2}", Name, Family, Age);
        }
    }

    class Program
    {
        static void Main()
        {
            MyEvent evt = new MyEvent();
            UserInfo user1 = new UserInfo(Name: "John", Family: "Smith", Age: 40);

            evt.UserEvent += user1.UserInfoHandler;

            evt.OnUserEvent();

            Console.ReadLine();
        }
    }
}
