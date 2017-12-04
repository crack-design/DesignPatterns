using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    delegate Name UI(FamilyAndName obj);

    public class Name
    {
        public string myName;
    }

    public class FamilyAndName : Name
    {
        public string Family;
    }

    public class UserInfo
    {
        public static Name UIName(Name obj)
        {
            obj.myName = "User Name: \"" + obj.myName + "\"";
            return obj;
        }

        public static FamilyAndName UIFamilyName(FamilyAndName obj)
        {
            obj.Family = "Name and lastname:  \"" + obj.myName + " " + obj.Family + "\"";
            return obj;
        }
    }

    class Program
    {
        static void Main()
        {
            //Covariance
            UI user1 = UserInfo.UIFamilyName;
            //Contravariance
            user1 = UserInfo.UIName;
        }
    }
}
