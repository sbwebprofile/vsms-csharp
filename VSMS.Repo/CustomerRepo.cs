using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSMS.Data;
using VSMS.Entity;



namespace VSMS.Repo
{
    public class CustomerRepo
    {


        public customer Create(customer newCustomer)
        {
            using (var db = new VSMSContext())
            {
                db.customers.Add(newCustomer);
                db.SaveChanges();
            }
            return newCustomer;
        }
    
    
    
 }
}
