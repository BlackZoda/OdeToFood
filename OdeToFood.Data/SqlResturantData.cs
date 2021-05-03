using System.Collections.Generic;
using System.Linq;
using OdeToFood.Core;
using Microsoft.EntityFrameworkCore;

namespace OdeToFood.Data
{
    public class SqlResturantData : IResturantData
    {
        private readonly OdeToFoodDbContext db;
        public SqlResturantData(OdeToFoodDbContext db)
        {
            this.db = db;
        }
        public Resturant Add(Resturant newResturant)
        {
            db.Add(newResturant);
            // same as db.Resturant.Add()
            return newResturant;
        }

        public int Commit()
        {
            return db.SaveChanges();
            // return # of rows changed
            // nothing happens in the database before this is called
        }

        public Resturant Delete(int id)
        {
            var resturant = GetById(id);
            if (resturant != null)
            {
                db.Resturants.Remove(resturant);
            }
            return resturant;
        }

        public Resturant GetById(int id)
        {
            return db.Resturants.Find(id);
        }

        public IEnumerable<Resturant> GetResturantsByName(string name)
        {
            var query = from r in db.Resturants
                        where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Name
                        select r;

            return query;
        }

        public Resturant Update(Resturant updatedResturant)
        {
            var entity = db.Resturants.Attach(updatedResturant);
            entity.State = EntityState.Modified;
            return updatedResturant;
        }
    }
}