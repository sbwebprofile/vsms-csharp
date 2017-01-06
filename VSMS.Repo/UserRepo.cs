using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSMS.Data;
using VSMS.Entity;


namespace VSMS.Repo
{
    public class UserRepo
    {
        public int IsExist(string uname, string pass)
        {
            using (var db = new VSMSContext())
            {
                var count = db.users.Count(t => t.userName == uname && t.userPass == pass && t.userType == "Admin");
                var count2 = db.users.Count(t => t.userName == uname && t.userPass == pass && t.userType == "Employee");
                if (count > 0)
                {
                    return 1;
                }
                else if (count2 > 0) 
                {
                    return 2;
                }

                return 0;
            }
        }
        public user Create(user newuser)
        {
            using (var db = new VSMSContext())
            {
                db.users.Add(newuser);
                db.SaveChanges();
            }
            return newuser;
        }

    }
}
