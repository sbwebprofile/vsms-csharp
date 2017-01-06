using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSMS.Data;
using VSMS.Entity;
using VSMS.Repo.ViewModel;


namespace VSMS.Repo
{
    public class VehicleRepo
    {


        public vehicle Create(vehicle newVehicle)
        {
            using (var db = new VSMSContext())
            {
                db.vehicles.Add(newVehicle);
                db.SaveChanges();
            }
            return newVehicle;
        }

       
       public IEnumerable<vehicleViewModel> GetAllViewModel()
        {
            using (var db = new VSMSContext())
            {
                var vehicleid = db.vehicles.Select(a => new vehicleViewModel
                {
                    vehicleId = a.vehicleId,
                    model=a.model,
                    chasisNo=a.chasisNo,
                    brand=a.brand,
                    manufacturer=a.manufacturer,
                    Made_Year=a.mYear,
                    color=a.color,
                    engineNo=a.engineNo,
                    status=a.status,
                    image=a.image
                    
                }).ToList();

                return vehicleid;
            } 
        }

     
        public IEnumerable<soldVehicleViewModel> GetSoldView()
       {
           using (var db = new VSMSContext())
           {
           
               var  Customerid = db.customers.Where(a => a.vehicle.status.Equals("Sold")).Select(a => new soldVehicleViewModel
               {
                   
                   CustomerId = a.customerId,
                   CustomerName = a.fName+" "+a.lName,
                   DateSold=a.invoiceDate,
                   CarId=a.vehicleId,
                   PriceBought=a.vehicle.bprice,
                   Pricesold=a.vehicle.sprice,
                   Mobile=a.mobile
               }).ToList();

               return Customerid;
           }
       } 


        public bool Delete(int rowId)
        {
            using (var db = new VSMSContext())
            {
                var toBeDeleted = db.vehicles.SingleOrDefault(c => c.vehicleId == rowId);
                db.vehicles.Remove(toBeDeleted);
                db.SaveChanges();
            }
            return true;

        }
        public void Update(int id_of_car, int sellPrice)         //selling a vehicle
        {
            using (var db = new VSMSContext())
            {
                var toBeUpdated = db.vehicles.Where(c => c.vehicleId == id_of_car).First();
                toBeUpdated.sprice = sellPrice;
                toBeUpdated.status = "Sold";
                db.SaveChanges();

            }
        
        }
    
    
    }
}
