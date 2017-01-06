using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSMS.Data;
using VSMS.Entity;

namespace VSMS.Repo
{
   public class ComboboxRepo
    {
        
       public comboboxdata Create(comboboxdata newcomboboxdata)
        {
            using (var db = new VSMSContext())
            {
                db.comboboxdatas.Add(newcomboboxdata);
                db.SaveChanges();
            }
            return newcomboboxdata;
        }

       public IEnumerable<comboboxdata> GetAll()
       {
           using (var db = new VSMSContext())
           {
               var model = db.comboboxdatas.ToList();
               return model;
           }
       }

    }
}
