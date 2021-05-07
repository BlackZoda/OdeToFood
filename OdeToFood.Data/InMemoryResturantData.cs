using System;
using System.Collections.Generic;
using OdeToFood.Core;
using System.Linq;

namespace OdeToFood.Data
{
    public partial class InMemoryResturantData : IResturantData
    {
        List<Resturant> resturants;
        public InMemoryResturantData()
        {
            resturants = new List<Resturant>()
            {
                new Resturant { Id=1, Name="Eivind's Pizza", Location="Kristiansand", Cousine=CousineType.Italian },
                new Resturant { Id=2, Name="Siri's Spices", Location="Surnadal", Cousine=CousineType.Indian },
                new Resturant { Id=3, Name="Ivar's Taco", Location="Oslo", Cousine=CousineType.Mexican }
            };
        }

        public Resturant Update(Resturant updatedResturant)
        {
            var resturant = resturants.SingleOrDefault(r => r.Id == updatedResturant.Id);
            if (resturant != null)
            {
                resturant.Name = updatedResturant.Name;
                resturant.Location = updatedResturant.Location;
                resturant.Cousine = updatedResturant.Cousine;
            }
            return resturant;
        }

        public int Commit()
        {
            return 0;
        }

        public Resturant GetById(int id)
        {
            return resturants.SingleOrDefault(r => r.Id == id);
        }

        public Resturant Add(Resturant newResturant)
        {
            resturants.Add(newResturant);
            newResturant.Id = resturants.Max(r => r.Id) + 1;
            return newResturant;
        }
        public IEnumerable<Resturant> GetResturantsByName(string name = null)
        {
            return from r in resturants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }

        public Resturant Delete(int id)
        {
            var resturant = resturants.FirstOrDefault(r => r.Id == id);
            if (resturant != null)
            {
                resturants.Remove(resturant);
            }
            return resturant;
        }

        public int GetCountOfResturants()
        {
            return resturants.Count();
        }
    }
}